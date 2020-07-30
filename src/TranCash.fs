module Irene.TranCash

open System
open Irene.Mock

// transactInterestPayments
let rec tranIrsFixedInterestPayments 
    (notional:float) 
    (months:int) 
    (rate:float) 
    (mature:DateTime) 
    (start:DateTime) =
    if (start >= mature) then []
    else
        let interest = notional * (rate / 100.0) * (float months / 12.0)
        let formula = sprintf "%.0f * (%.4f/100) * (%d/12) = %.2f" notional rate months interest
        let newStart = start.AddMonths(months)
        (newStart, interest, formula) :: 
        tranIrsFixedInterestPayments 
            notional 
            months 
            rate 
            mature 
            newStart

let extractRateFromRateRecord rateRecord =
    rateRecord.Percentage

let findRateRecordFromRateRecords rateList date code =
    rateList
    |> List.find 
        (fun (item:RateRecord) -> 
            item.Date = date && 
            item.RateCodeId = code)

let rec tranIrsFloatInterestPayments 
    (notional:float) 
    (months:int) 
    (mature:DateTime) 
    (start:DateTime) =
    if (start >= mature) then []
    else
        let rate = 
            findRateRecordFromRateRecords mockRates start 1 
            |> extractRateFromRateRecord 
        let interest = notional * (rate / 100.0) * (float months / 12.0)
        let formula = sprintf "%.0f * (%.4f/100) * (%d/12) = %.2f" notional rate months interest
        let newStart = start.AddMonths(months)
        (newStart, interest, formula) :: 
        tranIrsFloatInterestPayments 
            notional 
            months 
            mature 
            newStart

let testFixed = 
    tranIrsFixedInterestPayments 
        1000000.0 
        6 
        2.0 
        (DateTime(2025,1,3)) 
        (DateTime(2020,1,3)) 

let testFloat = 
    tranIrsFloatInterestPayments 
        1000000.0 
        6 
        (DateTime(2025,1,3)) 
        (DateTime(2020,1,3)) 