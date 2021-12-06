package net.sigusr

import scala.annotation.tailrec;

object SnowCamp:

  def fact(n: Int): Int = 
    if (n == 0) 1 else n * fact(n - 1)

  @tailrec
  def factTail(n: Int, acc: Int): Int = 
    if (n == 0) acc else factTail(n - 1, n * acc)
