[<AutoOpen>]

module Irene.Domain

type Id = int 
type Name = string
type Memo = string
type Count = int
type Money = float
type Rate = float
type Percent = float
type Date = System.DateTime
type Time = System.DateTime
 

type Ability = 
  | Admin 
  | Approver 
  | Preparer 
  | Viewer

type Stance = 
  | Pay 
  | Receive
  | Buy
  | Sell 

type Span = 
  | Continuous
  | Month
  | Quarter 
  | Semiannual
  | Annual
  | Biannual
  | None

type Status =
  | Posted
  | Drafted
  | Deleted
  | Activated
  | Deactivated 
  
type DayConv = 
  | C30360
  | AC360

type Quote =
  | Fixed 
  | Libor1D of Rate  
  | Libor1W of Rate  
  | Libor2W of Rate   
  | Libor1M of Rate    
  | Libor2M of Rate  
  | Libor3M of Rate   
  | Libor6M of Rate   
  | Libor1Y of Rate   
  | Euribor1W of Rate   
  | Euribor2W of Rate   
  | Euribor1M of Rate   
  | Euribor2M of Rate   
  | Euribor3M of Rate   
  | Euribor6M of Rate  
  | Euribor9M of Rate   
  | Euribor1Y of Rate   

(*
CREATE TYPE rate AS (
    code text,
    value numeric);
*)


type Leg = 
  | IRSFIX of name : Name 
  | IRSFLT 
  | CRSFIX 
  | CRSFLT 

let myleg = Leg.IRSFIX(name = "abc")
let otherleg = Leg.IRSFIX "abc"






type Deal = 
  | IRS of name : Name * legs : Leg list 
  | CRS of name : Name * legs : Leg list 
  | FTR of name : Name * numContract : Count * legs : Leg list 
  //| CAL of name : Name option * legs : Leg list 
  //| PUT of name : Name option * legs : Leg list 
  //| CAP of name : Name option * legs : Leg list 
  //| CDS of name : Name option * legs : Leg list 
  //| TRS of name : Name option * legs : Leg list 
  //| CRD of name : Name option * legs : Leg list 
  //| SPT of name : Name option * legs : Leg list 
  //| INF of name : Name option * legs : Leg list 
  //| TRL of name : Name option * legs : Leg list 
  //| RTR of name : Name option * legs : Leg list 
  //| SWT of name : Name option * legs : Leg list 
  //| CMS of name : Name option * legs : Leg list 

type DealSchema = 
  { Id : Id option 
  ; Name : Name
  ; Legs : Leg list
  ; NumContract : Count 
  ; Memo : Memo
  }

let makeDeal (d : Deal) : DealSchema =
  match d with 
  | IRS (name, legs) -> {Id = Some 12 ; Name = name ; Legs = legs ; NumContract = 1 ; Memo = "try it!"}
  | CRS (name, legs) -> {Id = Some 23 ; Name = name ; Legs = legs ; NumContract = 1 ; Memo = "try it!"}
  | FTR (name, numContract, legs) -> {Id = Some 34 ; Name = name ; Legs = legs ; NumContract = 1 ; Memo = "try it!"}

let mytestdeal = makeDeal <| Deal.CRS (name = "abcd", legs = [myleg ; otherleg])



(*
let authors = 
  dict [ IRSFIX, dict [ Name, "IRSFIX"]
       ; IRSFLT, dict [ Name, "IRSFIX"]
       ; CRSFIX, dict [ Name, "IRSFIX"]
       ; CRSFLT , dict [ Name, "IRSFIX"]
       ]
*) 

type Tran = 
  | Contract of tradeDate:Date * notionalLocal:Money * numContract:Count 
  | Effect of feeRate:Rate * notionalLocal:Money * numContract:Count 
  | Interest 
  | Accrue 
  | Valuate 
  | Reduce of feeRate : Rate option
  | Terminate of feeRate:Rate option 
  | Mature 


(*

type DealRecord = 
  { Id : int
  ; Name : Name 
  ; BreedId : Breed
  ; TradeDate : Date
  ; EffectDate : Date
  ; TerminateDate : Date 
  ; MatureDate : Date }







type Account = 
  { Id : Id 
  ; Name : Name 
  ; Number : Name
  ; Memo : Memo
  ; Status: Status }









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

type Cashflow = 
  { Id : Id
  ; Pay : Date
  ; LegId : Id
  ; EventId : Id
  ; Contracts : Count
  ; Start : Date
  ; End : Date
  ; NumDays : Count
  ; Rate : RateVal
  ; Amount : MoneyVal
  ; Annote : Memo 
  ; RollId : Id }

type Account = 
  { Id : Id 
  ; Name : Name
  ; AccNum : Name
  ; Active : Active
  ; Memo : Memo }

type Frequency = 
  { Id : Id
  ; Code : Code 
  ; Months : Count
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

*)





(*
CREATE TYPE currency AS (
    code text,
    value decimal(20,2));
*)


type Currency =
  | ALL of Money | DZD of Money | ARS of Money | AUD of Money
  | BSD of Money | BHD of Money | BDT of Money | AMD of Money
  | BBD of Money | BMD of Money | BTN of Money | BOB of Money
  | BWP of Money | BZD of Money | SBD of Money | BND of Money
  | MMK of Money | BIF of Money | KHR of Money | CAD of Money
  | CVE of Money | KYD of Money | LKR of Money | CLP of Money
  | CNY of Money | COP of Money | KMF of Money | CRC of Money
  | HRK of Money | CUP of Money | CZK of Money | DKK of Money
  | DOP of Money | SVC of Money | ETB of Money | ERN of Money
  | FKP of Money | FJD of Money | DJF of Money | GMD of Money
  | GIP of Money | GTQ of Money | GNF of Money | GYD of Money
  | HTG of Money | HNL of Money | HKD of Money | HUF of Money
  | ISK of Money | INR of Money | IDR of Money | IRR of Money
  | IQD of Money | ILS of Money | JMD of Money | JPY of Money
  | KZT of Money | JOD of Money | KES of Money | KPW of Money
  | KRW of Money | KWD of Money | KGS of Money | LAK of Money
  | LBP of Money | LSL of Money | LRD of Money | LYD of Money
  | MOP of Money | MWK of Money | MYR of Money | MVR of Money
  | MUR of Money | MXN of Money | MNT of Money | MDL of Money
  | MAD of Money | OMR of Money | NAD of Money | NPR of Money
  | ANG of Money | AWG of Money | VUV of Money | NZD of Money
  | NIO of Money | NGN of Money | NOK of Money | PKR of Money
  | PAB of Money | PGK of Money | PYG of Money | PEN of Money
  | PHP of Money | QAR of Money | RUB of Money | RWF of Money
  | SHP of Money | SAR of Money | SCR of Money | SLL of Money
  | SGD of Money | VND of Money | SOS of Money | ZAR of Money
  | SSP of Money | SZL of Money | SEK of Money | CHF of Money
  | SYP of Money | THB of Money | TOP of Money | TTD of Money
  | AED of Money | TND of Money | UGX of Money | MKD of Money
  | EGP of Money | GBP of Money | TZS of Money | USD of Money
  | UYU of Money | UZS of Money | WST of Money | YER of Money
  | TWD of Money | UYW of Money | VES of Money | MRU of Money
  | STN of Money | CUC of Money | ZWL of Money | BYN of Money
  | TMT of Money | GHS of Money | SDG of Money | UYI of Money
  | RSD of Money | MZN of Money | AZN of Money | RON of Money
  | CHE of Money | CHW of Money | TRY of Money | XAF of Money
  | XCD of Money | XOF of Money | XPF of Money | XBA of Money
  | XBB of Money | XBC of Money | XBD of Money | XAU of Money
  | XDR of Money | XAG of Money | XPT of Money | XTS of Money
  | XPD of Money | XUA of Money | ZMW of Money | SRD of Money
  | MGA of Money | COU of Money | AFN of Money | TJS of Money
  | AOA of Money | BGN of Money | CDF of Money | BAM of Money
  | EUR of Money | MXV of Money | UAH of Money | GEL of Money
  | BOV of Money | PLN of Money | BRL of Money | CLF of Money
  | XSU of Money | USN of Money | XXX