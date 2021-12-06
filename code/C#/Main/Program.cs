using System;
using System.Net.Sockets;

namespace Main
{
    class Program
    {
        public static int Add(int x, int y) => x + y;
        public static Func<int, int> AddCurry(int x) => y => x + y;
        static void Main(string[] args)
        {
            Console.WriteLine($"Add uncurried : {Add(42, 19)}");
            Console.WriteLine($"Add curried   : {AddCurry(42)(19)}");
            var addPartial = AddCurry(42);
            Console.WriteLine($"Add curried   : {addPartial}");
            Console.WriteLine($"Add curried   : {addPartial(19)}");
        }
    }
}