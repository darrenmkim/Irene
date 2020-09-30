module Irene.Domain.Deal

open Dapper.FSharp
open Dapper.FSharp.PostgreSQL

// Leg


(*
type LegDb = 
  { Id : Id option 
  ; Name : Name  
  ; DealId : Id option
  ; Pact : Name
  ; Stance : Name
  ; Period : Count  
  ; Span : Name
  ; Day : Name
  ; ContractNum : Count 
  ; Notional : (Name * Money)
  ; FixedQuote : (Name * Rate) option
  ; MovingQuote : (Name * Rate) option
  ; Memo : string option }

let legSchema = 
  "create table if not exists " +
  "Leg (" +
  "Id serial primary key, " +
  "Name text not null, " + 
  "Pact text not null, " +  
  "Stance text not null, " +
  "Period text not null, " +
  "Span text not null, " +
  "Day text not null, " +
  "ContractNum int not null, " +
  "Notional int not null, " +
  "FixedQuote int not null, " +
  "MovingQuote int not null, " +
  "Memo text) " 


type DealDb = 
  { Id : Id option 
  ; Name : Name 
  ; Breed : Name
  ; Strategy : Name
  ; TradeDate : Date
  ; EffectDate : Date
  ; MatureDate : Date
  ; TerminateDate : Date option
  ; Memo : Memo option }
*)
(*
let makeDbRecordFromLeg (l : Leg) : LegDb =
  let legDb : LegDb = 
    { Id = l.Id
    ; Name = l.Name
    ; DealId = l.Id
    ; Pact = getPactValueFromType l.Pact
    ; Stance = getStanceValueFromType l.Stance
    ; Period = l.Period
    ; Span = getSpanValueFromType l.Span
    ; Day = getDayValueFromType l.Day
    ; ContractNum = l.ContractNum
    ; Notional = getCurrencyValueFromType l.Notional
    ; FixedQuote = None
    ; MovingQuote = None
    ; Memo = l.Memo }
  legDb

let makeDbRecordFromDeal (d : Deal) : (DealDb * LegDb list) =
  let dealDb : DealDb = 
    { Id = d.Id
    ; Name = d.Name
    ; Breed = getBreedValueFromType d.Breed
    ; Strategy = getStrategyValueFromType d.Strategy
    ; TradeDate = d.TradeDate
    ; EffectDate = d.EffectDate
    ; MatureDate = d.MatureDate
    ; TerminateDate = d.TerminateDate
    ; Memo = d.Memo }
  let legDbs : LegDb list = 
    lmap makeDbRecordFromLeg d.Leg
  dealDb, legDbs

*)


////////////////

let sampleDeal : Deal = 
  { Id = 1u
  ; Name = "sampleDeal"
  ; Breed = Breed.IRS
  ; Strategy = Strategy.FVHIRS
  ; TradeDate = Date(2011, 1, 1)
  ; EffectDate = Date(2011, 1, 3)
  ; MatureDate = Date(2020, 1, 3)
  ; TerminateDate = Date(2020, 1, 3)
  ; Leg = [{ Id = 1u
            ; Name = "my leg 1"
            ; Pact = Pact.IRSFIX
            ; Stance = Stance.Pay
            ; Period = 10us
            ; Span = Span.Annual
            ; Day = Day.D30360
            ; ContractNum = 1uy
            ; Notional = { Currency = Currency.EUR 
                         ; Number = 1000000.0 }
            ; FixedQuote = { Ticker = Ticker.Libor1Y
                           ; Number = 0.023 }
            ; MovingTicker = Ticker.None 
            ; Memo = "my memo" } ; 
            { Id = 2u
            ; Name = "my leg 2"
            ; Pact = Pact.IRSFLT
            ; Stance = Stance.Receive
            ; Period = 10us
            ; Span = Span.Annual
            ; Day = Day.D30360
            ; ContractNum = 1uy
            ; Notional = { Currency = Currency.EUR 
                         ; Number = 1000000.0 }
            ; FixedQuote = { Ticker = Ticker.Euribor1Y 
                           ; Number = 0.023 }
            ; MovingTicker = Ticker.None
            ; Memo = "my memo" }]
  ; Active = true
  ; Memo = "abc"}