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
 

// Quote 

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
  | None   

let getValueQuote (a : Quote) : (Name * Rate) =
  match a with 
  | Fixed -> ("Fixed", 0.0)
  | Libor1D r -> ("Libor1D", r) 
  | Libor1W r -> ("Libor1W", r) 
  | Libor2W r -> ("Libor2W", r)  
  | Libor1M r -> ("Libor1M", r)   
  | Libor2M r -> ("Libor2M", r) 
  | Libor3M r -> ("Libor3M", r) 
  | Libor6M r -> ("Libor6M", r) 
  | Libor1Y r -> ("Libor1Y", r) 
  | Euribor1W r -> ("Euribor1W", r) 
  | Euribor2W r -> ("Euribor2W", r) 
  | Euribor1M r -> ("Euribor1M", r) 
  | Euribor2M r -> ("Euribor2M", r)   
  | Euribor3M r -> ("Euribor3M", r)  
  | Euribor6M r -> ("Euribor6M", r) 
  | Euribor9M r -> ("Euribor9M", r) 
  | Euribor1Y r -> ("Euribor1Y", r) 
  | None -> ("None", 0.0)

let getTypeQuote (value : (Name * Rate)) : Quote =
  match value with 
  | ("Fixed", r) -> Fixed
  | ("Libor1D", r) -> Libor1D r 
  | ("Libor1W", r) -> Libor1W r 
  | ("Libor2W", r) -> Libor2W r
  | ("Libor1M", r) -> Libor1M r
  | ("Libor2M", r) -> Libor2M r
  | ("Libor3M", r) -> Libor3M r 
  | ("Libor6M", r) -> Libor6M r
  | ("Libor1Y", r) -> Libor1Y r
  | ("Euribor1W", r) -> Euribor1W r
  | ("Euribor2W", r) -> Euribor2W r
  | ("Euribor1M", r) -> Euribor1M r
  | ("Euribor2M", r) -> Euribor2M r 
  | ("Euribor3M", r) -> Euribor3M r
  | ("Euribor6M", r) -> Euribor6M r 
  | ("Euribor9M", r) -> Euribor9M r
  | ("Euribor1Y", r) -> Euribor1Y r
  | ("None", r) -> None 
  | _ -> None 

(*
CREATE TYPE rate AS (
    code text,
    value numeric);
*)



// Deal 

type Deal = 
  | IRS of name : Name 
  | CRS of name : Name 
  | FTR of name : Name * numContract : Count 
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

type DealRecord = 
  { Id : Id option 
  ; Name : Name
  ; Type : Name 
  ; NumContract : Count 
  ; TradeDate : Date
  ; EffectDate : Date
  ; MatureDate : Date
  ; TerminateDate : Date option
  ; Memo : Memo
  }

(*
let makeDeal (d : Deal) : DealRecord =
  match d with 
  | IRS (name) -> {Id = Some 12 ; Name = name ; NumContract = 1 ; Memo = "try it!"}
  | CRS (name) -> {Id = Some 23 ; Name = name ; NumContract = 1 ; Memo = "try it!"}
  | FTR (name, numContract) -> {Id = Some 34 ; Name = name ; NumContract = 1 ; Memo = "try it!"}
let mytestdeal = makeDeal <| Deal.CRS (name = "abcd", legs = [myleg ; otherleg])
*)


// Leg

type Leg = 
  | IRSFIX of id : Id option 
            * dealId : Id 
            * stance : Stance 
            * period : Count 
            * span : Span 
            * day : Day
            * notional : Currency
            * fixedQuote : Quote
            * memo : Memo option 
  | IRSFLT of id : Id option 
            * dealId : Id 
            * stance : Stance 
            * period : Count 
            * span : Span 
            * day : Day
            * notional : Currency
            * movingQuote : Quote
            * memo : Memo option 
  (*
  | CRSFIX of Id : Id option 
            * DealId : Id 
            * Stance : Stance 
            * Period : Count 
            * Span : Span 
            * Day : Day
            * Notional : Currency
            * FixedQuote : Quote
            * Memo : Memo option
  | CRSFLT of Id : Id option 
            * DealId : Id 
            * Stance : Stance 
            * Period : Count 
            * Span : Span 
            * Day : Day
            * Notional : Currency
            * MovingQuote : Quote
            * Memo : Memo option
   *) 

type LegRecord = 
  { Id : Id option 
  ; Type : Name
  ; DealId : Id
  ; Stance : Stance
  ; Period : Count 
  ; Span : Span
  ; Day : Day
  ; Notional : Currency
  ; FixedQuote : Quote option 
  ; MovingQuote : Quote option 
  ; Memo : Memo option }

let testLeg = 
  { Id = Some 12 
  ; Type = "IRSFIX" 
  ; DealId = 1 
  ; Stance = Stance.Pay 
  ; Period = 5 
  ; Span = Span.Annual 
  ; Day = Day.D30360
  ; Notional = Currency.USD 1000000.0
  ; FixedQuote = Some (Quote.Libor1Y 0.0123) 
  ; MovingQuote = Some (Quote.Libor1Y 0.0123) 
  ; Memo = None } 


let makeLegRecord (l : Leg) : LegRecord =
  match l with 
  | IRSFIX (id, dealId, stance
          , period, span, day
          , notional, fixedQuote, Memo )-> { Id = id 
                                           ; Type = "IRSFIX" 
                                           ; DealId = dealId 
                                           ; Stance = stance 
                                           ; Period = period 
                                           ; Span = span 
                                           ; Day = day 
                                           ; Notional = notional 
                                           ; FixedQuote = Some fixedQuote 
                                           ; MovingQuote = None 
                                           ; Memo = None } 
  | IRSFLT (Id, dealId, stance
          , period, span, day
          , notional, movingQuote, Memo )-> { Id = id 
                                            ; Type = "IRSFIX" 
                                            ; DealId = dealId 
                                            ; Stance = stance 
                                            ; Period = period 
                                            ; Span = span 
                                            ; Day = day 
                                            ; Notional = notional 
                                            ; FixedQuote = None 
                                            ; MovingQuote = Some movingQuote 
                                            ; Memo = None } 







// Roll 



// Proj

type Proj = 
  | Contract of tradeDate:Date * notionalLocal:Money * numContract:Count 
  | Effect of feeRate:Rate * notionalLocal:Money * numContract:Count 
  | Interest 
  | Accrue 
  | Valuate 
  | Reduce of feeRate : Rate option
  | Terminate of feeRate:Rate option 
  | Mature 



(*
CREATE TYPE currency AS (
    code text,
    value decimal(20,2));
*)


// Tran 



// Journal
