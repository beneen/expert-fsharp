module LazyFibonacci

// create an infinite list of fibonacci numbers

let fibs = 
    Seq.unfold  
        (fun (n0, n1) ->
            Some(n0, (n1, n0 + n1)))
        (1I, 1I)
// take the first 20 items from the list

let first20 = Seq.take 20 fibs

// print the finite list
first20 |> Seq.iter (printf "%A ")