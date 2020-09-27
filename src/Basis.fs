[<AutoOpen>]

module Irene.Basis

type Id = int 
type Name = string
type Memo = string
type Count = int
type Money = float
type Rate = float
type Percent = float
type Date = System.DateTime
type Time = System.DateTime
 

// Ability 

type Ability = 
  | Admin 
  | Approver 
  | Preparer 
  | Viewer
  | None 

let getValueAbility a = 
  match a with 
  | Admin -> "Admin"
  | Approver -> "Approver"
  | Preparer -> "Preparer"
  | Viewer -> "Viewer"
  | None -> "None"

let getTypeAbility v = 
  match v with 
  | "Admin" -> Admin
  | "Approver" -> Approver
  | "Preparer" -> Preparer
  | "Viewer" -> Viewer
  | _ -> None


// Stance 

type Stance = 
  | Pay 
  | Receive
  | Buy
  | Sell
  | None 

let getValueStance a = 
  match a with 
  | Pay -> "Pay"
  | Receive -> "Receive"
  | Buy -> "Buy"
  | Sell -> "Sell"
  | None -> "None"

let getTypeStance v = 
  match v with 
  | "Pay" -> Pay
  | "Receive" -> Receive
  | "Buy" -> Buy
  | "Sell" -> Sell
  | _ -> None


// Span 

type Span = 
  | Continuous
  | Month
  | Quarter 
  | Semiannual
  | Annual
  | Biannual
  | None

let getValueSpan t = 
  match t with 
  | Continuous -> "Continuous"
  | Month -> "Month"
  | Quarter -> "Quarter"
  | Semiannual -> "Semiannual"
  | Annual -> "Annual"
  | Biannual -> "Biannual"
  | None -> "None"

let getTypeSpan v = 
  match v with 
  | "Continuous" -> Continuous
  | "Month" -> Month
  | "Quarter" -> Quarter
  | "Semiannual" -> Semiannual
  | "Annual" -> Annual
  | "Biannual" -> Biannual
  | "None" -> None
  | _ -> None


// Status

type Status =
  | Posted
  | Drafted
  | Deleted
  | Activated
  | Deactivated 
  | None
  
let getValueStatus t = 
  match t with 
  | Posted -> "Posted"
  | Drafted -> "Drafted"
  | Deleted -> "Deleted"
  | Activated -> "Activated"
  | Deactivated -> "Deactivated"
  | None -> "None"

let getTypeStatus v = 
  match v with 
  | "Posted" -> Posted
  | "Drafted" -> Drafted
  | "Deleted" -> Deleted
  | "Activated" -> Activated
  | "Deactivated" -> Deactivated
  | "None" -> None
  | _ -> None


// Day  

type Day = 
  | D30360
  | DAC360
  | None

let getValueDay t = 
  match t with 
  | D30360 -> "30360"
  | DAC360 -> "AC360"
  | None -> "None"

let getTypeDay v = 
  match v with 
  | "30360" -> D30360
  | "AC360" -> DAC360
  | "None" -> None
  | _ -> None


// Currency 

type Currency =
  | ALL of Money
  | DZD of Money
  | ARS of Money
  | AUD of Money
  | BSD of Money
  | BHD of Money
  | BDT of Money
  | AMD of Money
  | BBD of Money
  | BMD of Money
  | BTN of Money
  | BOB of Money
  | BWP of Money
  | BZD of Money
  | SBD of Money
  | BND of Money
  | MMK of Money
  | BIF of Money
  | KHR of Money
  | CAD of Money
  | CVE of Money
  | KYD of Money
  | LKR of Money
  | CLP of Money
  | CNY of Money
  | COP of Money
  | KMF of Money
  | CRC of Money
  | HRK of Money
  | CUP of Money
  | CZK of Money
  | DKK of Money
  | DOP of Money
  | SVC of Money
  | ETB of Money
  | ERN of Money
  | FKP of Money
  | FJD of Money
  | DJF of Money
  | GMD of Money
  | GIP of Money
  | GTQ of Money
  | GNF of Money
  | GYD of Money
  | HTG of Money
  | HNL of Money
  | HKD of Money
  | HUF of Money
  | ISK of Money
  | INR of Money
  | IDR of Money
  | IRR of Money
  | IQD of Money
  | ILS of Money
  | JMD of Money
  | JPY of Money
  | KZT of Money
  | JOD of Money
  | KES of Money
  | KPW of Money
  | KRW of Money
  | KWD of Money
  | KGS of Money
  | LAK of Money
  | LBP of Money
  | LSL of Money
  | LRD of Money
  | LYD of Money
  | MOP of Money
  | MWK of Money
  | MYR of Money
  | MVR of Money
  | MUR of Money
  | MXN of Money
  | MNT of Money
  | MDL of Money
  | MAD of Money
  | OMR of Money
  | NAD of Money
  | NPR of Money
  | ANG of Money
  | AWG of Money
  | VUV of Money
  | NZD of Money
  | NIO of Money
  | NGN of Money
  | NOK of Money
  | PKR of Money
  | PAB of Money
  | PGK of Money
  | PYG of Money
  | PEN of Money
  | PHP of Money
  | QAR of Money
  | RUB of Money
  | RWF of Money
  | SHP of Money
  | SAR of Money
  | SCR of Money
  | SLL of Money
  | SGD of Money
  | VND of Money
  | SOS of Money
  | ZAR of Money
  | SSP of Money
  | SZL of Money
  | SEK of Money
  | CHF of Money
  | SYP of Money
  | THB of Money
  | TOP of Money
  | TTD of Money
  | AED of Money
  | TND of Money
  | UGX of Money
  | MKD of Money
  | EGP of Money
  | GBP of Money
  | TZS of Money
  | USD of Money
  | UYU of Money
  | UZS of Money
  | WST of Money
  | YER of Money
  | TWD of Money
  | UYW of Money
  | VES of Money
  | MRU of Money
  | STN of Money
  | CUC of Money
  | ZWL of Money
  | BYN of Money
  | TMT of Money
  | GHS of Money
  | SDG of Money
  | UYI of Money
  | RSD of Money
  | MZN of Money
  | AZN of Money
  | RON of Money
  | CHE of Money
  | CHW of Money
  | TRY of Money
  | XAF of Money
  | XCD of Money
  | XOF of Money
  | XPF of Money
  | XBA of Money
  | XBB of Money
  | XBC of Money
  | XBD of Money
  | XAU of Money
  | XDR of Money
  | XAG of Money
  | XPT of Money
  | XTS of Money
  | XPD of Money
  | XUA of Money
  | ZMW of Money
  | SRD of Money
  | MGA of Money
  | COU of Money
  | AFN of Money
  | TJS of Money
  | AOA of Money
  | BGN of Money
  | CDF of Money
  | BAM of Money
  | EUR of Money
  | MXV of Money
  | UAH of Money
  | GEL of Money
  | BOV of Money
  | PLN of Money
  | BRL of Money
  | CLF of Money
  | XSU of Money
  | USN of Money
  | XXX of Money
  | None 
 
let getValueCurrency t = 
  match t with 
  | ALL m -> ("ALL", m)
  | DZD m -> ("DZD", m)
  | ARS m -> ("ARS", m)
  | AUD m -> ("AUD", m)
  | BSD m -> ("BSD", m)
  | BHD m -> ("BHD", m)
  | BDT m -> ("BDT", m)
  | AMD m -> ("AMD", m)
  | BBD m -> ("BBD", m)
  | BMD m -> ("BMD", m)
  | BTN m -> ("BTN", m)
  | BOB m -> ("BOB", m)
  | BWP m -> ("BWP", m)
  | BZD m -> ("BZD", m)
  | SBD m -> ("SBD", m)
  | BND m -> ("BND", m)
  | MMK m -> ("MMK", m)
  | BIF m -> ("BIF", m)
  | KHR m -> ("KHR", m)
  | CAD m -> ("CAD", m)
  | CVE m -> ("CVE", m)
  | KYD m -> ("KYD", m)
  | LKR m -> ("LKR", m)
  | CLP m -> ("CLP", m)
  | CNY m -> ("CNY", m)
  | COP m -> ("COP", m)
  | KMF m -> ("KMF", m)
  | CRC m -> ("CRC", m)
  | HRK m -> ("HRK", m)
  | CUP m -> ("CUP", m)
  | CZK m -> ("CZK", m)
  | DKK m -> ("DKK", m)
  | DOP m -> ("DOP", m)
  | SVC m -> ("SVC", m)
  | ETB m -> ("ETB", m)
  | ERN m -> ("ERN", m)
  | FKP m -> ("FKP", m)
  | FJD m -> ("FJD", m)
  | DJF m -> ("DJF", m)
  | GMD m -> ("GMD", m)
  | GIP m -> ("GIP", m)
  | GTQ m -> ("GTQ", m)
  | GNF m -> ("GNF", m)
  | GYD m -> ("GYD", m)
  | HTG m -> ("HTG", m)
  | HNL m -> ("HNL", m)
  | HKD m -> ("HKD", m)
  | HUF m -> ("HUF", m)
  | ISK m -> ("ISK", m)
  | INR m -> ("INR", m)
  | IDR m -> ("IDR", m)
  | IRR m -> ("IRR", m)
  | IQD m -> ("IQD", m)
  | ILS m -> ("ILS", m)
  | JMD m -> ("JMD", m)
  | JPY m -> ("JPY", m)
  | KZT m -> ("KZT", m)
  | JOD m -> ("JOD", m)
  | KES m -> ("KES", m)
  | KPW m -> ("KPW", m)
  | KRW m -> ("KRW", m)
  | KWD m -> ("KWD", m)
  | KGS m -> ("KGS", m)
  | LAK m -> ("LAK", m)
  | LBP m -> ("LBP", m)
  | LSL m -> ("LSL", m)
  | LRD m -> ("LRD", m)
  | LYD m -> ("LYD", m)
  | MOP m -> ("MOP", m)
  | MWK m -> ("MWK", m)
  | MYR m -> ("MYR", m)
  | MVR m -> ("MVR", m)
  | MUR m -> ("MUR", m)
  | MXN m -> ("MXN", m)
  | MNT m -> ("MNT", m)
  | MDL m -> ("MDL", m)
  | MAD m -> ("MAD", m)
  | OMR m -> ("OMR", m)
  | NAD m -> ("NAD", m)
  | NPR m -> ("NPR", m)
  | ANG m -> ("ANG", m)
  | AWG m -> ("AWG", m)
  | VUV m -> ("VUV", m)
  | NZD m -> ("NZD", m)
  | NIO m -> ("NIO", m)
  | NGN m -> ("NGN", m)
  | NOK m -> ("NOK", m)
  | PKR m -> ("PKR", m)
  | PAB m -> ("PAB", m)
  | PGK m -> ("PGK", m)
  | PYG m -> ("PYG", m)
  | PEN m -> ("PEN", m)
  | PHP m -> ("PHP", m)
  | QAR m -> ("QAR", m)
  | RUB m -> ("RUB", m)
  | RWF m -> ("RWF", m)
  | SHP m -> ("SHP", m)
  | SAR m -> ("SAR", m)
  | SCR m -> ("SCR", m)
  | SLL m -> ("SLL", m)
  | SGD m -> ("SGD", m)
  | VND m -> ("VND", m)
  | SOS m -> ("SOS", m)
  | ZAR m -> ("ZAR", m)
  | SSP m -> ("SSP", m)
  | SZL m -> ("SZL", m)
  | SEK m -> ("SEK", m)
  | CHF m -> ("CHF", m)
  | SYP m -> ("SYP", m)
  | THB m -> ("THB", m)
  | TOP m -> ("TOP", m)
  | TTD m -> ("TTD", m)
  | AED m -> ("AED", m)
  | TND m -> ("TND", m)
  | UGX m -> ("UGX", m)
  | MKD m -> ("MKD", m)
  | EGP m -> ("EGP", m)
  | GBP m -> ("GBP", m)
  | TZS m -> ("TZS", m)
  | USD m -> ("USD", m)
  | UYU m -> ("UYU", m)
  | UZS m -> ("UZS", m)
  | WST m -> ("WST", m)
  | YER m -> ("YER", m)
  | TWD m -> ("TWD", m)
  | UYW m -> ("UYW", m)
  | VES m -> ("VES", m)
  | MRU m -> ("MRU", m)
  | STN m -> ("STN", m)
  | CUC m -> ("CUC", m)
  | ZWL m -> ("ZWL", m)
  | BYN m -> ("BYN", m)
  | TMT m -> ("TMT", m)
  | GHS m -> ("GHS", m)
  | SDG m -> ("SDG", m)
  | UYI m -> ("UYI", m)
  | RSD m -> ("RSD", m)
  | MZN m -> ("MZN", m)
  | AZN m -> ("AZN", m)
  | RON m -> ("RON", m)
  | CHE m -> ("CHE", m)
  | CHW m -> ("CHW", m)
  | TRY m -> ("TRY", m)
  | XAF m -> ("XAF", m)
  | XCD m -> ("XCD", m)
  | XOF m -> ("XOF", m)
  | XPF m -> ("XPF", m)
  | XBA m -> ("XBA", m)
  | XBB m -> ("XBB", m)
  | XBC m -> ("XBC", m)
  | XBD m -> ("XBD", m)
  | XAU m -> ("XAU", m)
  | XDR m -> ("XDR", m)
  | XAG m -> ("XAG", m)
  | XPT m -> ("XPT", m)
  | XTS m -> ("XTS", m)
  | XPD m -> ("XPD", m)
  | XUA m -> ("XUA", m)
  | ZMW m -> ("ZMW", m)
  | SRD m -> ("SRD", m)
  | MGA m -> ("MGA", m)
  | COU m -> ("COU", m)
  | AFN m -> ("AFN", m)
  | TJS m -> ("TJS", m)
  | AOA m -> ("AOA", m)
  | BGN m -> ("BGN", m)
  | CDF m -> ("CDF", m)
  | BAM m -> ("BAM", m)
  | EUR m -> ("EUR", m)
  | MXV m -> ("MXV", m)
  | UAH m -> ("UAH", m)
  | GEL m -> ("GEL", m)
  | BOV m -> ("BOV", m)
  | PLN m -> ("PLN", m)
  | BRL m -> ("BRL", m)
  | CLF m -> ("CLF", m)
  | XSU m -> ("XSU", m)
  | USN m -> ("USN", m)
  | XXX m -> ("XXX", m)
  | None -> ("Non", 0.0)

let getTypeCurrency v = 
  match v with 
  | ("ALL", m) -> ALL m
  | ("DZD", m) -> DZD m
  | ("ARS", m) -> ARS m
  | ("AUD", m) -> AUD m
  | ("BSD", m) -> BSD m
  | ("BHD", m) -> BHD m
  | ("BDT", m) -> BDT m
  | ("AMD", m) -> AMD m
  | ("BBD", m) -> BBD m
  | ("BMD", m) -> BMD m
  | ("BTN", m) -> BTN m
  | ("BOB", m) -> BOB m
  | ("BWP", m) -> BWP m
  | ("BZD", m) -> BZD m
  | ("SBD", m) -> SBD m
  | ("BND", m) -> BND m
  | ("MMK", m) -> MMK m
  | ("BIF", m) -> BIF m
  | ("KHR", m) -> KHR m
  | ("CAD", m) -> CAD m
  | ("CVE", m) -> CVE m
  | ("KYD", m) -> KYD m
  | ("LKR", m) -> LKR m
  | ("CLP", m) -> CLP m
  | ("CNY", m) -> CNY m
  | ("COP", m) -> COP m
  | ("KMF", m) -> KMF m
  | ("CRC", m) -> CRC m
  | ("HRK", m) -> HRK m
  | ("CUP", m) -> CUP m
  | ("CZK", m) -> CZK m
  | ("DKK", m) -> DKK m
  | ("DOP", m) -> DOP m
  | ("SVC", m) -> SVC m
  | ("ETB", m) -> ETB m
  | ("ERN", m) -> ERN m
  | ("FKP", m) -> FKP m
  | ("FJD", m) -> FJD m
  | ("DJF", m) -> DJF m
  | ("GMD", m) -> GMD m
  | ("GIP", m) -> GIP m
  | ("GTQ", m) -> GTQ m
  | ("GNF", m) -> GNF m
  | ("GYD", m) -> GYD m
  | ("HTG", m) -> HTG m
  | ("HNL", m) -> HNL m
  | ("HKD", m) -> HKD m
  | ("HUF", m) -> HUF m
  | ("ISK", m) -> ISK m
  | ("INR", m) -> INR m
  | ("IDR", m) -> IDR m
  | ("IRR", m) -> IRR m
  | ("IQD", m) -> IQD m
  | ("ILS", m) -> ILS m
  | ("JMD", m) -> JMD m
  | ("JPY", m) -> JPY m
  | ("KZT", m) -> KZT m
  | ("JOD", m) -> JOD m
  | ("KES", m) -> KES m
  | ("KPW", m) -> KPW m
  | ("KRW", m) -> KRW m
  | ("KWD", m) -> KWD m
  | ("KGS", m) -> KGS m
  | ("LAK", m) -> LAK m
  | ("LBP", m) -> LBP m
  | ("LSL", m) -> LSL m
  | ("LRD", m) -> LRD m
  | ("LYD", m) -> LYD m
  | ("MOP", m) -> MOP m
  | ("MWK", m) -> MWK m
  | ("MYR", m) -> MYR m
  | ("MVR", m) -> MVR m
  | ("MUR", m) -> MUR m
  | ("MXN", m) -> MXN m
  | ("MNT", m) -> MNT m
  | ("MDL", m) -> MDL m
  | ("MAD", m) -> MAD m
  | ("OMR", m) -> OMR m
  | ("NAD", m) -> NAD m
  | ("NPR", m) -> NPR m
  | ("ANG", m) -> ANG m
  | ("AWG", m) -> AWG m
  | ("VUV", m) -> VUV m
  | ("NZD", m) -> NZD m
  | ("NIO", m) -> NIO m
  | ("NGN", m) -> NGN m
  | ("NOK", m) -> NOK m
  | ("PKR", m) -> PKR m
  | ("PAB", m) -> PAB m
  | ("PGK", m) -> PGK m
  | ("PYG", m) -> PYG m
  | ("PEN", m) -> PEN m
  | ("PHP", m) -> PHP m
  | ("QAR", m) -> QAR m
  | ("RUB", m) -> RUB m
  | ("RWF", m) -> RWF m
  | ("SHP", m) -> SHP m
  | ("SAR", m) -> SAR m
  | ("SCR", m) -> SCR m
  | ("SLL", m) -> SLL m
  | ("SGD", m) -> SGD m
  | ("VND", m) -> VND m
  | ("SOS", m) -> SOS m
  | ("ZAR", m) -> ZAR m
  | ("SSP", m) -> SSP m
  | ("SZL", m) -> SZL m
  | ("SEK", m) -> SEK m
  | ("CHF", m) -> CHF m
  | ("SYP", m) -> SYP m
  | ("THB", m) -> THB m
  | ("TOP", m) -> TOP m
  | ("TTD", m) -> TTD m
  | ("AED", m) -> AED m
  | ("TND", m) -> TND m
  | ("UGX", m) -> UGX m
  | ("MKD", m) -> MKD m
  | ("EGP", m) -> EGP m
  | ("GBP", m) -> GBP m
  | ("TZS", m) -> TZS m
  | ("USD", m) -> USD m
  | ("UYU", m) -> UYU m
  | ("UZS", m) -> UZS m
  | ("WST", m) -> WST m
  | ("YER", m) -> YER m
  | ("TWD", m) -> TWD m
  | ("UYW", m) -> UYW m
  | ("VES", m) -> VES m
  | ("MRU", m) -> MRU m
  | ("STN", m) -> STN m
  | ("CUC", m) -> CUC m
  | ("ZWL", m) -> ZWL m
  | ("BYN", m) -> BYN m
  | ("TMT", m) -> TMT m
  | ("GHS", m) -> GHS m
  | ("SDG", m) -> SDG m
  | ("UYI", m) -> UYI m
  | ("RSD", m) -> RSD m
  | ("MZN", m) -> MZN m
  | ("AZN", m) -> AZN m
  | ("RON", m) -> RON m
  | ("CHE", m) -> CHE m
  | ("CHW", m) -> CHW m
  | ("TRY", m) -> TRY m
  | ("XAF", m) -> XAF m
  | ("XCD", m) -> XCD m
  | ("XOF", m) -> XOF m
  | ("XPF", m) -> XPF m
  | ("XBA", m) -> XBA m
  | ("XBB", m) -> XBB m
  | ("XBC", m) -> XBC m
  | ("XBD", m) -> XBD m
  | ("XAU", m) -> XAU m
  | ("XDR", m) -> XDR m
  | ("XAG", m) -> XAG m
  | ("XPT", m) -> XPT m
  | ("XTS", m) -> XTS m
  | ("XPD", m) -> XPD m
  | ("XUA", m) -> XUA m
  | ("ZMW", m) -> ZMW m
  | ("SRD", m) -> SRD m
  | ("MGA", m) -> MGA m
  | ("COU", m) -> COU m
  | ("AFN", m) -> AFN m
  | ("TJS", m) -> TJS m
  | ("AOA", m) -> AOA m
  | ("BGN", m) -> BGN m
  | ("CDF", m) -> CDF m
  | ("BAM", m) -> BAM m
  | ("EUR", m) -> EUR m
  | ("MXV", m) -> MXV m
  | ("UAH", m) -> UAH m
  | ("GEL", m) -> GEL m
  | ("BOV", m) -> BOV m
  | ("PLN", m) -> PLN m
  | ("BRL", m) -> BRL m
  | ("CLF", m) -> CLF m
  | ("XSU", m) -> XSU m
  | ("USN", m) -> USN m
  | ("XXX", m) -> XXX m
  | ("Non", m) -> None
  | _ -> None