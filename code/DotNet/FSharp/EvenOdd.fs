module FSharp.EvenOdd

let rec IsEven =
    function
    | 0 -> true
    | n when n > 0 -> IsOdd(n - 1)
    | _ -> false

and IsOdd =
    function
    | 1 -> true
    | n when n > 1 -> IsEven(n - 1)
    | _ -> false

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

