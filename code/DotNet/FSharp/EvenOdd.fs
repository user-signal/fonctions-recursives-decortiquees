module FSharp.EvenOdd

let rec IsEven =
    function
    | 0u -> true
    | (n: uint) -> IsOdd(n - 1u)

and IsOdd =
    function
    | 1u -> true
    | (n: uint) -> IsEven(n - 1u)

type Peano =
    | Zero
    | Succ of Peano

let rec IsEvenPeano =
    function
    | Zero -> true
    | Succ n -> IsOddPeano n

and IsOddPeano =
    function
    | Zero -> false
    | Succ n -> IsEvenPeano n
