module App

open Fable.Core

// Manually created p5.js interface
// See [Starting with Fable](https://itnext.io/starting-with-fable-f-83846ab790ad) for alternatives for
// generating the interop code.

[<StringEnum>]
type Renderer =
    | [<CompiledName("p2d")>] P2D
    | [<CompiledName("webgl")>] WebGL
    
type [<Import("*", "p5/lib/p5.js")>] p5(?sketch: p5 -> unit, ?id: string) =
    member __.setup with set(v: unit -> unit): unit = jsNative
    member __.draw with set(v: unit -> unit): unit = jsNative
    member __.createCanvas(w: float, h: float, ?renderer: Renderer): unit = jsNative
    member __.background(value: int): unit = jsNative
    member __.millis(): float = jsNative
    member __.rotateX(angle: float): unit = jsNative
    member __.box(): unit = jsNative
    
// Client code
let sketch (it: p5) =
    it.setup <- fun() -> it.createCanvas(300., 300., WebGL)
    it.draw <- fun () ->
        it.background(255)
        it.rotateX(it.millis() / 1000.)
        it.box()

// draw
p5(sketch) |> ignore
