module FSharp.Factorial

let rec Fact = function
    | 0 -> 1
    | n -> n * Fact (n - 1)
    
let rec FactTailRecursive acc = function
    | 0 -> acc
    | n -> FactTailRecursive (n * acc) (n - 1)