module ExampleTypeAlias

type Name = string
type FullName = string * string

let fullNameToString (x: FullName) = 
    let first, second = x in
    first + " " + second

