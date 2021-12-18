module FSharp.EvenOddTest

open FSharp.EvenOdd
open NFluent
open NUnit.Framework

[<TestCase(1, false)>]
[<TestCase(5, false)>]
[<TestCase(10, true)>]
let TestIsEven source expected =
    Check.That(IsEven source).IsEqualTo(expected)
    |> ignore

[<TestCase(1, true)>]
[<TestCase(5, true)>]
[<TestCase(10, false)>]
let TestIsOdd source expected =
    Check.That(IsOdd source).IsEqualTo(expected)
    |> ignore

let TestPeanoInput = [
    TestCaseData(Succ Zero, false)
    TestCaseData(Succ (Succ (Succ (Succ (Succ Zero)))), false)
    TestCaseData((Succ (Succ (Succ (Succ (Succ (Succ (Succ (Succ (Succ (Succ Zero)))))))))), true) 
]

[<TestCaseSource("TestPeanoInput")>]
let TestIsEvenPeano source expected =
    Check.That(IsEvenPeano source).IsEqualTo(expected)
    |> ignore

[<TestCaseSource("TestPeanoInput")>]
let TestIsOddPeano source expected =
    Check.That(IsOddPeano source).IsEqualTo(not expected)
    |> ignore
