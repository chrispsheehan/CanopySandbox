// Learn more about F# at http://fsharp.org

open CanopyFunctions
open canopy.classic

[<EntryPoint>]
let main argv =


    startDriver()

    printfn "Running..."
    
    url "https://www.bbc.co.uk/"

    click "Sport"

    click "Rugby Union"

    quitDriver()

    printfn "finished"

    0 // return an integer exit code
