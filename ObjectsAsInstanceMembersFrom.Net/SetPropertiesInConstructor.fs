module SetPropertiesInConstructor

open System.IO

// filename to test
let filename = "test.txt"

// bind file to an option type, depensing on whether the file exists or not
let file = 
    if File.Exists(filename) then // we need to test for the files existence to avoid a runtime exception 
        Some(new FileInfo(filename, Attributes = FileAttributes.ReadOnly))
    else
        None