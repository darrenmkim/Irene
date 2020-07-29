module Irene.TranCash
open System
open Mock

//let projectFinalCashflow (leg:Leg) (cutoff:DateTime) =
//    match leg.StanceId with 
 
(*
let rec projectInterimCashflows 
    (deal:Deal)
    (leg:Leg) 
    (cutoff:DateTime) 
    = 
    let start = deal.EffectiveDate
    let ending = deal.MatureDate
    let freqmonths = leg.PayFreqId
    if start > ending then []
    else
        //let monthsOfGap = (List.filter (fun l -> l.Id = 43 ) payfreqs).NumMonths
        let newStart = start.AddMonths(freqmonths)
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
        t :: projectInterimCashflows deal  newStart ending cutoff numMonths
*)


// initial

let transactInitialCashflow (leg:Leg) =
    // leg.DealId
    32


// transactInterimCashflows
// transactFinalCashflows