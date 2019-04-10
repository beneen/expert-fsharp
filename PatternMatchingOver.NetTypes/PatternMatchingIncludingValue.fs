module PatternMatchingIncludingValue

// a list of objects
let anotherList = [box "one"; box 2; box 3.0]

// function that pattern matches over the type of the object it is passed, must be of type obj when using .net libraries (need to tell f# this)
let recogniseAndPrintType(item: obj) = 
    match item with
    | :? System.Int32 as x -> printfn "An integer %i" x
    | :? System.Double as x -> printfn "A double %f" x
    | :? System.String as x -> printfn "A string %s" x
    | x -> printfn "An object %A" x

// iterate over the list of objects pattern matching each item
List.iter recogniseAndPrintType anotherList