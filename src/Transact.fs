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


//let projectFinalCashflow (leg:Leg) (cutoff:DateTime) =
//    match leg.StanceId with 
 
let rec projectInterimCashflows 
    (leg:Leg) 
    (start:DateTime) 
    (ending:DateTime)
    (cutoff:DateTime) 
    (numMonths:int) 
    = 
    if start > ending then []
    else 
        let newStart = start.AddMonths(numMonths)
        let actId = 
            match leg.StanceId with 
            | 1 | 3 -> 4
            | 2 | 4 -> 3
            | _ -> 1
        let t : Tran = { 
            Id = 0 ; 
            Date = newStart ; 
            LegId = leg.Id ; 
            ActId = actId ; 
            NumContracts = 1 ; 
            Amount = 333.10 }
        t :: projectInterimCashflows leg newStart ending cutoff numMonths


let transactCashflows (leg:Leg) = 
    let drvtype = "irs"
    match drvtype with 
    | "ftr" -> 33
    | "irs" -> 11
    | _ -> 99