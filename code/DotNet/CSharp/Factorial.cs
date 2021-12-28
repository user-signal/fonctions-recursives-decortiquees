using System;

namespace CSharp
{
    public static class Factorial
    {
        public static uint Fact(uint n) => (n == 0u) ? 1u : n * Fact(n - 1);
        public static uint FactTailRecursive(uint n, uint acc) => (n == 0u) ? acc : FactTailRecursive(n - 1, n * acc);

        public interface ITailRec<out T>
        {
            public T Run()
            {
                var current = this;
                for (;;)
                    switch(current)
                    {
                        case Return<T> @return: return @return.Value;
                        case Suspend<T> suspend: current = suspend.Thunk(); break;
                    }
            } 
        }

        public struct Return<T> : ITailRec<T>
        {
            public T Value { get; init; }
        }

        public struct Suspend<T> : ITailRec<T>
        {
            public Func<ITailRec<T>> Thunk { get; init; }
        }

        public static ITailRec<uint> FactTrampoline(uint n, uint acc)
        {
            if (n == 0)
                return new Return<uint> { Value = acc };
            else
                return new Suspend<uint> { Thunk = () => FactTrampoline(n - 1, n * acc) };

        }
    }
}