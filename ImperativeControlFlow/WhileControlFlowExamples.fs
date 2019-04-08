module WhileControlFlowExamples

// a Matsuo Basho Haiku in a mutable list

let mutable matBas = ["An"; "old"; "pond!"; "A"; "frog"; "jumps"; "in-"; "The"; "sound"; "of"; "water"]

while (List.length matBas > 0) do
    printf "%s " (List.head matBas)
    matBas <- List.tail matBas