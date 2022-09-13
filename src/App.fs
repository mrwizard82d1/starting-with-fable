module App

open Fable.Core

// The `Emit` attribute alternative to interfaces

// Use the `Emit` attribute: a special attribute for mapping between F# and JavaScript. The "expression,"
// `$0`, is the argument that can be supplied to `window.alert`.
[<Emit("window.alert($0)")>]
let alert (message: string): unit = jsNative

// Use parenthesized arguments
alert ("Emit from Fable window.alert")

// No parentheses
alert "Emit from Fable window.alert sans parentheses"

// F# pipeline style
"Emit from window.alert with F# style" |> alert
