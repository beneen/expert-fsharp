module RaisingExceptionsFinally

// finally cannot be used with with in f#
// finally expression is excecuted whether or not an exception is thrown

// function to write to a file

let writeToFile() = 
    // open a file
    let file = System.IO.File.CreateText("test.txt")
    try
        // write to it
        file.WriteLine("Hello F# users")
    finally
        // close the file, this will happen even if an exception occurs writing to the file
        file.Dispose()
// call the function

writeToFile()

