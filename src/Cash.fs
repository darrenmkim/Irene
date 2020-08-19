module Irene.TranCash

(* It wasn't easy to decide what data types should be used for argument passing.
   I have finally decided to only use primitive data types, mostly Ids. 
   The whole object can be found by the id and then called within the function. 
   As a rule, only primitive data (e.g. ids, dates) can be passed to function. *)

open Irene.Mock

let getDealsByDates startDate endDate =
    mockdeals
    |> lfilt (fun (d:Deal) 
                -> d.TradeDate > startDate 
                || d.MatureDate < endDate)
    |> lmap (fun d -> d.Id)

let getDealById id = 
    lfind (fun (d:Deal) -> d.Id = id) mockdeals
    
let getLegById id =
    lfind (fun (l:Leg) -> l.Id = id) mocklegs

let getLegIdsByDealIds dealIds =
    mocklegs
    |> lfilt (fun (l:Leg) -> lcont l.DealId dealIds) 
    |> lmap (fun l -> l.Id)

let getRollById id = 
    lfind (fun (r:Roll) -> r.Id = id) mockrolls
    
let rec makeInterims start ending months = 
    let newStart = addMonths start months
    start :: makeInterims newStart ending months 

let decideEvent step trade effect terminate mature legId =
    let leg = getLegById legId
    let stanceId = leg.StanceId
    let frequencyId = leg.PaymentFreqId
    let series = 
        lsort [ step ; trade ; effect ; terminate ; mature ]
    let locate = findIndex series step
    let interims = makeInterims trade mature 3
    let eventIdDate = 
        match locate with 
        | 0 -> (1, trade)
        | 1 -> (2, effect)
        | 2 -> 
            match stanceId with
            | 1 -> (3, step)
            | 2 -> (4, step)
            | _ -> (0, step)
        | 3 -> (1, step)
        | 4 -> (1, step)
        | _ -> (0, step)
    eventIdDate

let makeTran legId rollId step =
    let roll = getRollById rollId
    let rollStart = roll.StartDate
    let rollEnd = roll.EndDate
    let leg = getLegById legId
    let stanceId = leg.StanceId
    let legNotional = leg.NotionalAmt
    let dealId = leg.DealId
    let deal = getDealById dealId
    let tradeDt = deal.TradeDate
    let effectDt = deal.EffectDate
    let matureDt = deal.MatureDate
    let terminateDt = deal.TerminateDate
    let eventId =
        decideEvent step tradeDt effectDt matureDt terminateDt stanceId
    let tran = 
        { Id = 0
        ; Date = step
        ; LegId = legId
        ; EventId = 99 // TO BE UPDATED
        ; Contracts = 1
        ; Amount = legNotional
        ; Annote = "asdf"
        ; RollId = rollId }
    tran 











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