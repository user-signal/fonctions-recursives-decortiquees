package net.sigusr;

import java.util.function.Supplier;

public class SnowCamp {
    
    public static class Thunk<T> {
        private Thunk(T value, Supplier<Thunk<T>> thunk) {
            done = value != null;
            this.value = value;
            this.thunk = thunk;
        }

        public boolean done;
        public T value;
        public Supplier<Thunk<T>> thunk;

        public static <T> Thunk<T> done(T value) { return new Thunk<>(value, null); }
        public static <T> Thunk<T> call(Supplier<Thunk<T>> thunk) { return new Thunk<>(null, thunk); }
    }
    
    public static int fact(int n) {
        if (n == 0)
            return 1;
        else
            return n * fact(n - 1);
    }

    public static Thunk<Integer> factTramp(int n, int acc) {
        if (n == 0)
            return Thunk.done(acc);
        else
            return Thunk.call(() -> factTramp(n - 1, n * acc));
    }
    
    public static int factTail(int n, int acc) {
        if (n == 0)
            return acc;
        else
            return factTail(n - 1, n * acc);
    }
}
