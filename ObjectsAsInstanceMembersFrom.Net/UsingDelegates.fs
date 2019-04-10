module UsingResizeArray
open System

// an integer list
let intList = 
    let temp = new ResizeArray<int>()
    temp.AddRange([|1;2;3|]);
    temp

// print
intList.ForEach(fun i -> Console.WriteLine(i))
