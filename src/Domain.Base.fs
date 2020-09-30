[<AutoOpen>]

module Irene.Domain.Base

type Date = System.DateTime
type Time = System.DateTime


// Ability 

type Ability = 
  | Admin 
  | Approver 
  | Preparer 
  | Viewer
  | Nothing 

let getAbilityValueFromType a = 
  match a with 
  | Admin -> "Admin"
  | Approver -> "Approver"
  | Preparer -> "Preparer"
  | Viewer -> "Viewer"
  | Nothing -> "Nothing"

let getAbilityTypeFromValue v = 
  match v with 
  | "Admin" -> Admin
  | "Approver" -> Approver
  | "Preparer" -> Preparer
  | "Viewer" -> Viewer
  | _ -> Nothing


// Stance 

type Stance = 
  | Pay 
  | Receive
  | Buy
  | Sell
  | Nothing 

let getStanceValueFromType a = 
  match a with 
  | Pay -> "Pay"
  | Receive -> "Receive"
  | Buy -> "Buy"
  | Sell -> "Sell"
  | Nothing -> "Nothing"

let getStanceTypeFromValue v = 
  match v with 
  | "Pay" -> Pay
  | "Receive" -> Receive
  | "Buy" -> Buy
  | "Sell" -> Sell
  | _ -> Nothing


// Event 

type Event = 
  | Contract 
  | Effect
  | Interest
  | Reduce
  | Terminate
  | Nothing 

let getEventValueFromType a = 
  match a with 
  | Contract -> "Contract"
  | Effect -> "Effect"
  | Interest -> "Interest"
  | Reduce -> "Reduce"
  | Terminate -> "Terminate"
  | Nothing -> "Nothing"

let getEventTypeFromValue v = 
  match v with 
  | "Contract" -> Contract
  | "Effect" -> Effect
  | "Interest" -> Interest
  | "Reduce" -> Reduce
  | "Terminate"-> Terminate
  | "Nothing" -> Nothing
  | _ -> Nothing

// Span 

type Span = 
  | Continuous
  | Month
  | Quarter 
  | Semiannual
  | Annual
  | Biannual
  | Nothing

let getSpanValueFromType t = 
  match t with 
  | Continuous -> "Continuous"
  | Month -> "Month"
  | Quarter -> "Quarter"
  | Semiannual -> "Semiannual"
  | Annual -> "Annual"
  | Biannual -> "Biannual"
  | Nothing -> "Nothing"

let getSpanTypeFromValue v = 
  match v with 
  | "Continuous" -> Continuous
  | "Month" -> Month
  | "Quarter" -> Quarter
  | "Semiannual" -> Semiannual
  | "Annual" -> Annual
  | "Biannual" -> Biannual
  | "Nothing" -> Nothing
  | _ -> Nothing

let getMonthsBySpan (s : Span) : byte  =
  match s with 
  | Continuous -> 0uy
  | Month -> 1uy
  | Quarter -> 3uy
  | Semiannual -> 6uy
  | Annual -> 12uy
  | Biannual -> 24uy
  | Nothing -> 0uy


// Status

type Status =
  | Posted
  | Drafted
  | Deleted
  | Nothing
  
let getStatusValueFromType t = 
  match t with 
  | Posted -> "Posted"
  | Drafted -> "Drafted"
  | Deleted -> "Deleted"
  | Nothing -> "Nothing"

let getStatusTypeFromValue v = 
  match v with 
  | "Posted" -> Posted
  | "Drafted" -> Drafted
  | "Deleted" -> Deleted
  | "Nothing" -> Nothing
  | _ -> Nothing


// Day  

type Day = 
  | D30360
  | DAC360
  | Nothing

let getDayValueFromType t = 
  match t with 
  | D30360 -> "30360"
  | DAC360 -> "AC360"
  | Nothing -> "Nothing"

let getDayTypeFromValue v = 
  match v with 
  | "30360" -> D30360
  | "AC360" -> DAC360
  | "Nothing" -> Nothing
  | _ -> Nothing


// Hedge

type Hedge = 
  | FVH // Fair value hedges
  | CFH // Cash flow hedges
  | HNIFO // Hedges of net investment in foreign operations


// Pact 

type Pact = 
  | IRSFIX
  | IRSFLT
  | Nothing 

let getPactValueFromType t = 
  match t with 
  | IRSFIX -> "IRSFIX"
  | IRSFLT -> "IRSFLT"
  | Nothing -> "Nothing"

let getPactTypeFromValue v = 
  match v with 
  | "IRSFIX" -> IRSFIX
  | "IRSFLT" -> IRSFLT
  | "Nothing" -> Nothing
  | _ -> Nothing


// Breed 

type Breed = 
  | IRS 
  | Nothing

let getBreedValueFromType t = 
  match t with 
  | IRS -> "IRS"
  | Nothing -> "Nothing"

let getBreedTypeFromValue v = 
  match v with 
  | "IRS" -> IRS
  | "Nothing" -> Nothing
  | _ -> Nothing


// Strategry 

type Strategy =
  | FVHIRS
  | CFHIRS
  | Nothing

let getStrategyValueFromType t = 
  match t with 
  | FVHIRS -> "FVHIRS"
  | CFHIRS -> "CFHIRS"
  | Nothing -> "Nothing"

let getStrategyTypeFromValue v = 
  match v with 
  | "FVHIRS" -> FVHIRS
  | "CFHIRS" -> CFHIRS
  | "Nothing" -> Nothing
  | _ -> Nothing


// Ticker
type Ticker = 
  | Fixed 
  | Libor1D  
  | Libor1W  
  | Libor2W   
  | Libor1M    
  | Libor2M  
  | Libor3M   
  | Libor6M   
  | Libor1Y   
  | Euribor1W   
  | Euribor2W   
  | Euribor1M   
  | Euribor2M   
  | Euribor3M   
  | Euribor6M  
  | Euribor9M   
  | Euribor1Y 
  | None 



// Currency 

type Currency =
  | ALL
  | DZD
  | ARS
  | AUD
  | BSD
  | BHD
  | BDT
  | AMD
  | BBD
  | BMD
  | BTN
  | BOB
  | BWP
  | BZD
  | SBD
  | BND
  | MMK
  | BIF
  | KHR
  | CAD
  | CVE
  | KYD
  | LKR
  | CLP
  | CNY
  | COP
  | KMF
  | CRC
  | HRK
  | CUP
  | CZK
  | DKK
  | DOP
  | SVC
  | ETB
  | ERN
  | FKP
  | FJD
  | DJF
  | GMD
  | GIP
  | GTQ
  | GNF
  | GYD
  | HTG
  | HNL
  | HKD
  | HUF
  | ISK
  | INR
  | IDR
  | IRR
  | IQD
  | ILS
  | JMD
  | JPY
  | KZT
  | JOD
  | KES
  | KPW
  | KRW
  | KWD
  | KGS
  | LAK
  | LBP
  | LSL
  | LRD
  | LYD
  | MOP
  | MWK
  | MYR
  | MVR
  | MUR
  | MXN
  | MNT
  | MDL
  | MAD
  | OMR
  | NAD
  | NPR
  | ANG
  | AWG
  | VUV
  | NZD
  | NIO
  | NGN
  | NOK
  | PKR
  | PAB
  | PGK
  | PYG
  | PEN
  | PHP
  | QAR
  | RUB
  | RWF
  | SHP
  | SAR
  | SCR
  | SLL
  | SGD
  | VND
  | SOS
  | ZAR
  | SSP
  | SZL
  | SEK
  | CHF
  | SYP
  | THB
  | TOP
  | TTD
  | AED
  | TND
  | UGX
  | MKD
  | EGP
  | GBP
  | TZS
  | USD
  | UYU
  | UZS
  | WST
  | YER
  | TWD
  | UYW
  | VES
  | MRU
  | STN
  | CUC
  | ZWL
  | BYN
  | TMT
  | GHS
  | SDG
  | UYI
  | RSD
  | MZN
  | AZN
  | RON
  | CHE
  | CHW
  | TRY
  | XAF
  | XCD
  | XOF
  | XPF
  | XBA
  | XBB
  | XBC
  | XBD
  | XAU
  | XDR
  | XAG
  | XPT
  | XTS
  | XPD
  | XUA
  | ZMW
  | SRD
  | MGA
  | COU
  | AFN
  | TJS
  | AOA
  | BGN
  | CDF
  | BAM
  | EUR
  | MXV
  | UAH
  | GEL
  | BOV
  | PLN
  | BRL
  | CLF
  | XSU
  | USN
  | XXX
  | None 
 

// Quote

type Quote =
  { Ticker : Ticker 
  ; Number : float }

type Money =
  { Currency : Currency
  ; Number : float }

type Leg = 
  { Id : uint32
  ; Name : string  
  ; Pact : Pact
  ; Stance : Stance
  ; Period : uint16
  ; Span : Span
  ; Day : Day
  ; ContractNum : byte 
  ; Notional : Money
  ; FixedQuote : Quote 
  ; MovingTicker : Ticker  
  ; Memo : string }

type Deal = 
  { Id : uint32 
  ; Name : string 
  ; Breed : Breed
  ; Strategy : Strategy
  ; TradeDate : Date
  ; EffectDate : Date
  ; MatureDate : Date
  ; TerminateDate : Date
  ; Leg : Leg list
  ; Active : bool
  ; Memo : string }

type Proj = 
  { Id : uint32
  ; Date : Date 
  ; DealId : uint32 
  ; LegId : uint32
  ; Event : Event
  ; PeriodStart : Date 
  ; PeriodEnd : Date  
  ; DaysInPeriod : uint16
  ; RateQuote : Quote  
  ; Notional : Money 
  ; Amount : Currency
  ; Actual : bool }
