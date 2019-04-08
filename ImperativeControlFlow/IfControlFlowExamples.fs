module ControlFlowExamples

// using the if expression in the imperative style (using it with a function that returns a type unit) means we are not forced to use an else

if System.DateTime.Now.DayOfWeek = System.DayOfWeek.Sunday then
    printfn "Sunday Playlist: Lazy on a Sunday Afternoon - Queen"

// although it isnt necessary to have the else expression (must also be of type unit)

if System.DateTime.Now.DayOfWeek = System.DayOfWeek.Monday then
    printfn "Monday Playlist: Blue Monday - New Order"
else
    printfn "Alt Playlist: Fell In Love With A Girl - White Stripes"

//using whitespace to detect where an if expression ends
if System.DateTime.Now.DayOfWeek = System.DayOfWeek.Tuesday then
    printfn "Tuesday Playlist: Ruby Tuesday - Rolling Stones"
printfn "Everyday Playlist: Eight Days A Week - Beatles"

if System.DateTime.Now.DayOfWeek = System.DayOfWeek.Friday then
    printfn "Friday Playlist: Friday I'm In Love - The Cure"
    printfn "Friday Playlist: View From The Afternoon - Arctiv Monkeys"

