module DrawingShapes

open System.Drawing

// a shape record that will act as our object

type Shape = 
    { Reposition: Point -> unit;
      Draw: unit -> unit}

// create a new instance of shape

let makeShape initPos draw =
    // currPos is the internal state of the object
    let currPos = ref initPos
    { Reposition = 
        // the reposition member updates the internal state
        (fun newPos -> currPos := newPos);
      Draw = 
        // draw the shape passing the current position to given draw function
        (fun () -> draw !currPos);}

// draws a shape and prints out the name and position of the shape
let draw shape (pos: Point) = 
    printfn "%s, with x = %i and y = %i"
        shape pos.X pos.Y

// creates a new circle shape
let circle initPos = 
    makeShape initPos (draw "Circle")

// creates new square
let square initPos = 
    makeShape initPos (draw "Square")

// list of shapes in their initial positions

let shapes = 
    [ circle (new Point (10,10));
      square (new Point (30,30))]

// draw all the shapes
let drawShapes() = 
    shapes |> List.iter (fun s -> s.Draw())

let main() = 
    drawShapes() // draw shapes
    // move all the shapes
    shapes |> List.iter (fun s -> s.Reposition (new Point (40, 40)))
    drawShapes()

do main()