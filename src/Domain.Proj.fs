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

let makeContractProj (d : Deal) (l : Leg) : Proj list =
  match d.Breed with 
  | Breed.IRS -> []
  | Breed.Nothing -> []

let makeEffectProj (d : Deal) (l : Leg) : Proj list =
  match d.Breed with 
  | Breed.IRS -> []
  | Breed.Nothing -> [] 

let makeInterestProjs (d : Deal) (l : Leg) : Proj list =
  match d.Breed with 
  | Breed.IRS -> 
         [ { Id = None 
           ; Date = Date(2020, 2, 2)
           ; DealId = d.Id
           ; LegId = l.Id
           ; Event = Event.Interest
           ; Notional = l.Notional 
           ; Amount = l.Notional 
           ; Actual = true 
           } ]
  | Breed.Nothing -> [] 

let makeTerminateProj (d : Deal) (l : Leg) : Proj list =
  match d.Breed with 
  | Breed.IRS -> []
  | Breed.Nothing -> [] 

let makeProjsForLeg (d : Deal) (l : Leg) : Proj list =
  let contractProj = makeContractProj d l
  let effectProj = makeEffectProj d l
  let interestProj  = makeInterestProjs d l
  let terminateProj  = makeTerminateProj d l
  contractProj @ effectProj @ interestProj @ terminateProj



(*
let makeProjsForDeal (d : Deal) : Proj list = 
  let rec combine () : Proj list = 
    if 
  
  lmap (makeProjsForLeg d) d.Leg

let testproj = makeProjsForDeal sampleDeal

*)