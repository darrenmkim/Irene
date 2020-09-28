[<AutoOpen>]

module Irene.Domain.Deal

// Leg

type Leg = 
  | IRSFIX of 
      id : Id option * 
      name : Name * 
      tradeDate : Date * 
      effectDate : Date * 
      matureDate : Date * 
      terminateDate : Date option * 
      contractNum : Count * 
      stance : Stance * 
      period : Count * 
      span : Span * 
      day : Day * 
      notional : Currency * 
      fixedQuote : Quote * 
      memo : Memo option 
  | IRSFLT of 
      id : Id option * 
      name : Name * 
      tradeDate : Date * 
      effectDate : Date * 
      matureDate : Date * 
      terminateDate : Date option * 
      contractNum : Count * 
      stance : Stance * 
      period : Count * 
      span : Span * 
      day : Day * 
      notional : Currency * 
      movingQuote : Quote * 
      memo : Memo option 

type LegRecord = 
  { Id : Id option 
  ; Name : Name 
  ; DealType : Name
  ; LegType : Name 
  ; TradeDate : Date
  ; EffectDate : Date
  ; MatureDate : Date
  ; TerminateDate : Date option
  ; ContractNum : Count 
  ; StanceId : Name
  ; Period : Count 
  ; SpanId : Name
  ; DayId : Name
  ; Notional : (Name * Money)
  ; FixedQuote : (Name * Rate)
  ; MovingQuote : (Name * Rate)
  ; Memo : Memo option }

let makeLegRecordFromLeg (l : Leg) : LegRecord =
  match l with 
  | IRSFIX ( id, name, tradeDate, 
             effectDate, matureDate, 
             terminateDate, contractNum, 
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
                 ; ContractNum = 1
                 ; StanceId = getStanceValueFromType stance 
                 ; Period = period 
                 ; SpanId = getSpanValueFromType span 
                 ; DayId = getDayValueFromType day 
                 ; Notional = getCurrencyValueFromType notional 
                 ; FixedQuote = getValueQuote fixedQuote 
                 ; MovingQuote = ("Nothing", 0.0)
                 ; Memo = memo }
  | IRSFLT ( id, name, tradeDate, 
             effectDate, matureDate, 
             terminateDate, contractNum, 
             stance, period, span, 
             day, notional, movingQuote, memo 
             )-> { Id = id 
                 ; Name = name 
                 ; DealType = "IRS"
                 ; LegType = "IRSFIX"
                 ; TradeDate = tradeDate
                 ; EffectDate = effectDate           
                 ; MatureDate = matureDate
                 ; TerminateDate = terminateDate
                 ; ContractNum = 1
                 ; StanceId = getStanceValueFromType stance 
                 ; Period = period 
                 ; SpanId = getSpanValueFromType span 
                 ; DayId = getDayValueFromType day 
                 ; Notional = getCurrencyValueFromType notional 
                 ; FixedQuote = ("Nothing", 0.0)
                 ; MovingQuote = getValueQuote movingQuote
                 ; Memo = memo }

let makeLegFromLegRecord (r : LegRecord) : Leg option =
  match r.LegType with 
  | "IRSFIX" -> Some (Leg.IRSFIX ( id = r.Id
                           , name =  r.Name
                           , tradeDate = r.TradeDate
                           , effectDate = r.EffectDate
                           , matureDate = r.MatureDate
                           , terminateDate = r.TerminateDate
                           , contractNum = r.ContractNum
                           , stance = getStanceTypeFromValue r.StanceId
                           , period = r.Period
                           , span = getSpanTypeFromValue r.SpanId 
                           , day = getDayTypeFromValue r.DayId
                           , notional = getCurrencyTypeFromValue r.Notional
                           , fixedQuote = getTypeQuote r.FixedQuote
                           , memo = r.Memo ))
  | "IRSFLT" -> Some (Leg.IRSFLT ( id = r.Id
                           , name =  r.Name
                           , tradeDate = r.TradeDate
                           , effectDate = r.EffectDate
                           , matureDate = r.MatureDate
                           , terminateDate = r.TerminateDate
                           , contractNum = r.ContractNum
                           , stance = getStanceTypeFromValue r.StanceId
                           , period = r.Period
                           , span = getSpanTypeFromValue r.SpanId 
                           , day = getDayTypeFromValue r.DayId
                           , notional = getCurrencyTypeFromValue r.Notional
                           , movingQuote = getTypeQuote r.MovingQuote
                           , memo = r.Memo ))                
  | _ -> None

let myLeg : Leg = 
  Leg.IRSFIX ( id = Some 1
             , name = "abc"
             , tradeDate = Date(2012,6,8)
             , effectDate = Date(2012,6,8)
             , matureDate = Date(2012,6,8)
             , terminateDate = Some(Date(2012,6,8))
             , contractNum = 1
             , stance = Stance.Pay
             , period = 10 
             , span = Span.Annual
             , day =  Day.D30360
             , notional = Currency.USD 120.11
             , fixedQuote = Quote.Libor1Y 0.0012
             , memo = Some "abc")
let myLegRecord = makeLegRecordFromLeg myLeg
let myLegAgain = makeLegFromLegRecord myLegRecord


// Deal 

type Deal = 
  | FVHIRS of // Fair Value Hedge Interest Rate Swap 
      id : Id option * 
      name : Name * 
      tradeDate : Date * 
      effectDate : Date * 
      matureDate : Date * 
      terminateDate : Date option * 
      legs : Leg list
  | CFHIRS of // Cashflow Hedge Interest Rate Swap 
      id : Id option * 
      name : Name * 
      tradeDate : Date * 
      effectDate : Date * 
      matureDate : Date * 
      terminateDate : Date option * 
      legs : Leg list

let firstDeal = 
  Deal.FVHIRS ( id = Some 1
              , name = "abc"
              , tradeDate = Date(2012,6,8)
              , effectDate = Date(2012,6,8)
              , matureDate = Date(2012,6,8)
              , terminateDate = Some(Date(2012,6,8))
              , legs = [ myLeg ; myLeg ])

type DealRecord = 
  { Id : Id option 
  ; Name : Name 
  ; DealType : Name
  ; TradeDate : Date
  ; EffectDate : Date
  ; MatureDate : Date
  ; TerminateDate : Date option
  ; LegIds : Id list
  ; Memo : Memo option }

let makeDealRecordFromDeal (d : Deal) : DealRecord =
  match d with 
  | FVHIRS ( id, name, tradeDate,
             effectDate, matureDate, 
             terminateDate, legs
             ) -> { Id = id
                  ; Name = name 
                  ; DealType = "FVHIRS"
                  ; TradeDate = tradeDate
                  ; EffectDate = effectDate
                  ; MatureDate = matureDate
                  ; TerminateDate = terminateDate
                  ; LegIds = [1 ; 2]
                  ; Memo = Some "abc" }
  | CFHIRS (id, name, tradeDate,
            effectDate, matureDate, 
            terminateDate, legs
            ) -> { Id = id
                 ; Name = name 
                 ; DealType = "FVHIRS"
                 ; TradeDate = tradeDate
                 ; EffectDate = effectDate
                 ; MatureDate = matureDate
                 ; TerminateDate = terminateDate
                 ; LegIds = [1 ; 2]
                 ; Memo = Some "abc" }
