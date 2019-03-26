module MutableIdentifier

// a mutable identifier
let mutable phrase = "How can I be sure"

// print the phrase
printfn "%s" phrase
// update the phrase
phrase <- "In a world that is constantly changing"
// reprint the phrase
printfn "%s" phrase

// redefining value but not type

// this isnt allowed
//let mutable number = "one"
//phrase <- 1


