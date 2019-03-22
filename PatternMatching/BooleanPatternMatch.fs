module BooleanPatternMatch

// function for converting a Boolean to string

let booleanToString x = 
    match x with false -> "False" | _ -> "True"

// function for converting a stirng to Boolean

let stringToBoolean x =
    match x with
    | "True" | "true" -> true
    | "False" | "false" -> false
    | _ -> failwith "unexpected input"

printfn "(booleanToString true) = %s"
    (booleanToString true)

printfn "(booleanToString false) = %s"
(booleanToString false)