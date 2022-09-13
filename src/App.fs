module App

open Fable.Core

// Calling `Math.random`

// Interface example

// Define an "interface"
type Math =
    abstract random: unit -> float
    
// Identify the "class" as native JavaScript. Remember that the name, in this case, `Math`, must have the
// **same** case as the native JavaScript name.
let [<Global>] Math: Math = jsNative

// Make the call
JS.console.log (Math.random ())

