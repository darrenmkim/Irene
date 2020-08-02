module Irene.TranCash

open System
open Irene.Mock


(*
let extract_rate rateRecord =
    rateRecord.Percentage

let findRateRecordFromRateRecords rateList date code =
    rateList
    |> List.find 
        (fun (item:RateRecord) -> 
            item.Date = date && 
            item.RateCodeId = code)

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


let rec cash_irs_fixed (deal:Deal) (leg:Leg) (roll:Roll) (pick:DateTime) = 
    if pick >= deal.Matured then []
    else 
        let notio = leg.Notional
        let rate = leg.Rate.Value
        let months = frequencies.Item(leg.Freq)
        let interest = notio * (rate / 100.0) * (float months / 12.0)
        let annote = sprintf "%.0f * (%.4f/100) * (%d/12) = %.2f" notio rate months interest
        let new_pick = pick.AddMonths(6)
        let tran = (make_tran (None) (pick) (leg) (Pay) (1) (interest) (annote) (roll))
        tran :: (cash_irs_fixed deal leg roll new_pick)

(*
let route_leg_cash (deal:Deal) (roll:Roll) = 
    for (leg:Leg) in deal.Legs do
        match leg.Kind with 
        | IrsFixed -> (cash_irs_fixed deal leg roll (DateTime(2020,3,1)))
        | IrsFloat -> (cash_irs_fixed deal leg roll (DateTime(2020,3,1)))
        | _ -> []
*)

let trial_mock = cash_irs_fixed mock_deal mock_leg_a mock_roll mock_sys_date