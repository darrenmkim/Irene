module Irene.Domain.Proj

open Irene.Domain.Deal


(*
let makeContractProj (d : Deal) (legId : Id) : Proj list =
  let l = d.Leg.[legId]
  match d.Breed with 
  | IRS -> 
         [{ Id = None 
          ; Date = d.TradeDate
          ; DealId = d.Id
          ; LegId = d.Id
          ; Event = Event.Contract
          ; PeriodStart = None 
          ; PeriodEnd = None
          ; DaysInPeriod = None
          ; RateQuote = None
          ; Notional = l.Notional 
          ; Amount = l.Notional 
          ; Actual = true 
          } ]
  | Breed.Nothing -> []

let makeEffectProj (d : Deal) (legId : Id) : Proj list =
  match d.Breed with 
  | IRS -> []
  | Breed.Nothing -> [] 

let rec makeInterestProjsIrs 
  (d : Deal) (legId : Id) (periodFirstDay : Date) : Proj list =
  let l = d.Leg.[legId]
  let spanInMonths = (getMonthsBySpan l.Span)
  let periodLastDay = addMonths periodFirstDay spanInMonths
  if periodLastDay >= d.MatureDate then []
  else 
        let quote = Some (Quote.Libor1Y 0.025)
        let interestAmount = 
          getCurrencyTypeFromValue ((fst (getCurrencyValueFromType l.Notional)), 
                                    (snd (getCurrencyValueFromType l.Notional)) * 
                                    (snd (getQuoteValueFromType quote.Value)) * 
                                    ((float spanInMonths) / 12.0))
        [{ Id = None 
        ; Date = Date(2020, 2, 2)
        ; DealId = d.Id
        ; LegId = d.Id
        ; Event = Event.Interest
        ; PeriodStart = Some periodFirstDay 
        ; PeriodEnd = Some periodLastDay
        ; DaysInPeriod = Some ((periodLastDay - periodFirstDay).Days)
        ; RateQuote = quote
        ; Notional = l.Notional 
        ; Amount = interestAmount
        ; Actual = true 
        }] @ makeInterestProjsIrs d legId periodLastDay

let makeInterestProjs (d : Deal) (legId : Id) : Proj list =
  let l = d.Leg.[legId]
  match d.Breed with 
  | IRS -> makeInterestProjsIrs d legId d.EffectDate
  | Breed.Nothing -> [] 

let makeTerminateProj (d : Deal) (legId : Id) : Proj list =
  match d.Breed with 
  | IRS -> []
  | Breed.Nothing -> [] 

let makeProjsForLeg (d : Deal) (legId : Id) : Proj list =
  let contractProj = makeContractProj d legId
  let effectProj = makeEffectProj d legId
  let interestProj  = makeInterestProjs d legId
  let terminateProj  = makeTerminateProj d legId
  contractProj @ effectProj @ interestProj @ terminateProj

let makeProjsForDeal (d : Deal) : Proj list = 
  let legIds = lmap (fun (l:Leg) -> (l.Id).Value) d.Leg
  let count = legIds.Length
  let rec combineProjs d legIndex = 
    if legIndex >= count then []
    else makeProjsForLeg d legIndex @ combineProjs d (legIndex + 1)
  combineProjs d 0

let testproj = makeProjsForDeal sampleDeal
*)