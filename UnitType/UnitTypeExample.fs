module UnitTypeExample

// this is a function that does not take or return a value
let aFunction() = 
    ()

// or
do aFunction()

// or
aFunction()

// if we hadnt put parentheses after aFunction then it would be a value rather than a function

let poem () = 
    printfn "abc"
    printfn "bca"
    printfn "cba"
poem()

// throwing away result of a function

let getShorty() = "shorty"
let _ = getShorty()

// or

ignore(getShorty())
// or

getShorty() |> ignore