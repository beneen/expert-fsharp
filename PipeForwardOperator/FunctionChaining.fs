module FunctionChaining

// grabs list of all methods in memory - takes a few moments to run

let methods = System.AppDomain.CurrentDomain.GetAssemblies()
                |> List.ofArray
                |> List.map(fun assm -> assm.GetTypes())
                |> Array.concat
                |> List.ofArray
                |> List.map (fun t -> t.GetMethods())
                |> Array.concat

// print the list
printfn "%A" methods

