using System.Globalization;
using System.IO.Compression;
using System.Logging.Contexts;
using System.Logging.Debugs;
using System.Logging.Interpolators;
using System.Logging.Utils;
using System.Runtime.CompilerServices;
using System.Text;

// ReSharper disable LocalizableElement
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable CS8618 // Non-null value when exiting constructor.

namespace System.Logging.Targets;

public sealed class LoggerFileTarget : LoggerTarget
{
    private const string DateTimeFormat = "yyyy-MM-dd";

    // ReSharper disable once StringLiteralTypo
    private static readonly char[] SaltSamples = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();

    private static readonly string ApplicationDirectory = AppDomain.CurrentDomain.BaseDirectory;

    private readonly Lock _locker = new();

    private readonly string _directoryPath;

    private readonly string _filePrefix;

    private readonly int _encodingBufferCapacity;

    private readonly char[] _encodingBuffer;

    private readonly int _convertingBufferCapacity;

    private readonly StringBuilder _convertingBuffer;

    private readonly int _writingBufferCapacity;

    private readonly TimeSpan _writingBufferInterval;

    private readonly MemoryStream _writingBuffer;

    private DateTime _logsDate;

    private FileStream? _logsStream;

    private bool _isLogsStreamOpen;

    private DateTime _lastWritingBufferClearTime;

    public LoggerFileTarget(string logFilePrefix, string logsAndArchivesDirectoryPath)
    {
        ArgumentException.ThrowIfNullOrEmpty(logFilePrefix);
        ArgumentException.ThrowIfNullOrEmpty(logsAndArchivesDirectoryPath);

        WritingBufferInterval = TimeSpan.FromSeconds(5);
        EncodingBufferCapacity = Bytes.FromKilobytes(2);
        ConvertingBufferCapacity = Bytes.FromKilobytes(4);
        WritingBufferCapacity = Bytes.FromKilobytes(512);

        _filePrefix = logFilePrefix;
        _directoryPath = Path.Combine(ApplicationDirectory, logsAndArchivesDirectoryPath);
    }

    public int FileSizeForArchiving { get; init; } = Bytes.FromMegabytes(2);

    public int FileArchivesDeleteAfterDays { get; init; } = 30;

    public CompressionLevel FileArchiveCompression { get; init; } = CompressionLevel.SmallestSize;

    public Encoding FileEncoding { get; init; } = Encoding.UTF8;

    public string FileNewLine { get; init; } = Environment.NewLine;

    public int EncodingBufferCapacity
    {
        get => _encodingBufferCapacity;
        init => _encodingBuffer = new char[_encodingBufferCapacity = value];
    }

    public int ConvertingBufferCapacity
    {
        get => _convertingBufferCapacity;
        init => _convertingBuffer = new StringBuilder(_convertingBufferCapacity = value);
    }

    public int WritingBufferCapacity
    {
        get => _writingBufferCapacity;
        init => _writingBuffer = new MemoryStream(_writingBufferCapacity = value);
    }

    public TimeSpan WritingBufferInterval
	{
		get => _writingBufferInterval;
		init => _writingBufferInterval = value;
	}

    public override void Initialize(CancellationToken cancellationToken)
    {
        lock (_locker)
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThan(EncodingBufferCapacity, ConvertingBufferCapacity);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(ConvertingBufferCapacity, WritingBufferCapacity);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(WritingBufferCapacity, FileSizeForArchiving);
            ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(FileSizeForArchiving, 0);

            ThrowIfFilePrefixContainsNotLetter();

            if (SyncLogs() is false)
            {
#if DEBUG
                DebugEventLogger.Notify("Error while trying to sync logs file when initializing target");
#endif

                return;
            }

            ArchiveDeprecatedDaysLogs();
            DeleteDeprecatedLogsArchives();
        }
    }

    public override void Publish(in LogContext logContext, ILogInterpolator logInterpolator, CancellationToken cancellationToken)
    {
        lock (_locker)
        {
            if (IsLogsDateChangingRequired(logContext.Time.DateTime))
            {
                MoveNextDateWithLogsArchivingOfPrevious();
            }
            else if (IsLogsFileSplittingRequired())
            {
                SplitLogsToArchive();
            }

            TransferLogToWritingBuffer(logContext, logInterpolator);

            if (IsWritingBufferWritingThresholdReached(logContext.Time.UtcDateTime) is false)
            {
                return;
            }

            TransferWritingBufferToLogsStream();
        }
    }

    public override void Dispose(CancellationToken cancellationToken)
    {
        lock (_locker)
        {
            TransferWritingBufferToLogsStream();

            CloseLogsFile();
            CloseWritingBuffer();
        }
    }

    private void CloseWritingBuffer()
    {
        try
        {
            _writingBuffer.Dispose();
        }
        catch (Exception exception)
        {
#if DEBUG
            DebugEventLogger.Notify(exception, "Error while closing writing buffer");
#endif
        }
    }

    #region LogFiles

    private void CreateLogsDirectoryIfNotExists()
    {
        try
        {
	        if (Directory.Exists(_directoryPath))
	        {
		        return;
	        }

	        Directory.CreateDirectory(_directoryPath);
        }
        catch (Exception exception)
        {
#if DEBUG
            DebugEventLogger.Notify(exception, "Error while creating logs directory");
#endif
        }
    }

    private bool SyncLogs()
    {
        SyncLogsDate();

        return SyncLogsFile();
    }

    private void SyncLogsDate()
    {
        _logsDate = DateTime.Now.Date;
    }

    private bool IsLogsFileSplittingRequired()
    {
        try
        {
            return _logsStream!.Length >= FileSizeForArchiving;
        }
        catch (Exception exception)
        {
#if DEBUG
            DebugEventLogger.Notify(exception, "Error while checking logs file size");
#endif

            return false;
        }
    }

    private bool IsLogsDateChangingRequired(DateTime dateTime)
    {
        return _logsDate != dateTime.Date;
    }

    private bool SyncLogsFile(bool retry = true)
    {
	    CloseLogsFile();

        try
        {
            _logsStream = OpenFileStream(_logsDate);

            _isLogsStreamOpen = true;

            return true;
        }
        catch (Exception exception)
        {
#if DEBUG
            DebugEventLogger.Notify(exception, "Error while opening logs file");
#endif

            if (retry is false)
            {
                return false;
            }

            CreateLogsDirectoryIfNotExists();

            return SyncLogsFile(false);
        }
    }

    private void CloseLogsFile()
	{
        if (_isLogsStreamOpen is false)
        {
            return;
        }

        var logsStream = _logsStream;

        if (logsStream is null)
        {
            return;
        }

        try
        {
            logsStream.Flush(true);
        }
        catch (Exception exception)
        {
#if DEBUG
            DebugEventLogger.Notify(exception, "Error while flusinh logs file");
#endif
        }

        try
        {
	        logsStream.Dispose();
        }
        catch (Exception exception)
        {
#if DEBUG
	        DebugEventLogger.Notify(exception, "Error while closing logs file");
#endif
        }

        _isLogsStreamOpen = false;
	}

    private bool RemoveFile()
    {
        return RemoveFile(_logsStream!.Name);
    }

    private FileStream OpenFileStream(DateTime fileDate)
    {
        var filePath = BuildFilePath(fileDate);

        return new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.Read);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private string BuildFilePath(DateTime date)
    {
        var fileName = BuildFileName(date);

        return Path.Combine(_directoryPath, fileName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private string BuildFileName(DateTime date, int index)
    {
        return $"{_filePrefix}.{date.ToString(DateTimeFormat)}.{index}.log";
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private string BuildFileName(DateTime date)
    {
        return $"{_filePrefix}.{date.ToString(DateTimeFormat)}.log";
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private string BuildDumpLogFileName(string salt)
    {
        return $"{_filePrefix}.{salt}.dump.log";
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private string BuildFileName()
    {
        return $"{_filePrefix}.*.log";
    }

    #endregion

    #region ArchiveFiles

    private void MoveNextDateWithLogsArchivingOfPrevious()
    {
        if (TransferWritingBufferToLogsStream() is false)
        {
            return;
        }

        CloseLogsFile();

        if (ArchiveLogs(out var archivePath) is false)
        {
            SyncLogs();

            return;
        }

        if (RemoveFile() is false)
        {
            RemoveFile(archivePath);
        }

        SyncLogs();

        DeleteDeprecatedLogsArchives();
    }

    private void SplitLogsToArchive()
    {
        if (TransferWritingBufferToLogsStream() is false)
        {
            return;
        }

        CloseLogsFile();

        if (ArchiveLogs(out var archivePath) is false)
        {
            SyncLogsFile();

            return;
        }

        if (RemoveFile() is false)
        {
            RemoveFile(archivePath);
        }

        SyncLogsFile();
    }

    private bool ArchiveLogs(out string path)
    {
	    return ArchiveLogs(_logsStream!.Name, _logsDate, out path);
    }

    private bool ArchiveLogs(string name, DateTime date, out string path)
    {
        var nextArchiveIndex = GetLastArchiveIndex(date) + 1;

        path = BuildArchiveFilePath(date, nextArchiveIndex);

        try
        {
            using var archive = ZipFile.Open(path, ZipArchiveMode.Create, FileEncoding);

            archive.CreateEntryFromFile(name, BuildFileName(date, nextArchiveIndex), FileArchiveCompression);

            return true;
        }
        catch (Exception exception)
        {
#if DEBUG
            DebugEventLogger.Notify(exception, "Error while archiving logs");
#endif

            RemoveFile(path);

            return false;
        }
    }

    private bool ArchiveLogs(byte[] bytes, string folderPath, string archiveName, string fileName)
    {
        var archivePath = Path.Combine(folderPath, archiveName);

        try
        {
            using var archive = ZipFile.Open(archivePath, ZipArchiveMode.Create, FileEncoding);

            var entry = archive.CreateEntry(fileName, FileArchiveCompression);

            entry.LastWriteTime = DateTime.Now;

            using var entryStream = entry.Open();

            entryStream.Write(bytes, 0, bytes.Length);

            return true;
        }
        catch (Exception exception)
        {
#if DEBUG
            DebugEventLogger.Notify(exception, "Error while archiving logs");
#endif

            RemoveFile(archivePath);

            return false;
        }
    }

    private void ArchiveDeprecatedDaysLogs()
    {
        try
        {
            var files = Directory.EnumerateFiles(_directoryPath, BuildFileName());

            foreach (var context in files
                .Select(ParseFileDate)
                .Where(context => context != default)
                .Where(log => log.Date != _logsDate))
            {
                if (ArchiveLogs(context.Name, context.Date, out _) is false)
                {
                    continue;
                }

                RemoveFile(context.Name);
            }
        }
        catch (Exception exception)
        {
#if DEBUG
            DebugEventLogger.Notify(exception, "Error while archiving logs");
#endif
        }
    }

    private void DeleteDeprecatedLogsArchives()
    {
        try
        {
            var files = Directory.EnumerateFiles(_directoryPath, BuildArchiveFileName());

            var deprecatedDate = _logsDate.AddDays(-FileArchivesDeleteAfterDays);

            foreach (var context in files
                .Select(ParseFileDate)
                .Where(context => context != default)
                .Where(archive => archive.Date <= deprecatedDate))
            {
                try
                {
                    File.Delete(context.Name);
                }
                catch (Exception exception)
                {
#if DEBUG
                    DebugEventLogger.Notify(exception, "Error while deleting old archives");
#endif
                }
            }
        }
        catch (Exception exception)
        {
#if DEBUG
            DebugEventLogger.Notify(exception, "Error while deleting old archives");
#endif
        }
    }

    private void ArchiveWritingBuffer()
    {
        if (_writingBuffer.Length is 0)
        {
            return;
        }

        var logsBytes = _writingBuffer.GetBuffer();

        var salt = GenerateSalt();

        var archiveName = BuildDumpArchiveFileName(salt);
        var logsName = BuildDumpLogFileName(salt);

        if (ArchiveLogs(logsBytes, _directoryPath, archiveName, logsName) is false)
        {
            ArchiveLogs(logsBytes, ApplicationDirectory, archiveName, logsName);
        }

        ClearWritingBuffer();
    }

    private int GetLastArchiveIndex(DateTime date)
    {
        try
        {
            var lastIndex = Directory
                .EnumerateFiles(_directoryPath, BuildArchiveFileName(date))
                .Select(GetArchiveFileIndex)
                .Append(0)
                .Max();

            return lastIndex;
        }
        catch (Exception exception)
        {
#if DEBUG
            DebugEventLogger.Notify(exception, "Error while getting last archive index");
#endif

            return 0;
        }
    }

    private static int GetArchiveFileIndex(string filePath)
    {
        var filePathLength = filePath.Length;

        const string fileEnding = ".log.zip";

        var fileEndingLength = fileEnding.Length;

        if (filePathLength <= fileEndingLength)
        {
            return 0;
        }

        var lastDotIndex = filePath.LastIndexOf('.', filePathLength - fileEndingLength - 1);

        if (lastDotIndex < 0)
        {
            return 0;
        }

        var indexStart = lastDotIndex + 1;
        var indexLength = filePathLength - fileEndingLength - indexStart;

        return int.TryParse(filePath.AsSpan(indexStart, indexLength), out var index)
            ? index
            : 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private string BuildDumpArchiveFileName(string salt)
    {
        return $"{_filePrefix}.{salt}.dump.log.zip";
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private string BuildArchiveFileName()
    {
        return $"{_filePrefix}.*.log.zip";
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private string BuildArchiveFileName(DateTime date)
    {
        return $"{_filePrefix}.{date.ToString(DateTimeFormat)}.*.log.zip";
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private string BuildArchiveFileName(DateTime date, int index)
    {
        return $"{_filePrefix}.{date.ToString(DateTimeFormat)}.{index}.log.zip";
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private string BuildArchiveFilePath(DateTime date, int index)
    {
        return Path.Combine(_directoryPath, BuildArchiveFileName(date, index));
    }

    #endregion

    #region Buffers

    private void TransferLogToWritingBuffer(in LogContext logContext, ILogInterpolator logInterpolator)
    {
        try
        {
            _convertingBuffer.Clear();

            logInterpolator.Interpolate(logContext, _convertingBuffer);

            _convertingBuffer.Append(FileNewLine);

            CopyTo(_convertingBuffer, _writingBuffer, _encodingBuffer, FileEncoding);
        }
        catch (Exception exception)
        {
#if DEBUG
            DebugEventLogger.Notify(exception, "Error while writing to writing buffer");
#endif
        }
    }

    private bool TransferWritingBufferToLogsStream(bool retry = true)
    {
	    if (_writingBuffer.Length is 0)
	    {
		    return true;
	    }

        var success = false;

        try
        {
	        _logsStream!.Write(_writingBuffer.GetBuffer(), 0, (int)_writingBuffer.Length);

            success = true;
        }
        catch (Exception exception)
        {
#if DEBUG
            DebugEventLogger.Notify(exception, "Error while writing to file stream from writing buffer");
#endif

            if (retry && SyncLogsFile())
            {
                success = TransferWritingBufferToLogsStream(false);
            }
        }

        if (success)
        {
            ClearWritingBuffer();
        }
        else if (IsWritingBufferArchivingThresholdReached())
        {
            ArchiveWritingBuffer();
        }

        return success;
    }

    private void ClearWritingBuffer()
    {
        _writingBuffer.SetLength(0);

        _writingBuffer.Capacity = WritingBufferCapacity;

        _lastWritingBufferClearTime = DateTime.Now;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private bool IsWritingBufferWritingThresholdReached(DateTime logTime)
    {
        return _writingBufferInterval == TimeSpan.Zero
			|| _writingBuffer.Length >= WritingBufferCapacity
			|| _lastWritingBufferClearTime + _writingBufferInterval >= logTime;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private bool IsWritingBufferArchivingThresholdReached()
    {
        return _writingBuffer.Length >= FileSizeForArchiving;
    }

    #endregion

    private static (string Name, DateTime Date) ParseFileDate(string path)
    {
        var fileName = Path.GetFileName(path.AsSpan());

        var dateStartIndex = fileName.IndexOf('.') + 1;

        if (dateStartIndex <= 0 || dateStartIndex >= fileName.Length)
        {
            return default;
        }

        fileName = fileName[dateStartIndex..];

        var dateEndIndex = fileName.IndexOf('.');

        if (dateEndIndex <= 0)
        {
            return default;
        }

        fileName = fileName[..dateEndIndex];

        return DateTime.TryParseExact(fileName, DateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out var date)
            ? (path, date)
            : default;
    }

    private static bool RemoveFile(string name)
    {
        try
        {
            File.Delete(name);

            return true;
        }
        catch (Exception exception)
        {
#if DEBUG
            DebugEventLogger.Notify(exception, "Error while removing file");
#endif

            return false;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void ThrowIfFilePrefixContainsNotLetter()
    {
        if (_filePrefix.All(char.IsLetter) is false)
        {
            throw new ArgumentException("File prefix must contain at only letters", nameof(_filePrefix));
        }
    }

    private static void CopyTo(StringBuilder builder, MemoryStream stream, char[] buffer, Encoding encoding)
    {
        var builderLength = builder.Length;
        var bufferLength = buffer.Length;

	    var byteCount = encoding.GetMaxByteCount(builderLength);
	    var position = (int)stream.Position;

        var streamLength = position + byteCount;
	    stream.SetLength(position + byteCount);

	    for (var index = 0; index < builderLength; index += bufferLength)
	    {
		    var count = Math.Min(builderLength - index, bufferLength);

		    builder.CopyTo(index, buffer, 0, count);

		    byteCount = encoding.GetBytes(buffer, 0, count, stream.GetBuffer(), position);

		    position += byteCount;
	    }

	    stream.Position = position;

	    if (position != streamLength)
	    {
		    stream.SetLength(position);
	    }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string GenerateSalt()
    {
        return $"sa-{GenerateShortSalt()}-{GenerateShortSalt()}-lt";
    }

    private static string GenerateShortSalt()
    {
        var samples = new ReadOnlySpan<char>(SaltSamples);
        var samplesLength = samples.Length;

        var random = Random.Shared;

        var saltLength = random.Next(2, 5);
        Span<char> salt = stackalloc char[saltLength];

        for (var i = 0; i < saltLength; i++)
        {
            salt[i] = samples[random.Next(samplesLength)];
        }

        return new string(salt);
    }
}
