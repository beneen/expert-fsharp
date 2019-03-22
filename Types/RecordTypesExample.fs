module RecordTypesExample

// define an organisation with unique fields

type Organisation1 = { boss: string; lackeys: string list}

// create isntance of this organisation

let rainbow = { boss = "Jeffrey"; lackeys = ["Zippy"; "George"; "Bungle"] }

// define two organisations with overlapping fields

type Organisation2 = { cheif : string; underlings : string list}
type Organisation3 = { cheif: string; indians: string list}

// create instance of organisation2 with type hint
let (thePlayers: Organisation2) = 
    { cheif = "Peter Quince";
        underlings = ["Francis Flute"; "Robin Starveling"; "Tom Snout"; "Snug"; "Nick Bottom"]}

// create an instance of Organisation3 with type hint
let (wayneManor: Organisation3) = 
    { cheif = "Batman";
        indians = ["Robin"; "Alfred"]}

// create a modified instance of this type - update using with
let wayneManor' = {wayneManor with indians = ["Alfred"]}

printfn "wayneManor = %A" wayneManor
printfn "wayneManor' = %A" wayneManor'


