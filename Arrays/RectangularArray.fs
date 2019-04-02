module RectangularArray

// create square array initally populated with zeros

let square = Array2D.create 2 2 0

// populate array
square.[0,0] <- 1
square.[0,1] <- 2
square.[1,0] <- 3
square.[1,1] <- 4

// print

printfn "%A" square


