module UnitsOfMeasure

// units of measure are an addition to the f# type system and allow classification of numeric values into different units

// defining a unit of measure

[<Measure>]type m

// creating a value with a unit

let meters = 1.0<m>


[<Measure>]type liter
[<Measure>]type pint

let vol1 = 2.5<liter>
let vol2 = 2.5<pint>

// the program doesnt compile when let newVol = vol1 + vol2

// addition or subtraction of different units is not allowed
// multiplication and division is allowed and will create a new unit of measure

let ratio = 1.0<liter> / 1.76056338<pint>

// function to convert pints to liters
let convertPintToLiter pints = 
    pints * ratio

// perform the conversion and add the values
let newVol = vol1 + (convertPintToLiter vol2)

printfn "The volume is %f" vol1