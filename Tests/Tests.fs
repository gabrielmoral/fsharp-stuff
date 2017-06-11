module Tests

open NUnit.Framework
open FsUnit
open Foo

[<Test>]
let ``Remove exclamation marks`` () =
    Foo.RemoveExclamationMarks "Hello World!" |> should equal "Hello World"
    Foo.RemoveExclamationMarks "Hello Universe!" |> should equal "Hello Universe"

[<Test>]
let ``acronim`` () =
    Foo.ToAcronim "Code Wars"  |> should equal "CW"
    Foo.ToAcronim "Water Closet"  |> should equal "WC"
    Foo.ToAcronim "Portable Network Graphics" |> should equal "PNG"  
    Foo.ToAcronim "PHP: Hypertext Preprocessor"  |> should equal "PHP"
    Foo.ToAcronim "hyper text markup language" |> should equal "HTML" 

            
