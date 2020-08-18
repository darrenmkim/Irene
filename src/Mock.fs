module Irene.Mock

let legs = [
    { Id = 1 
    ; Name = "ABCIRSFIX" 
    ; DealId = 1 
    ; PactId =  1
    ; StanceId = 1
    ; BaseCurId = 1 
    ; LocalCurId = 1 
    ; PaymentFreqId = 1 
    ; DayConvId = 2
    ; NotionalAmt = 1000000.0 
    ; RateCodeId = 2
    ; RateGiven = Some 2.0 } ; 
    { Id = 2
    ; Name = "ABCIRSFLT" 
    ; DealId = 1 
    ; PactId =  1
    ; StanceId = 1
    ; BaseCurId = 1 
    ; LocalCurId = 1 
    ; PaymentFreqId = 1 
    ; DayConvId = 2
    ; NotionalAmt = 1000000.0 
    ; RateCodeId = 2
    ; RateGiven = Some 2.0 } ]

let rolls = [
    { Id = 1 
    ; OrderId = 1 
    ; OrderTime = System.DateTime(2020,1,1,3,3,3)
    ; StartDate = System.DateTime(2020,1,1)
    ; EndDate = System.DateTime(2020,1,1) } ]


(*
let mock_pact_irsfix = (make_pact (Some 1) "IRSFIX" "Interest Rate Swap Fixed Leg") 
let mock_pact_irsflt = (make_pact (Some 2) "IRSFLT" "Interest Rate Swap Float Leg") 


let mock_accounts = [
    (make_account None "Cash" IRSFIX Pay "12340000" "Cash clearing") ;
    (make_account None "Cash" IRSFIX Pay "12340000" "Cash clearing") ;
    (make_account None "Cash" IRSFIX Pay "12340000" "Cash clearing") ;
    (make_account None "Cash" IRSFIX Pay "12340000" "Cash clearing") ;
    (make_account None "Cash" IRSFIX Pay "12340000" "Cash clearing") ;
    (make_account None "Cash" IRSFIX Pay "12340000" "Cash clearing") ;
    (make_account None "Cash" IRSFIX Pay "12340000" "Cash clearing") ;
    (make_account None "Cash" IRSFIX Pay "12340000" "Cash clearing") ;
]





*)

