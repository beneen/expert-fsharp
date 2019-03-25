module LazyListDefinition


// the lazy lsit definition

let lazyList = 
    Seq.unfold
        (fun x ->
            if x < 13 then
                // if smaller than the limit return
                // the current and next value
                Some(x, x + 1 )
            else
                // if greater than the limit
                // terminate the sequence
                None)
        10
// print
printfn "%A" lazyList