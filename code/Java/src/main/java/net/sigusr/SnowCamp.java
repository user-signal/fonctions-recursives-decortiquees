package net.sigusr;

import java.util.function.Supplier;

public class SnowCamp {

    static int square(int num) {
        return num * num;
    }

    public static int fact(int n) {
        if (n == 0)
            return 1;
        else
            return n * fact(n - 1);
    }

    public static int factTailRecursive(int n, int acc) {
        if (n == 0)
            return acc;
        else
            return factTailRecursive(n - 1, n * acc);
    }

    public sealed interface TailRec<T> permits Suspend, Return {
        default T run() {
            var current = this;
            do {
                switch (current) {
                    case Return r: return (T) r.value;
                    case Suspend s: current = (TailRec<T>) s.thunk.get();
                }
            } while (true);
        }
    }
    public record Return<T>(T value) implements TailRec<T> {}
    public record Suspend<T>(Supplier<TailRec<T>> thunk) implements TailRec<T> {}

    public static TailRec<Integer> factTrampoline(int n, int acc) {
        if (n == 0)
            return new Return<>(acc);
        else
            return new Suspend<>(() -> factTrampoline(n - 1, n * acc));
    }
}
