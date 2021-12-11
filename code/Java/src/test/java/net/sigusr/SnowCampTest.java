package net.sigusr;

import org.junit.jupiter.api.Test;

import static net.sigusr.SnowCamp.*;
import static org.junit.jupiter.api.Assertions.*;

class SnowCampTest {

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