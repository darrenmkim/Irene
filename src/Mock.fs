module Irene.Mock

open System

let mockRates : Rate list = [
    { Id = 1 ; Date = DateTime(2020, 2, 1) ; RateInfoId = 1 ; Fraction = 1.5 }
    { Id = 1 ; Date = DateTime(2020, 2, 1) ; RateInfoId = 1 ; Fraction = 1.5 }
    { Id = 1 ; Date = DateTime(2020, 2, 1) ; RateInfoId = 1 ; Fraction = 1.5 }
    { Id = 1 ; Date = DateTime(2020, 2, 1) ; RateInfoId = 1 ; Fraction = 1.5 }
    { Id = 1 ; Date = DateTime(2020, 2, 1) ; RateInfoId = 1 ; Fraction = 1.5 }
    { Id = 1 ; Date = DateTime(2020, 2, 1) ; RateInfoId = 1 ; Fraction = 1.5 }
    { Id = 1 ; Date = DateTime(2020, 2, 1) ; RateInfoId = 1 ; Fraction = 1.5 }
    { Id = 1 ; Date = DateTime(2020, 2, 1) ; RateInfoId = 1 ; Fraction = 1.5 }
    { Id = 1 ; Date = DateTime(2020, 2, 1) ; RateInfoId = 1 ; Fraction = 1.5 }
    { Id = 1 ; Date = DateTime(2020, 2, 1) ; RateInfoId = 1 ; Fraction = 1.5 }
    { Id = 1 ; Date = DateTime(2020, 2, 1) ; RateInfoId = 1 ; Fraction = 1.5 }
    { Id = 1 ; Date = DateTime(2020, 2, 1) ; RateInfoId = 1 ; Fraction = 1.5 }
    { Id = 1 ; Date = DateTime(2020, 2, 1) ; RateInfoId = 1 ; Fraction = 1.5 }
]

let irs01 : Deal = {
    Id = 4
    Name = "IRS01" 
    DealTypeId = 1635
    TradeDate = DateTime(2019,10,13)
    EffectiveDate = DateTime(2019,10,15)
    MatureDate = DateTime(2029,10,15)
    TerminateDate = DateTime(2029,10,15)
}

let irs01fixleg : Leg = {
    Id = 11 ; 
    Name = "IRS01FIXLEG" ;
    LegTypeId = 3 ;
    DealId = 4 ; 
    StanceId = 1 ; // this is payside leg
    CurrencyId = 840 ; // usd
    PayFreqId = 43 ; // semi-annual
    DayConvId = 1 ; // default
    Notional = 1000000.0 ;
    FixedRate = Some 0.02
}

let irs01floatlet : Leg = {
    Id = 12 ; 
    Name = "IRS01FLOATLEG" ;
    LegTypeId = 3 ;
    DealId = 4 ; 
    StanceId = 2 ; // this is receiveside leg
    CurrencyId = 840 ; // usd
    PayFreqId = 43 ; // semi-annual
    DayConvId = 1 ; // default
    Notional = 1000000.0 ;
    FixedRate = None
}