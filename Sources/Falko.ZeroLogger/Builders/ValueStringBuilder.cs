using System.Buffers;
using System.Runtime.CompilerServices;

namespace System.Logging.Builders;

public ref struct ValueStringBuilder : IDisposable
{
    private readonly char[]? _debt;

    private readonly Span<char> _buffer;

    private int _position;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ValueStringBuilder(Span<char> buffer)
    {
        _buffer = buffer;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ValueStringBuilder(int capacity)
    {
        _debt = ArrayPool<char>.Shared.Rent(capacity);
        _buffer = _debt.AsSpan(0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Append(scoped ReadOnlySpan<char> symbols)
    {
        var length = symbols.Length;

        if (length is 0) return;

        symbols.CopyTo(_buffer[_position..]);

        _position += length;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Append(string symbols)
    {
        var length = symbols.Length;

        if (length is 0) return;

        symbols.CopyTo(_buffer[_position..]);

        _position += length;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Append(char symbol)
    {
        _buffer[_position] = symbol;

        ++_position;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override string ToString() => new(_buffer[.._position]);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Dispose()
    {
        if (_debt is null) return;

        ArrayPool<char>.Shared.Return(_debt);
    }
}
