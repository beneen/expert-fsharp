module NotUsingDelegates

open System

// how to wrap a method that takes a delegate with an F# function

// here we are importing the findindex method from system array class so that we can use it in a curried style

let findIndex f arr = Array.FindIndex(arr, new Predicate<_>(f))

// if we had not specifically created a delgate then the identifier f would have represented a predicate delegate rather than a function. 
// this means calls to findIndex would need to create delegate objects explicitly. 
// using the underscore means we avoid having to speficy a type while keeping it flexible

// define array literal
let rhyme = [|"The"; "cat"; "sat"; "on"; "the"; "mat"|]

// print the index of the first word ending in "at"

printfn "First word ending in 'at' in the array: %i"
    (rhyme |> findIndex (fun w -> w.EndsWith("at")))
