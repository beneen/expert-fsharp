module FromCollectionToCollection

// a sequence of squares
let squares = 
    seq { for x in 1 .. 10 -> x * x }
// print
printfn "%A" squares
