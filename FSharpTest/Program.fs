open System
open System.Linq.Expressions
open System.Diagnostics

type Quote<'T> = 
    static member X(exp:Expression<Func<'T,'a>>) = exp

type T = { x:int }

[<EntryPoint>]
let main argv = 
    for _ in [1..4] do
        let sw = Stopwatch.StartNew()
        [for i in [1..10000] -> Quote.X(fun x -> x.x = i)] |> ignore
        sw.Stop()
        printfn "Elapsed: %A" sw.Elapsed
    0 // return an integer exit code

