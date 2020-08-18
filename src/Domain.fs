[<AutoOpen>]
module Irene.Domain

type Id = int 
type Name = string
type Count = int
type NumVal = float
type Date = System.DateTime
type Time = System.DateTime
type Memo = string
type Active = bool 

type Preset = 
  { Id : Id
  ; Code : Name 
  ; Memo : Memo }

type Roll = 
  { Id : Id
  ; OrderId : Id
  ; OrderTime : Time
  ; StartDate : Date
  ; EndDate : Date }

type Leg = 
 { Id : Id
 ; Name : Name
 ; DealId : Id
 ; PactId : Id
 ; StanceId : Id
 ; BaseCurId : Id
 ; LocalCurId : Id
 ; PaymentFreqId : Id
 ; DayConvId : Id
 ; NotionalAmt : NumVal
 ; RateCodeId : Id
 ; RateGiven : NumVal option }

type Deal = 
  { Id : Id 
  ; Name : Name 
  ; BreedId : Id 
  ; TradeDate : Date
  ; EffectDate : Date 
  ; MatureDate : Date
  ; TerminateDate : Date option }

type Transaction = 
  { Id : Id
  ; Date : Date
  ; LegId : Id
  ; EventId : Id
  ; Contracts : Count
  ; Amount : NumVal
  ; Annote : Memo 
  ; RollId : Id }

type Account = 
  { Id : Id 
  ; Name : Name
  ; AccNum : Name
  ; Active : Active
  ; Memo : Memo }

type JournalPreset = 
  { Id : Id
  ; Name : Name
  ; PactId : Id 
  ; EventId : Id 
  ; AccountId : Id
  ; DirectionId : Id }

type JournalEntry = 
  { Id : Id
  ; AccountId : Id
  ; Amount : NumVal 
  ; RollId : Id }

type Rate = 
  { Id : Id
  ; Date : Date
  ; Code : Name
  ; Percent : NumVal }