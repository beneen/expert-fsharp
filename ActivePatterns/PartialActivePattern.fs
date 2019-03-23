module PartialActivePattern
open System.Text.RegularExpressions
open System

// use similar syntax to a complete active pattern 
// a partial active pattern has only one case name which is placed between banana brackets
// a partial active pattern must be followed by a vertical bar and an underscore to show it is partial (rather than a complete active pattern with one case)

// partial patterns are designed to wither match or fail to match, it is for this reason that they are option type
// the option type is a simple union type already built into f#, it has wto cases: Some and None and it has the following definition

//type option <'a> = 
//    |Some of 'a // A partial active pattern will return Some along with any data to be returned
//    | None // or None, which represents a failure


// reimplementing problem from CompleteActivePattern.fs using partial active patterns

// the definition of the active pattern
let (|Regex|_|) regexPattern input = 
    // create and attempt to match a regular expression
    let regex = new Regex(regexPattern)
    let regexMatch = regex.Match(input)
    // return either Some or None
    if regexMatch.Success then
        Some regexMatch.Value
    else
        None

// function to print the results by pattern matching over different instances of the active pattern

let printInputWithType input = 
    match input with 
    | Regex "$true|false^" s -> printfn "Boolean: %s" s
    | Regex @"$-?\d+^" s -> printfn "Integer: %s" s
    | Regex "$-?\d+\.\d*^" s -> printfn "Floating point: %s" s
    | _ -> printfn "String: %s" input

// print
printInputWithType "true"
printInputWithType "12"
printInputWithType "-12.1"
