module FSharp.FactorialTest

open FSharp.Factorial
open NFluent
open NUnit.Framework

[<Test>]
let FactTest () = Check.That(Fact 3u).IsEqualTo(6) |> ignore

[<Test>]
let FactTailRecursiveTest () = Check.That(FactTailRecursive 1u 3u).IsEqualTo(6) |> ignore
