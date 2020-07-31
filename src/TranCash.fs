module Irene.TranCash

open System
open Irene.Mock

let extractRateFromRateRecord rateRecord =
    rateRecord.Percentage

let findRateRecordFromRateRecords rateList date code =
    rateList
    |> List.find 
        (fun (item:RateRecord) -> 
            item.Date = date && 
            item.RateCodeId = code)

// transactInterestPayments
let rec tranIrsFixedInterestPayments 
    (roll:RollOrder) (deal:Deal) (leg:Leg) (start:DateTime) =
    if (start >= deal.MatureDate) then []
    else
        let numOfMonths = PayFreqVal.Item(leg.PayFreq)
        let interest = 
            leg.Notional * (leg.FixedRate.Value / 100.0) * (float numOfMonths / 12.0)
        let formula : string = 
            sprintf "%.0f * (%.4f/100) * (%d/12) = %.2f" 
                leg.Notional leg.FixedRate.Value numOfMonths interest
        let newStart = start.AddMonths(numOfMonths)
        let tran : Tran = {
            Id = None ; 
            Date = start ; 
            Leg = leg ; 
            Event = Pay ; 
            NumContracts = 1 ; 
            Amount = interest ; 
            Annotation = formula ;
            RollOrder =  roll }
        tran :: tranIrsFixedInterestPayments roll deal leg newStart

(*
let rec tranIrsFloatInterestPayments 
    (deal:Deal) (leg:Leg) (start:DateTime) =
    if (start >= deal.MatureDate) then []
    else
        let numOfMonths = PayFreqVal.Item(leg.PayFreq)
        let interest = 
            leg.Notional * (leg.FixedRate.Value / 100.0) * (float numOfMonths / 12.0)
        let formula = 
            sprintf "%.0f * (%.4f/100) * (%d/12) = %.2f" 
                leg.Notional leg.FixedRate.Value numOfMonths interest
        let newStart = start.AddMonths(numOfMonths)
        let tran : Tran = {
            Id = None ; 
            Date = start ; 
            Leg = leg ; 
            Event = Pay ; 
            NumContracts = 1 ; 
            Amount = interest ;
            Annotation = formula }
        tran :: tranIrsFixedInterestPayments deal leg newStart
*)

let routeLegsToProcess 
    (roll:RollOrder) (deal:Deal) (leg:Leg option) (systemDate:DateTime)
    = 
    match leg with 
    | None -> []
    | Some leg -> 
        match leg.LegType with 
        | IrsFixed -> tranIrsFixedInterestPayments roll deal leg systemDate
        | IrsFloat -> tranIrsFixedInterestPayments roll deal leg systemDate

let transactInterimPaymentsGate 
    (roll:RollOrder) (deal:Deal) (systemDate:DateTime)
    =
    routeLegsToProcess roll deal deal.LegReceive systemDate

let testerdeal = { 
    Id = Some 4 ;
    Name = "IRS01" ;
    DealType = IRS ;
    LegPay =  Some irs01floatlet ; 
    LegReceive = Some irs01fixleg ; 
    TradeDate = DateTime(2020,1,1) ;
    EffectiveDate = DateTime(2020,1,3) ;
    MatureDate = DateTime(2025,1,3) ;
    TerminateDate = None }

let testing2 = 
    routeLegsToProcess 
        roll1 testerdeal (Some irs01fixleg) (DateTime(2020,3,1))

let testing = 
    transactInterimPaymentsGate 
        roll1 testerdeal (DateTime(2020,3,1))