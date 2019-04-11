module DrawingShapes

open System
open System.Drawing
open System.Windows.Forms

// a shape record that will act as our object
type Shape = 
    { Reposition: Point -> unit
      Draw : Graphics -> unit}

// create a new instance of shape
let movingShape initPos draw = 
    // currpos is the internal state of the object
    let currPos = ref initPos in
    { Reposition = 
        // the reposition number updates in the internal state
        (fun newPos -> currPos := newPos);
      Draw = 
      // draw the shape passing the current position
      // adding graphics object to give a draw function
        (fun g -> draw ! currPos g);}

// create a new circle shape
let movingCircle initPos diam = 
    movingShape initPos (fun pos g -> g.DrawEllipse(Pens.Blue, pos.X, pos.Y, diam, diam))

// create new square
let movingSquare initPos diam = 
    movingShape initPos (fun pos g -> g.DrawRectangle(Pens.Blue, pos.X, pos.Y, diam, diam))

// list of shapes in their initial positions
let shapes = 
    [ movingCircle (new Point (10, 10)) 20;
      movingSquare (new Point (30, 30)) 20;
      movingCircle (new Point (20, 20)) 20
      movingCircle (new Point (40, 40)) 20]

// create the form to show the items
let mainForm = 
    let form = new Form ()
    let rand = new Random()
    // add event handler to draw shapes
    form.Paint.Add (fun e -> shapes |> List.iter (fun s -> s.Draw e.Graphics))
    // add event handler to move shapes when user clicks the form
    form.Click.Add(fun e -> shapes |> List.iter (fun s -> 
                        s.Reposition(new Point(rand.Next(form.Width),
                        rand.Next(form.Height)))
                        form.Invalidate()))
    form

do mainForm.ShowDialog() |> ignore