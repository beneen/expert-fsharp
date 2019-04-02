module ArrayComprehension

// an array of characters
let chars = [| '1' .. '9'|]

// an array pf tuples of number, square
let squares = 
    [| for x in 1 .. 9 -> x * x|]

// print
printfn "%A" chars
printfn "%A" squares
