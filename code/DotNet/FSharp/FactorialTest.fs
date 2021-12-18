module FSharp.FactorialTest

open FSharp.Factorial
open NFluent
open NUnit.Framework

[<Test>]
let FactTest () = Check.That(Fact 3).IsEqualTo(6) |> ignore

[<Test>]
let FactTailRecursiveTest () = Check.That(FactTailRecursive 1 3).IsEqualTo(6) |> ignore
