module CurryingNetMethods

// import the .net method function by writing a thin f# wrapper

open System.IO

// import the File.Create function
let create size name = 
    File.Create(name, size, FileOptions.Encrypted)

// list of files to be created
let names = ["test1.bin"; "test2.bin"; "test3.bin"]

// open the files create a list of streams
let streams = List.map (create 1024) names

// open a file using named arguments
let file = File.Open(path = "test.txt", mode = FileMode.Append, access = FileAccess.Write, share = FileShare.None)

// close it

file.Close()
