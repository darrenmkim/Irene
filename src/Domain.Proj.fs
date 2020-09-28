module Irene.Domain.Proj

open Irene.Domain.Deal

type Proj = 
  { Id : Id option 
  ; Date : Date 
  ; DealId : Id option 
  ; LegId : Id option 
  ; Event : Event
  ; Notional : Currency 
  ; Amount : Currency
  ; Actual : Actual
  }

let makeContractProj (d : Deal) (legId : Id) : Proj list =
  let l = d.Leg.[legId]
  match d.Breed with 
  | Breed.IRS -> 
         [ { Id = None 
           ; Date = d.TradeDate
           ; DealId = d.Id
           ; LegId = d.Id
           ; Event = Event.Contract
           ; Notional = l.Notional 
           ; Amount = l.Notional 
           ; Actual = true 
           } ]
  | Breed.Nothing -> []

let makeEffectProj (d : Deal) (legId : Id) : Proj list =
  match d.Breed with 
  | Breed.IRS -> []
  | Breed.Nothing -> [] 

let makeInterestProjs (d : Deal) (legId : Id) : Proj list =
  let l = d.Leg.[legId]
  match d.Breed with 
  | Breed.IRS -> 
         [ { Id = None 
           ; Date = Date(2020, 2, 2)
           ; DealId = d.Id
           ; LegId = d.Id
           ; Event = Event.Interest
           ; Notional = l.Notional 
           ; Amount = l.Notional 
           ; Actual = true 
           } ]
  | Breed.Nothing -> [] 

let makeTerminateProj (d : Deal) (legId : Id) : Proj list =
  match d.Breed with 
  | Breed.IRS -> []
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