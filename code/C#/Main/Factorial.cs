namespace Main
{
    public static class Factorial
    {
        public static int Fact(int n) => (n == 0) ? 1 : n * Fact(n - 1);
        public static int FactTail(int n, int acc) => (n == 0) ? acc : FactTail(n - 1, n * acc);
    }
}