[<AutoOpen>]

module Irene.Domain.Leg

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
