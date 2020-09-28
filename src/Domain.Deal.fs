module Irene.Domain.Deal

open Dapper.FSharp
open Dapper.FSharp.PostgreSQL

// Leg

type Leg = 
  { Id : Id option 
  ; Name : Name 
  ; Pact : Pact
  ; Stance : Stance
  ; Period : Count 
  ; Span : Span
  ; Day : Day
  ; ContractNum : Count 
  ; Notional : Currency
  ; FixedQuote : Quote option 
  ; MovingQuote : Quote option 
  ; Memo : Memo option }

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

type Deal = 
  { Id : Id option 
  ; Name : Name 
  ; Breed : Breed
  ; Strategy : Strategy
  ; TradeDate : Date
  ; EffectDate : Date
  ; MatureDate : Date
  ; TerminateDate : Date option
  ; Leg : Leg list
  ; Active : Active
  ; Memo : Memo option }

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




////////////////

let sampleDeal : Deal = 
  { Id = Some 1
  ; Name = "sampleDeal"
  ; Breed = Breed.IRS
  ; Strategy = Strategy.FVHIRS
  ; TradeDate = Date(2020, 1, 1)
  ; EffectDate = Date(2020, 1, 1)
  ; MatureDate = Date(2020, 1, 1)
  ; TerminateDate = Some(Date(2020, 1, 1))
  ; Leg = [{ Id = Some 1
            ; Name = "my leg"
            ; Pact = Pact.IRSFIX
            ; Stance = Stance.Pay
            ; Period = 10
            ; Span = Span.Annual
            ; Day = Day.D30360
            ; ContractNum = 1
            ; Notional = Currency.EUR 1000000.0
            ; FixedQuote = Some (Quote.Euribor1Y 0.023)
            ; MovingQuote = None 
            ; Memo = Some "my memo" } ; 
            { Id = Some 1
            ; Name = "my leg"
            ; Pact = Pact.IRSFLT
            ; Stance = Stance.Receive
            ; Period = 10
            ; Span = Span.Annual
            ; Day = Day.D30360
            ; ContractNum = 1
            ; Notional = Currency.EUR 1000000.0
            ; FixedQuote = Some (Quote.Euribor1Y 0.023)
            ; MovingQuote = None 
            ; Memo = Some "my memo" }]
  ; Active = true
  ; Memo = Some "abc"}

let testDealDb = makeDbRecordFromDeal sampleDeal