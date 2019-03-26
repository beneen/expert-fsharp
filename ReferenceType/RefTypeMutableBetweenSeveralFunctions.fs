module RefTypeMutableBetweenSeveralFunctions

// capture inc dec and show functions

let inc, dec, show = 
    // define the shared state
    let n = ref 0
    // a function to increment
    let inc () =
        n := !n + 1
    // a function to decrement
    let dec () =
        n := !n - 1
    // a function to show the current state
    let show () = 
        printfn "%i" !n

    // return the functions to the top level
    inc, dec, show

// test
inc()
inc()
dec()
show()

// from 4.0 onwards

let inc2, dec2, show2 = 
    // define the shared state
    let mutable n =  0
    // a function to increment
    let inc2 () =
        n <- n + 1
    // a function to decrement
    let dec2 () =
        n <- n - 1
    // a function to show the current state
    let show2 () = 
        printfn "%i" n

    // return the functions to the top level
    inc2, dec2, show2

// test
inc2()
inc2()
dec2()
show2()



