module App

open Fable.Core

// The "interface" approach

// Interface used to "define" the JavaScript global `window` object.
type Window =
    // We are only interested in the `alert` function. The return type and argument type are "defined" by the
    // JavaScript documentation of the `alert` function.
    abstract alert: ?message: string -> unit
    
// Wire-up JavaScript and F# with `[<Global>]` attribute and `jsNative`.
let [<Global>] window: Window = jsNative

// Actual client calls
window.alert ("Global Fable window.alert")  // with parentheses
window.alert "Global Fable window.alert sans parentheses"
