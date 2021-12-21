package net.sigusr;

import org.junit.jupiter.api.Test;

import static net.sigusr.SnowCamp.*;
import static org.junit.jupiter.api.Assertions.*;

class SnowCampTest {

    public static void main(String[] args) {
        square(3);
    }

    @Test
    void squareTest() {
        assertEquals(9, square(3));
    }

    @Test
    void factTest() {
        assertEquals(6, fact(3));
    }

    @Test
    void factTailTest() {
        assertEquals(6, factTailRecursive(3, 1));
    }
    
    @Test
    void factTrampTest() {
        assertEquals(6, factTrampoline(3, 1).run());
    }
}