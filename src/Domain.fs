[<AutoOpen>]

module Irene.Domain

type Id = int 
type Name = string
type Code = string
type Count = int
type MoneyVal = float
type RateVal = float
type PercentVal = float
type Date = System.DateTime
type Time = System.DateTime
type Memo = string
type Active = bool 

type Preset = 
  { Id : Id
  ; Code : Code 
  ; Memo : Memo }

type Person = 
  { Id : Id
  ; Username : Name 
  ; Password : Code
  ; Email : Code 
  ; NickName : Name
  ; OpenDate : Date }

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
 ; NotionalAmt : MoneyVal
 ; RateCodeId : Id
 ; RateGiven : RateVal option }

type Deal = 
  { Id : Id 
  ; Name : Name 
  ; BreedId : Id 
  ; TradeDate : Date
  ; EffectDate : Date
  ; TerminateDate : Date 
  ; MatureDate : Date }

type Transaction = 
  { Id : Id
  ; Date : Date
  ; LegId : Id
  ; EventId : Id
  ; Contracts : Count
  ; Amount : MoneyVal
  ; Annote : Memo 
  ; RollId : Id }

type Account = 
  { Id : Id 
  ; Name : Name
  ; AccNum : Name
  ; Active : Active
  ; Memo : Memo }

type JournalTemplate = 
  { Id : Id
  ; Name : Name
  ; PactId : Id 
  ; EventId : Id 
  ; AccountId : Id
  ; DirectionId : Id }

type JournalEntry = 
  { Id : Id
  ; AccountId : Id
  ; Amount : MoneyVal 
  ; RollId : Id }

type Rate = 
  { Id : Id
  ; Date : Date
  ; Code : Id
  ; Percent : PercentVal }