module SimpleLazyEvaluation

let lazyValue = lazy (2 + 2)
let actualValue = Lazy.force lazyValue

printfn "%i" actualValue

let lazySideEffect = 
    lazy
        (let temp = 2 + 2
         printfn "%i" temp
         temp)

printfn "Force the value the first time: "
let actualValue1 = Lazy.force lazySideEffect
printfn "Force Value second time: "
let actualValue 2 = Lazy.force lazySideEffect




