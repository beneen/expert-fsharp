module CompleteActivePatterns
open System

// similar syntax to defining a function.
// the point of this is to execute a function to see if a match has occured or not.
// design goal is to be able to permit better reuse of pattern matching logic.
// all active patterns take an input and then perform some computation with that input
// to determine whether a match has occured. there are two sorts:
// Complete active patterns allow you to rbeak the match down into a finite number of cases
// Partial active patterns can euther match or fail


// syntax similar to defining a function but the identifier that represents an active pattern is surrounded by banana brackets
// the names of the different cases of active pattern go between the banan brackets
// the body of the active pattern is just an F# function that returns each case of the active pattern in the given banana brackets
// each case may also return additional data, such as union types

// the following parses string input data

let (|Bool|Int|Float|String|) input = 
    // attempt to parse a bool
    let success, res = Boolean.TryParse input
    if success then Bool(res)
    else
        // attempt to parse an int
        let success, res = Int32.TryParse input
        if success then Int(res)
        else
            // attempt to parse a float (double)
            let success, res = Double.TryParse input 
            if success then Float(res)
            else String(input)

// function to print the results by pattern matching over the active pattern

let printInputWithType input = 
    match input with
    | Bool b -> printfn "Boolean: %b" b
    | Int i -> printfn "Integer: %i" i
    | Float f -> printfn " Floating point: %f" f
    | String s -> printfn "String: %s" s

// print the results
printInputWithType "true"
printInputWithType "12"
printInputWithType "-12.1"