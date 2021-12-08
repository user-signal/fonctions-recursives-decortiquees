using System;

namespace Main
{
    public class Curry
    {
        public static int Add(int x, int y) => x + y;
        public static Func<int, int> AddCurry(int x) => y => x + y;
    }
}