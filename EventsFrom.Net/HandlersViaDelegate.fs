module HandlersViaDelegate


open System.Timers

let timedMessagesViaDelegate() = 
    // define the timer
    let timer = new Timer(Interval = 3000.0, Enabled = true)

    // a counter to hold the current message
    let mutable messageNo = 0

    // the messages to be shown
    let messages = ["bet"; "this"; "gets"; "really"; "annoying"; "very"; "quickly"]

    // function to print message
    let printMessage = fun _ _ ->
        // print a message
        printfn "%s" messages.[messageNo]
        messageNo <- (messageNo + 1) % messages.Length

    // wrap the function in a delegate
    let del = new ElapsedEventHandler(printMessage)

    // add the delegate to the timer
    timer.Elapsed.AddHandler(del) |> ignore

    // remove time from the delegate so we can remove one from the other later
    (timer, del)

// run first
let timer, del = timedMessagesViaDelegate()

// run later
timer.Elapsed.RemoveHandler(del)