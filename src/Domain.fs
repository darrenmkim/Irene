[<AutoOpen>]

module Irene.Domain


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
  | Nothing   

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
  | Nothing -> ("Nothing", 0.0)

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
  | ("Nothing", r) -> Nothing 
  | _ -> Nothing 

(*
CREATE TYPE rate AS (
    code text,
    value numeric);
*)


// Leg

type Leg = 
  | IRSFIX of id : Id option 
            * name : Name
            * tradeDate : Date
            * effectDate : Date
            * matureDate : Date
            * terminateDate : Date option
            * numContract : Count 
            * stance : Stance 
            * period : Count 
            * span : Span 
            * day : Day
            * notional : Currency
            * fixedQuote : Quote
            * memo : Memo option 
(*
  | IRSFLT of id : Id option 
            * name : Name
            * tradeDate : Date
            * effectDate : Date
            * matureDate : Date
            * terminateDate : Date option
            * numContract : Count 
            * stance : Stance 
            * period : Count 
            * span : Span 
            * day : Day
            * notional : Currency
            * movingQuote : Quote
            * memo : Memo option 
*) 

type LegDbRcd = 
  { Id : Id option 
  ; Name : Name 
  ; DealType : Name
  ; LegType : Name 
  ; TradeDate : Date
  ; EffectDate : Date
  ; MatureDate : Date
  ; TerminateDate : Date option
  ; NumContract : Count 
  ; StanceId : Name
  ; Period : Count 
  ; SpanId : Name
  ; DayId : Name
  ; Notional : (Name * Money)
  ; FixedQuote : (Name * Rate)
  ; MovingQuote : (Name * Rate)
  ; Memo : Memo option }

let makeDbRcdFromLeg (l : Leg) : LegDbRcd =
  match l with 
  | IRSFIX ( id, name, tradeDate, 
             effectDate, matureDate, 
             terminateDate, numContract, 
             stance, period, span, 
             day, notional, fixedQuote, memo 
             )-> { Id = id 
                 ; Name = name 
                 ; DealType = "IRS"
                 ; LegType = "IRSFIX"
                 ; TradeDate = tradeDate
                 ; EffectDate = effectDate           
                 ; MatureDate = matureDate
                 ; TerminateDate = terminateDate
                 ; NumContract = 1
                 ; StanceId = getValueStance stance 
                 ; Period = period 
                 ; SpanId = getValueSpan span 
                 ; DayId = getValueDay day 
                 ; Notional = getValueCurrency notional 
                 ; FixedQuote = getValueQuote fixedQuote 
                 ; MovingQuote = ("Nothing", 0.0)
                 ; Memo = memo }

let makeLegfromDbRcd (r : LegDbRcd) : Leg =
  match r.LegType with 
  | "IRSFIX" -> Leg.IRSFIX ( id = r.Id
                           , name =  r.Name
                           , tradeDate = r.TradeDate
                           , effectDate = r.EffectDate
                           , matureDate = r.MatureDate
                           , terminateDate = r.TerminateDate
                           , numContract = r.NumContract
                           , stance = getTypeStance r.StanceId
                           , period = r.Period
                           , span = getTypeSpan r.SpanId 
                           , day = getTypeDay r.DayId
                           , notional = getTypeCurrency r.Notional
                           , fixedQuote = getTypeQuote r.FixedQuote
                           , memo = r.Memo )
  | _ -> Leg.IRSFIX        ( id = r.Id
                           , name =  r.Name
                           , tradeDate = r.TradeDate
                           , effectDate = r.EffectDate
                           , matureDate = r.MatureDate
                           , terminateDate = r.TerminateDate
                           , numContract = r.NumContract
                           , stance = getTypeStance r.StanceId
                           , period = r.Period
                           , span = getTypeSpan r.SpanId 
                           , day = getTypeDay r.DayId
                           , notional = getTypeCurrency r.Notional
                           , fixedQuote = getTypeQuote r.FixedQuote
                           , memo = r.Memo )

let myLeg : Leg = 
  Leg.IRSFIX ( id = Some 1
             , name = "abc"
             , tradeDate = Date(2012,6,8)
             , effectDate = Date(2012,6,8)
             , matureDate = Date(2012,6,8)
             , terminateDate = Some(Date(2012,6,8))
             , numContract = 1
             , stance = Stance.Pay
             , period = 10 
             , span = Span.Annual
             , day =  Day.D30360
             , notional = Currency.USD 120.11
             , fixedQuote = Quote.Libor1Y 0.0012
             , memo = Some "abc")
let myLegDbRcd = makeDbRcdFromLeg myLeg
let myLegAgain = makeLegfromDbRcd myLegDbRcd


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
