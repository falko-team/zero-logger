using System.Buffers;
using System.Runtime.CompilerServices;

namespace System.Logging.Builders;

public ref struct ValueStringBuilder : IDisposable
{
    private char[]? _debt;

    private Span<char> _buffer;

    private int _position;

    private int _capacity;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ValueStringBuilder(Span<char> buffer)
    {
        _buffer = buffer;
        _capacity = buffer.Length;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ValueStringBuilder(int capacity)
    {
        _debt = ArrayPool<char>.Shared.Rent(capacity);
        _buffer = _debt.AsSpan(0, capacity);
        _capacity = capacity;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Grow(int capacity)
    {
        if ((uint)capacity > (uint)_capacity)
        {
            var array = ArrayPool<char>.Shared.Rent(capacity);

            var arraySpan = array.AsSpan(0, capacity);

            _buffer[.._position].CopyTo(arraySpan);

            if (_debt is not null)
            {
                ArrayPool<char>.Shared.Return(_debt);
            }

            _debt = array;

            _buffer = arraySpan;
            _capacity = capacity;
        }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Append(scoped ReadOnlySpan<char> symbols)
    {
        var length = symbols.Length;

        if (length is 0) return;

        symbols.CopyTo(_buffer[_position..]);

        _position += length;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Append(char symbol)
    {
        _buffer[_position] = symbol;

        ++_position;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string Build()
    {
        return new string(_buffer[.._position]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override string ToString() => Build();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Dispose()
    {
        if (_debt is null) return;

        ArrayPool<char>.Shared.Return(_debt);
        _debt = null;
    }
}
