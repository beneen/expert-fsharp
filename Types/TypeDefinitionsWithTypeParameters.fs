module TypeDefinitionsWithTypeParameters

// union and record types can be parameterised, this means leaving one or more of the types within the 
// type to be determined later by the consumer of the types

// f# supports two syntaxes for type parameterisation
// the first involves placing the type ebing patrameterised beterrn the keyword type and the name of type as follows 
// using a single type param, more can be added separating with ,

// ocaml syntax
type 'a BinaryTree = 
    | BinaryNode of 'a BinaryTree * 'a BinaryTree
    | BinaryValue of 'a

let tree1 = 
    BinaryNode(
        BinaryNode (BinaryValue 1, BinaryValue 2),
        BinaryNode (BinaryValue 3, BinaryValue 4))

// in the second syntax, you place the types being parameterised in angle brackets after the type name

// .net syntax
type Tree<'a> =
   | Node of Tree<'a> list
   | Value of 'a

let tree2 = 
    Node( [Node( [Value "one"; Value "two"]);
        Node([ Value "three"; Value "four"])])

// function to print binary tree
// the syntax for creating and consuming an instance of a parameterised type does not change from 
// creating and comsuming of non parameterised types

let rec printBinaryTreeValues x = 
    match x with
    | BinaryNode (node1, node2) ->
        printBinaryTreeValues node1
        printBinaryTreeValues node2
    | BinaryValue x ->
        printf "%A, " x

// funtion to print the tree

let rec printTreeValues x = 
    match x with
    | Node l -> List.iter printTreeValues l
    | Value x -> 
        printf "%A, " x

// print the results

printBinaryTreeValues tree1
printfn ""
printTreeValues tree2

