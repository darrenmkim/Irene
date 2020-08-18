module Irene.TranCash

open System
open Irene.Mock

(*
let get_rate (rates:Rate list) date code =
    let rate = rates 
                |> List.find 
                (fun (r:Rate) -> r.Date = date && r.Code = code)
    rate.Percent

let rec cash_irs_fixed (deal:Deal) (leg:Leg) (roll:Roll) (pick:DateTime) = 
    if pick >= deal.Matured then []
    else 
        let kind = leg.Pact
        let rate = 
            match leg.Rate with 
            | Some(x) -> x
            | None -> (get_rate mock_rates pick LIBOR)
        let notio = leg.Notional
        let months = frequencies.Item(leg.Freq)
        let interest = notio * (rate / 100.0) * (float months / 12.0)
        let annote = sprintf "%.0f * (%.4f/100) * (%d/12) = %.2f" notio rate months interest
        let new_pick = pick.AddMonths(6)
        let journal : Journal = [
            //(make_entry None
        ]
        let tran : Tran = 
            (make_tran None pick leg Pay 1 interest annote roll journal)
        tran :: (cash_irs_fixed deal leg roll new_pick)

let trial_mock_a = cash_irs_fixed mock_deal mock_leg_a mock_roll mock_sys_date
// let trial_mock_b = cash_irs_fixed mock_deal mock_leg_b mock_roll mock_sys_date


*)