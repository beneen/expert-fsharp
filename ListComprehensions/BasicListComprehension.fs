module BasicListComprehension


// create some list comprehensions

let numericList = [0 .. 9]
let alpherSeq = seq{'A' .. 'Z'}
let multiplesOfThree = [0 .. 3 .. 30]
let revNumericSeq = [9 .. -1 .. 0]

// print

printfn "%A" numericList
printfn "%A" alpherSeq
printfn "%A" multiplesOfThree
printfn "%A" revNumericSeq