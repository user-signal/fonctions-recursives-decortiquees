package net.sigusr;

import java.util.Arrays;
import java.util.function.Function;

public class Test {
    public static void main(String[] args) {
        String[] strings = Arrays.stream(args).map(Toto.apply(true)).toArray(String[]::new);
        System.out.println(Arrays.toString(strings));
    }
    
    public static Function<Boolean, Function<String, String>> Toto = zorg -> zorg ? String::toUpperCase : String::toLowerCase;
}
