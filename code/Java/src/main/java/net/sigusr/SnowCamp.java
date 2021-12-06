package net.sigusr;

public class SnowCamp {
    public static int fact(int n) {
        if (n == 0)
            return 1;
        else
            return n * fact(n - 1);
    }

    public static int factTail(int n, int acc) {
        if (n == 0)
            return acc;
        else
            return factTail(n - 1, n * acc);
    }
}
