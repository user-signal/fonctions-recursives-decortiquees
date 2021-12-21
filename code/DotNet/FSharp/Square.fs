module FSharp.Square

open NFluent
open NUnit.Framework

let square x = x * x

[<TestCase(1, 1)>]
[<TestCase(5, 25)>]
[<TestCase(10, 100)>]
let TestSquare (source:int) expected =
    Check.That(square source).IsEqualTo(expected) |> ignore