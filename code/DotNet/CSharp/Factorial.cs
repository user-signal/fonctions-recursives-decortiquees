namespace CSharp
{
    public static class Factorial
    {
        public static int Fact(int n) => (n == 0) ? 1 : n * Fact(n - 1);
        public static int FactTailRecursive(int n, int acc) => (n == 0) ? acc : FactTailRecursive(n - 1, n * acc);
    }
}