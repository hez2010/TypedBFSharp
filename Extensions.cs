using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Brainfly;

static class SpanExtensions
{
    internal static ref T UnsafeAt<T>(this Span<T> span, int index)
    {
        return ref Unsafe.Add(ref MemoryMarshal.GetReference(span), index);
    }
}
