module Irene.TranCash

(* It wasn't easy to decide what data types should be used for argument passing.
   I have finally decided to only use primitive data types, mostly Ids. 
   The whole object can be found by the id and then called within the function. 
   As a rule, only primitive data (e.g. ids, dates) can be passed to function. *)


open Irene.Mock

(*
let get_rate (rates:Rate list) date code =
    let rate = rates 
                |> List.find 
                (fun (r:Rate) -> r.Date = date && r.Code = code)
    rate.Percent
*)

let getDealsByDates startDate endDate =
    mockdeals
    |> List.filter (fun (d:Deal) -> d.TradeDate > startDate 
                                 || d.MatureDate < endDate)
    |> List.map (fun d -> d.Id)
            
let getLegIdsByDealIds dealIds =
    mocklegs
    |> List.filter (fun (l:Leg) -> List.contains l.DealId dealIds) 
    |> List.map (fun l -> l.Id)

let getRollById id = 
    List.find (fun (r:Roll) -> r.Id = id) mockrolls
    
let roll id =
    (* This function is the entry point of rolling order. 
       It only takes the rollId and do the rest of the jobs. *)
    let roll = getRollById id
    let dealIds = getDealsByDates roll.StartDate roll.EndDate
    let legIds = getLegIdsByDealIds dealIds
    legIds
    




(*


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

*)