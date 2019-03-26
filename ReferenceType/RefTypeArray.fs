module RefTypeArray
 // ref types 

let phrase = ref "Inconsistency"

let totalArray () = 
    // define an array literal
    let array = [| 1; 2; 3|]
    // define a counter
    let total = ref 0
    for x in array do
        // keep running total
        total := !total + x
    // print the total
    printfn "total: %i" !total

totalArray()