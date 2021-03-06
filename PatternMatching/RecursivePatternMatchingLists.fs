﻿module RecursivePatternMatchingLists

// pattern matching syntax for pulling the head off a list
// list to be concatenated

let listOfList= [[2; 3; 5]; [7; 11; 13]; [17; 19; 23; 29]]

// definition of a concat function

let rec concatList l =
    match l with
    | head :: tail -> head @ (concatList tail)
    | [] -> [] 

// call function

let primes = concatList listOfList

//print

printfn "%A" primes