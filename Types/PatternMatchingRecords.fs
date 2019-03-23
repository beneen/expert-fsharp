module PatternMatchingRecords

// type representing a couple
type Couple = { him : string ; her : string }

// list of couples
let couples = 
    [ { him = "brad"; her = "angelina"};
      { him = "becks" ; her = "posh" };
      { him = "chris" ; her = "gwyneth"};
      { him = "michael" ; her = "catherine" } ]

// function to find david from a list of couples
let rec findDavid l = 
    match l with
    | { him = x ; her = "posh"} :: tail -> x
    | _ :: tail -> findDavid tail
    | [] -> failwith "couldn't find david"

let rec findPartner soughtHer l = 
    match l with
    | { him = x; her = her } :: tail when her = soughtHer -> x
    | _ :: tail -> findPartner soughtHer tail
    | [] -> failwith "couldnt find him"

// print
printfn "%A" (findDavid couples)
printfn "%A" (findPartner "posh" couples)
