package net.sigusr

import org.scalatest.*
import org.scalatest.flatspec.AnyFlatSpec
import org.scalatest.matchers.should.Matchers

class SnowCampSpec extends AnyFlatSpec with Matchers {
  "The fact function" should "compute factorial of 3" in {
    SnowCamp.fact(3) shouldEqual 6
  }

  "The factTail function" should "compute factorial of 3" in {
    SnowCamp.factTailRecursive(3, 1) shouldEqual 6
  }
}
