// For more information see https://aka.ms/fsharp-console-apps

open System

//Define a function to construct a message to print

let from = fun whom ->
    sprintf "from %s" whom
[<EntryPoint>]

let main argv =
    let message = from "F#"  // Call the function
    printfn "My World %s to Github CodeSpaces" message

    0 // return an integer exit code 
