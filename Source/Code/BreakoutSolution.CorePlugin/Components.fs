﻿namespace BreakoutSolution.FSharp

open Duality
open System
open Duality.Components.Renderers
open Optionalbe

[<Serializable>]
type ScoreComponent() = 
    inherit Component()

    let mutable score =0
    member this.Score = score
    
    member this.IncreaseScore amount =
        score <- score + amount        
    

    interface ICmpUpdatable with 
        member this.OnUpdate() = 
            let tr = OptionComponent<TextRenderer> this.GameObj
            match tr with
            | None -> ()
            | Some tr ->tr.Text.SourceText <- sprintf "Score: %i"  score
             (* second iteration
            match this.GameObj.GetComponent<TextRenderer>() with
            | null -> ()
            | tr -> tr.Text.SourceText <- sprintf "Score: %i"  score
            *)
            
            (* first iteration
            if (this.GameObj.GetComponent<TextRenderer>() <> null) then
                this.GameObj.GetComponent<TextRenderer>().Text.SourceText <- sprintf "Score: %i"  score
                *)
[<Serializable>]
type LifeMeter() = 
    inherit Component()     
    member val Lives  = 0 with get, set      
    
    interface ICmpUpdatable with 
        member this.OnUpdate() =
            match this.GameObj.GetComponent<TextRenderer>() with
            | null -> ()
            | tr -> tr.Text.SourceText <- sprintf "Lifes: %i"  this.Lives

            
