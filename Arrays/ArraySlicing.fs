module ArraySlicing

let arr = [|1; 3; 5; 7; 11; 13|]
let middle = arr.[1..4] // [|3; 5; 7; 11|]

let start = arr.[..3] // [|1; 3; 5; 7;|]
let tail = arr.[1..] // [|3; 5; 7; 11; 13|]

// slicing multidimensional arrays
let ocean = Array2D.create 100 100 0
// create a ship
for i in 3..6 do
    ocean.[i, 5] <- 1
// pull out an area hit by a shell
let hitArea = ocean.[2..5, 2..5]
// to include all elements in one of the dimensions use a *

// we can see a rectangular area by 'radar'

let radarArea = ocean.[3..4, *]

// from 4.0 onwards the same slicing syntax can also be applied to lists