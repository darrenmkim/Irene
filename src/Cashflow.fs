module Irene.Cashflow

/// Helper Functions

let stanceToEvent id = 
    match id with 
    | 1 -> 3
    | 2 -> 4
    | _ -> 0


// Processes 

let makeInterestPayments legId rollId =
    // Declarations
    let roll = getRollById rollId
    let leg = getLegById legId
    let deal = getDealById leg.DealId
    let freq = getFreqById leg.PaymentFreqId
    let rec walk bg en mn = 
        if bg >= en then []
        else 
            let newbg = (addMonths bg mn)
            let ip = 
                { Id = 0
                ; Pay = newbg
                ; LegId = legId
                ; EventId = stanceToEvent leg.StanceId
                ; Contracts = 1
                ; Start = bg
                ; End = newbg
                ; NumDays = mn * 30
                ; Rate = 2.5
                ; Amount = 100.8
                ; Annote = "asdf"
                ; RollId = rollId }
            ip :: walk newbg en mn
    // Proceed
    let ips = 
        walk deal.EffectDate deal.MatureDate freq.Months
    ips








(* 
let decideEvent step trade effect terminate mature legId =
    let leg = getLegById legId
    let stanceId = leg.StanceId
    let frequency = getFrequencyById leg.PaymentFreqId
    let months = frequency.Months
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
*)






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