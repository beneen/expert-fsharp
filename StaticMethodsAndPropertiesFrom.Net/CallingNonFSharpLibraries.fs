module CallingNonFSharpLibraries

// calling static method from non f# library

open System.IO
// test whether a file test.txt exists

if File.Exists("test.txt") then
    printfn "text file \"text.txt\" exists"
else
    printfn "text file \"text.txt\" does not exist"