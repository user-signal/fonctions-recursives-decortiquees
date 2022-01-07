using System;

namespace CSharp;

public static class Curry
{
    public static void MainCurry(string[] args)
    {
        var add42 = AddCurried(42);
        add42(19);
    }
    
    public static int Add(int x, int y) => x + y;
    public static Func<int, int> AddCurried(int x) => y => x + y;
}