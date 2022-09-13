module App

open Fable.Core

// Define interfaces to the DOM. These interfaces are actually available from `Fable.Browser.Dom`. We do it
// manually for "experience". (This experience allows us to see and do what needs to be done to interact with
// native JavaScript.)

// A DOM node
type Node =
    abstract appendChild: child: Node -> Node
    abstract insertBefore: node: Node * ?child: Node -> Node
    
// The browser document
type Document =
    abstract createElement: tagName: string -> Node
    abstract createTextNode: text: string -> Node
    abstract getElementById: elementId: string -> Node
    abstract body: Node with get, set
    
// Define `document` as the native JavaScript `document`
let [<Global>] document: Document = jsNative

// Client code

// Create a new `div` Node attached to the document (but not in the node tree)
let newDiv = document.createElement("div")

// Insert a text node into the newly created `div`
"Good news everyone! Generated dynamically by Fable!"
|> document.createTextNode
|> newDiv.appendChild
|> ignore

// Insert the newly created node (and its child text node) into the node tree
let currentDiv = document.getElementById("app")
document.body.insertBefore (newDiv, currentDiv) |> ignore
