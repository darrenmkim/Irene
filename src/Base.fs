[<AutoOpen>]

module Irene.Domain

open System




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

type Event = 
  | Contract 
  | Effect
  | Interest
  | Reduce
  | Terminate

type Span = 
  | Continuous
  | Month
  | Quarter 
  | Semiannual
  | Annual
  | Biannual
 
let getMonthsBySpan (s : Span) : byte  =
  match s with 
  | Continuous -> 0uy
  | Month -> 1uy
  | Quarter -> 3uy
  | Semiannual -> 6uy
  | Annual -> 12uy
  | Biannual -> 24uy

type Status =
  | Posted
  | Drafted
  | Deleted

type Day = 
  | D30360
  | DAC360

type Hedge = 
  | FVH // Fair value hedges
  | CFH // Cash flow hedges
  | HNIFO // Hedges of net investment in foreign operations

type Pact = 
  | IRSFIX
  | IRSFLT

type Breed = 
  | IRS 

type Strategy =
  | FVHIRS
  | CFHIRS

type Ticker = 
  | Fixed 
  | Libor1D | Libor1W | Libor2W | Libor1M    
  | Libor2M | Libor3M | Libor6M | Libor1Y 
  | Euribor1W | Euribor2W | Euribor1M | Euribor2M   
  | Euribor3M | Euribor6M | Euribor9M | Euribor1Y 
  | None 


// Currency 

type Currency =
  | ALL | DZD | ARS | AUD | BSD | BHD | BDT | AMD | BBD | BMD | BTN
  | BOB | BWP | BZD | SBD | BND | MMK | BIF | KHR | CAD | CVE | KYD
  | LKR | CLP | CNY | COP | KMF | CRC | HRK | CUP | CZK | DKK | DOP
  | SVC | ETB | ERN | FKP | FJD | DJF | GMD | GIP | GTQ | GNF | GYD
  | HTG | HNL | HKD | HUF | ISK | INR | IDR | IRR | IQD | ILS | JMD
  | JPY | KZT | JOD | KES | KPW | KRW | KWD | KGS | LAK | LBP | LSL
  | LRD | LYD | MOP | MWK | MYR | MVR | MUR | MXN | MNT | MDL | MAD
  | OMR | NAD | NPR | ANG | AWG | VUV | NZD | NIO | NGN | NOK | PKR
  | PAB | PGK | PYG | PEN | PHP | QAR | RUB | RWF | SHP | SAR | SCR
  | SLL | SGD | VND | SOS | ZAR | SSP | SZL | SEK | CHF | SYP | THB
  | TOP | TTD | AED | TND | UGX | MKD | EGP | GBP | TZS | USD | UYU
  | UZS | WST | YER | TWD | UYW | VES | MRU | STN | CUC | ZWL | BYN
  | TMT | GHS | SDG | UYI | RSD | MZN | AZN | RON | CHE | CHW | TRY
  | XAF | XCD | XOF | XPF | XBA | XBB | XBC | XBD | XAU | XDR | XAG
  | XPT | XTS | XPD | XUA | ZMW | SRD | MGA | COU | AFN | TJS | AOA
  | BGN | CDF | BAM | EUR | MXV | UAH | GEL | BOV | PLN | BRL | CLF
  | XSU | USN | XXX | None 
 

// Quote

type Quote =
  { Ticker : Ticker 
  ; Number : float }

type Money =
  { Currency : Currency
  ; Number : float }

type LegIn = 
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

type DealIn = 
  { Id : uint32 
  ; Name : string 
  ; Breed : Breed
  ; Strategy : Strategy
  ; TradeDate : DateTime 
  ; EffectDate : DateTime
  ; MatureDate : DateTime
  ; TerminateDate : DateTime
  ; Leg : LegIn list
  ; Active : bool
  ; Memo : string }

type Proj = 
  { Id : uint32
  ; Date : DateTime 
  ; DealId : uint32 
  ; LegId : uint32
  ; Event : Event
  ; PeriodStart : DateTime 
  ; PeriodEnd : DateTime  
  ; DaysInPeriod : uint16
  ; RateQuote : Quote  
  ; Notional : Money 
  ; Amount : Currency
  ; Actual : bool }
