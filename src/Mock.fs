module Irene.Mock

open System

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
    Id = 10 ; 
    Name = "IRS01FIXLEG" ;
    LegTypeId = 3 ;
    DealId = 4 ; 
    StanceId = 1 ;
    CurrencyId = 840 ; 
    PayFreqId = 43 ;
    DayConvId = 1 ;
    Notional = 1000000.0 ;
    FixedRate = 0.02
}