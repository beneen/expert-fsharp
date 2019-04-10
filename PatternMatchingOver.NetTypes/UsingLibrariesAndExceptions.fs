module UsingLibrariesAndExceptions

try
    // look at the current time and raise an exception based on whether the second is a multiple of three
    if System.DateTime.Now.Second % 3 = 0 then
        raise(new System.Exception())
    else
        raise (new System.ApplicationException())
with
| :? System.ApplicationException ->
    // this will handle the application exception case
    printfn "A second that was not a multiple of three"
| _ ->
    // this will handle all other exceptions
    printfn "A second that was a multiple of three"