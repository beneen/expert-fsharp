module UnionSumTypes

// a union type is a way of bringing together data that may have a different meaning or structure.
// it is defined the same way as a type but with constructors that follow the | syntax.
// constructors are composed of names that must start with a capital letter which is intended to 
// avoid the common bug of getting constructor names mixed up with identifier names.
// the name can optionally be followed by the keyword of  and then the types that make up the constructor 
// (multiple types are separated by asterisks)
// names must be unique within a type

type Volume = 
    | Liter of float
    | UsPint of float
    | ImperialPint of float

let vol1 = Liter 2.5
let vol2 = UsPint 2.5
let vol3 = ImperialPint 2.5

// providing names for type fields
// union type using field labels

type Shape = 
    | Square of side:float
    | Rectangle of width:float * height: float
    | Circle of radius:float

// create an instance of union type without using field label
let sq = Square 1.2

// create an instance of union type using the field label
let sq2 = Square(side = 1.2)

// create an instance of a union type using multiple field labels
// and assigning the field out-of-order
let rect3 = Rectangle(height=3.4, width=1.2)
