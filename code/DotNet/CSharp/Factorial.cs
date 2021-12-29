using System;

namespace CSharp
{
    public static class Factorial
    {
        public static uint Fact(uint n) => n switch
        {
            0u => 1u,
            _ => n * Fact(n - 1)
        };

        public static uint FactTailRecursive(uint acc, uint n) => n switch
        {
            0u => acc,
            _ => FactTailRecursive(n * acc, n - 1)
        };

        public interface ITailRec<out T> {
            public T Run() {
                var current = this;
                for (;;)
                    switch (current) {
                        case Return<T> @return: return @return.Value;
                        case Suspend<T> suspend:
                            current = suspend.Thunk();
                            break;
                    }
            }
        }

        public struct Return<T> : ITailRec<T> {
            public T Value { get; init; }
        }

        public struct Suspend<T> : ITailRec<T> {
            public Func<ITailRec<T>> Thunk { get; init; }
        }

        public static ITailRec<uint> FactTrampoline(uint acc, uint n) {
            if (n == 0)
                return new Return<uint> { Value = acc };
            else
                return new Suspend<uint> { Thunk = () => FactTrampoline(n * acc, n - 1) };
        }
    }
}