module Irene.Mock

open System

let mockRates : RateRecord list = [
    { Id = None ; Date = DateTime(2020, 1, 1) ; RateCodeId = 1 ; Percentage = 1.5 } ;
    { Id = None ; Date = DateTime(2020, 1, 3) ; RateCodeId = 1 ; Percentage = 2.0 } ;
    { Id = None ; Date = DateTime(2020, 7, 3) ; RateCodeId = 1 ; Percentage = 2.5 } ;
    { Id = None ; Date = DateTime(2021, 1, 3) ; RateCodeId = 1 ; Percentage = 3.0 } ;
    { Id = None ; Date = DateTime(2021, 7, 3) ; RateCodeId = 1 ; Percentage = 1.5 } ;
    { Id = None ; Date = DateTime(2022, 1, 3) ; RateCodeId = 1 ; Percentage = 2.0 } ;
    { Id = None ; Date = DateTime(2022, 7, 3) ; RateCodeId = 1 ; Percentage = 2.5 } ;
    { Id = None ; Date = DateTime(2023, 1, 3) ; RateCodeId = 1 ; Percentage = 3.0 } ;
    { Id = None ; Date = DateTime(2023, 7, 3) ; RateCodeId = 1 ; Percentage = 2.0 } ;
    { Id = None ; Date = DateTime(2024, 1, 3) ; RateCodeId = 1 ; Percentage = 2.5 } ;
    { Id = None ; Date = DateTime(2024, 7, 3) ; RateCodeId = 1 ; Percentage = 1.5 } ;
    { Id = None ; Date = DateTime(2025, 1, 3) ; RateCodeId = 1 ; Percentage = 2.0 } ;
    { Id = None ; Date = DateTime(2025, 7, 3) ; RateCodeId = 1 ; Percentage = 2.5 } ;
    { Id = None ; Date = DateTime(2026, 1, 3) ; RateCodeId = 1 ; Percentage = 1.5 } ;
    { Id = None ; Date = DateTime(2026, 7, 3) ; RateCodeId = 1 ; Percentage = 2.0 } ;
    { Id = None ; Date = DateTime(2027, 1, 3) ; RateCodeId = 1 ; Percentage = 2.5 } ;
    { Id = None ; Date = DateTime(2027, 7, 3) ; RateCodeId = 1 ; Percentage = 3.0 } ;
]

let irs01 : Deal = {
    Id = 4
    Name = "IRS01" 
    DealTypeId = 1635
    TradeDate = DateTime(2020,1,1)
    EffectiveDate = DateTime(2020,1,3)
    MatureDate = DateTime(2025,1,3)
    TerminateDate = DateTime(2025,1,3)
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