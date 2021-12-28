module FSharp.Factorial

let rec Fact = function
    | 0u -> 1u
    | (n:uint) -> n * Fact (n - 1u)
    
let rec FactTailRecursive acc = function
    | 0u -> acc
    | (n:uint) -> FactTailRecursive (n * acc) (n - 1u)