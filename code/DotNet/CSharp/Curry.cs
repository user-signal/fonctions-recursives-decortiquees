using System;

namespace CSharp;

public static class Curry
{
    public static void MainCurry(string[] args)
    {
        var add42 = AddCurried(42);
        var add19 = AddCurried(19);
        
        var resA = add42(13);
        var resB = add19(13);
    }
    
    public static int Add(int x, int y) => x + y;
    public static Func<int, int> AddCurried(int x) => y => x + y;
}