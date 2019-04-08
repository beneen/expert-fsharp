module PassingAsParameters

open System.IO

// list of files to test
let files1 = ["test1.txt"; "test2.txt"; "test3.txt"]

// test of each file exists
let results1 = List.map File.Exists files1

// print the results
printfn "%A" results1


// .NET methods behave as if they take tupels as arguments therefore you can also treat a method that has more than one argument as a value

// list of files and desired contents
let files2 = [ "test1.bin", [| 0uy |];
               "test2.bin", [| 1uy |];
               "test3.bin", [| 1uy; 2uy |]]

// iterate over the list of files creating each one
List.iter File.WriteAllBytes files2

