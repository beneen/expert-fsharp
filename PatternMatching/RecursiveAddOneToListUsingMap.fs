module RecursiveAddOneToListUsingMap


let rec map func list = 
    match list with
    | head :: rest ->
        func head :: map func rest
    | [] -> []

let result = List.map ((+) 1) [1; 2; 3]

printfn "List.map ((+) 1) [1; 2; 3] = %A" result 