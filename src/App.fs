module App

open Fable.Core

// Calling `Math.random`

// `Emit` attribute example

// Again, the casing must match
[<Emit("Math.random()")>]
let random (): float = jsNative

JS.console.log (random ())
