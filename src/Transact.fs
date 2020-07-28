module Irene.Transact
open System

(*
let transactCashflowsIrsFix (leg : Leg) =
    let s = DateTime(2019,10,15)
    let e = DateTime(2029,10,15)
    seq { for x in s .. e then yield x }

let cylinderVolume radius length =
    // Define a local value pi.
    let pi = 3.14159
    length * pi * radius * radius

*)

let transactCashflows (leg : Leg) = 
    let drvtype = "irs"
    match drvtype with 
    | "ftr" -> 33
    | "irs" -> 11
    | _ -> 99