package net.sigusr;

import org.junit.jupiter.api.Test;

import static net.sigusr.SnowCamp.fact;
import static net.sigusr.SnowCamp.factTail;
import static org.junit.jupiter.api.Assertions.*;

class SnowCampTest {

    @Test
    void factTest() {
        assertEquals(6, fact(3));
    }

    @Test
    void factTailTest() {
        assertEquals(6, factTail(3, 1));
    }
}