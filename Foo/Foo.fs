namespace Foo

open System

module Foo = 
    let RemoveExclamationMarks (a : string) = a.Replace("!","")
    let ToAcronim (s : string) = 

        let extractFirstCharacter (s : string) = Char.ToUpper s.[0]

        s.Split [|' '|]
        |> Array.map extractFirstCharacter
        |> System.String

    let AlternateCase =
            let convertCase = function
                | s when Char.IsUpper s -> Char.ToLower s
                | s when Char.IsLower s -> Char.ToUpper s
                | s -> s

            String.map convertCase