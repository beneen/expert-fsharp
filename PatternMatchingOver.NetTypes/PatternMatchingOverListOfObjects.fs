module PatternMatchingOverListOfObjects

// a list of objects
let simpleList = [box 1; box 2.0; box "three"]

// function that pattern matches over the type of the object it is passed
let recogniseType(item: obj) = 
    match item with
    | :? System.Int32 -> printfn "An integer"
    | :? System.Double -> printfn "A double"
    | :? System.String -> printfn "A string"
    | _ -> printfn "Unknown type"

// iterate over the list of objects
List.iter recogniseType simpleList