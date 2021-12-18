using System;

namespace CSharp
{
    public class Curry
    {
        public static int Add(int x, int y) => x + y;
        public static Func<int, int> AddCurried(int x) => y => x + y;
    }
}