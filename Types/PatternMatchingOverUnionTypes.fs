module PatternMatchingOverUnionTypes

// to deconstruct the values of union types into their basic parts you alwyas use pattern matching.
// when pattern matching over a union type, the constructors make up the first half of the pattern matching rules.
// you don't need a complete list of rules, but if the list is incomplete there must be a default rule using
// either an identifier or a wildcard to match all remaining rules

// the first part of of a rule for a constructor consists of the constructor name followed by identifiers or 
// wildcards to match the various values within it

//type representing volumes
type Volume = 
    | Liter of float
    | UsPint of float
    | ImperialPint of float

// various kinds of volumes
let vol1 = Liter 2.5
let vol2 = UsPint 2.5
let vol3 = ImperialPint 2.5

// some functions to convert between volumes
let convertVolumeToLiter x = 
    match x with
    | Liter x -> x
    | UsPint x -> x * 0.473
    | ImperialPint x -> x * 0.568

let convertVolumeUSPint x = 
    match x with
    | Liter x -> x * 2.113
    | UsPint x -> x
    | ImperialPint x -> x * 1.201

let convertVolumeImperialPint x = 
    match x with
    | Liter x -> x * 1.760
    | UsPint x -> x * 0.833
    | ImperialPint x -> x

// a funciton to print a volume

let printVolumes x = 
    printfn "Volume in liters = %f,
    in us pints = %f,
    in imperial pints = %f"
        (convertVolumeToLiter x)
        (convertVolumeUSPint x )
        (convertVolumeImperialPint x)

 //print
printVolumes vol1
printVolumes vol2
printVolumes vol3

