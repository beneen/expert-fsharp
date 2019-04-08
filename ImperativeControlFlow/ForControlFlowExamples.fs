module ForControlFlowExamples

open System.Runtime.InteropServices

// using for to enumarate collections, this can be a useful way to work with typed and untyped collections returned by .NET BCL methods

// array of words
let words = [| "Red"; "Lorry"; "Yellow"; "Lorry"|]

// use a for loop to print each element
for word in words do
    printfn "%s" word

    
// other usage - decalre an identifier whose scope is the for loop that decreases/increases its value by a specified amount after each iteration of the loop. 

// a Ryunoskue Akutagawa haiku array (incrementing up using to keyword)
let ryuAku = [|"Green"; "frog"; "is"; "your"; "body"; "also"; "freshly"; "painted?"|]

// for loop over the array printing each element
for index = 0 to Array.length ryuAku - 1 do
    printf "%s " ryuAku.[index]


// a shuson kato haiku array (backwards)
let shuKat = [| "watching."; "been"; "have"; "children"; "three"; "my"; "realise"; "and"; "ant"; "an"; "kill"; "I"|]

// loop over backwards
for index = Array.length shuKat - 1 downto 0 do
    printf "%s " shuKat.[index]

// using range notation

// count upwards
for i in 0..10 do
    printfn "%i green bottles" i

// count downwards
for i in 10 .. -1 .. 0 do
    printfn "%i green bottles" i 

// count upwards in tens
for i in 0 .. 10 .. 100 do
   printfn "%i green bottles" i 
