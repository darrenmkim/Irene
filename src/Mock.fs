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

let irs01fixleg : Leg =  {
    Id = Some 11 ;
    LegType = IrsFixed ; 
    Stance = Stance.Payer ; // this is payside leg
    Currency = Currency.USD ; // usd
    PayFreq = PayFreq.SemiAnnually ; // semi-annual
    DayConv = DayConv.DC'AC360 ; // default
    Notional = 1000000.0 ;
    FixedRate = Some 2.0
}

let irs01floatlet : Leg =  {
    Id = Some 12 ; 
    LegType = IrsFloat ;
    Stance = Stance.Payer ;
    Currency = Currency.USD ; // usd
    PayFreq = PayFreq.SemiAnnually ; // semi-annua
    DayConv = DayConv.DC'AC360 ; 
    Notional = 1000000.0 ;
    FixedRate = None 
}

let dealTableMockItems : Deal list  = [
    { Id = Some 4 ;
         Name = "IRS01" ;
        DealType = IRS ;
        LegPay =  Some irs01floatlet ; 
        LegReceive = Some irs01fixleg ; 
        TradeDate = DateTime(2020,1,1) ;
        EffectiveDate = DateTime(2020,1,3) ;
        MatureDate = DateTime(2025,1,3) ;
        TerminateDate = None
    }; 
      { Id = Some 4 ;
        Name = "IRS02" ;
        DealType = IRS ;
        LegPay =  Some irs01floatlet ; 
        LegReceive = Some irs01fixleg ; 
        TradeDate = DateTime(2020,1,1) ;
        EffectiveDate = DateTime(2020,1,3) ;
        MatureDate = DateTime(2025,1,3) ;
        TerminateDate = None
    }; 
]

