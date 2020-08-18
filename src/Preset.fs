module Irene.Preset

let ABILITY = [
    { Id = 1 ; Code = "Administrator" ; Memo = "Administrator" } ;
    { Id = 2 ; Code = "Approver" ; Memo = "Approver" } ; 
    { Id = 3 ; Code = "Preparer" ; Memo = "Preparer" } ;
    { Id = 4 ; Code = "Viewer" ; Memo = "Viewer" } ]

let BREED = [
    { Id = 1 ; Code = "IRS" ; Memo = "Fixed Leg of Interest Rate Swap" } ;
    { Id = 2 ; Code = "CRS" ; Memo = "Float Leg of Interest Rate Swap" } ;
    { Id = 3 ; Code = "FTR" ; Memo = "Float Leg of Interest Rate Swap" } ]

(*
let dealtypes : DealType list = [
    { Id = 1135 ; Key = "ftr" ; Memo = "Future" ; DealClassId = 2 }
    { Id = 1235 ; Key = "ftr" ; Memo = "FX Forward" ; DealClassId = 2 }
    { Id = 1335 ; Key = "ftr" ; Memo = "Future" ; DealClassId = 2 }
    { Id = 1435 ; Key = "ftr" ; Memo = "Bond Forward" ; DealClassId = 2 }
    { Id = 1535 ; Key = "ftr" ; Memo = "Total Return Swap" ; DealClassId = 2 }
    { Id = 1635 ; Key = "irs" ; Memo = "Interest Rate Swap" ; DealClassId = 2 }
    { Id = 1735 ; Key = "ftr" ; Memo = "Currency Swap" ; DealClassId = 2 }
    { Id = 1835 ; Key = "ftr" ; Memo = "Call Option" ; DealClassId = 2 }
    { Id = 1935 ; Key = "ftr" ; Memo = "Put Option" ; DealClassId = 2 }
    { Id = 2035 ; Key = "ftr" ; Memo = "Corridor Option" ; DealClassId = 2 }
    { Id = 2135 ; Key = "ftr" ; Memo = "Interest Rate Cap" ; DealClassId = 2 }
    { Id = 2235 ; Key = "ftr" ; Memo = "Credit Default Swap" ; DealClassId = 2 }
    { Id = 2335 ; Key = "ftr" ; Memo = "Foreign Currency Spot" ; DealClassId = 2 }
    { Id = 2435 ; Key = "ftr" ; Memo = "Inflation Swap" ; DealClassId = 2 }
    { Id = 2535 ; Key = "ftr" ; Memo = "Treasury Lock" ; DealClassId = 2 }
    { Id = 2635 ; Key = "ftr" ; Memo = "Reverse Treasury Lock" ; DealClassId = 2 }
    { Id = 2735 ; Key = "ftr" ; Memo = "Swaption" ; DealClassId = 2 }
    { Id = 2835 ; Key = "ftr" ; Memo = "Commodity Swap" ; DealClassId = 2 } ]
*)

let PACT = [
    { Id = 1 ; Code = "IRSFIX" ; Memo = "Fixed Leg of Interest Rate Swap" } ;
    { Id = 2 ; Code = "IRSFLT" ; Memo = "Float Leg of Interest Rate Swap" } ]

let STANCE = [
    { Id = 1 ; Code = "PAYER" ; Memo = "Payer Position of Swap" } ;
    { Id = 2 ; Code = "RECEIVER" ; Memo = "Receiver Position of Swap" } ; 
    { Id = 3 ; Code = "BUYER" ; Memo = "Buyer Position of Option" } ;
    { Id = 4 ; Code = "SELLER" ; Memo = "Seller Position of Option" } ]

let ORDER = [
    { Id = 1 ; Code = "Calc" ; Memo = ".." } ;
    { Id = 2 ; Code = "Post" ; Memo = ".." } ;
    { Id = 3 ; Code = "Revert" ; Memo = ".." } ]

let FREQUENCY = [
    { Id = 1 ; Code = "CONTINUOUSLY" ; Memo = ".." } ;
    { Id = 2 ; Code = "MONTHLY" ; Memo = ".." } ;
    { Id = 3 ; Code = "QUARTERLY" ; Memo = ".." } ; 
    { Id = 4 ; Code = "SEMIANNUALLY" ; Memo = ".." } ;
    { Id = 5 ; Code = "ANNUALLY" ; Memo = ".." } ; 
    { Id = 6 ; Code = "BIANNUALLY" ; Memo = ".." } ]

let EVENT = [
    { Id = 1 ; Code = "CONTRACT" ; Memo = ".." } ;
    { Id = 2 ; Code = "EFFECT" ; Memo = ".." } ;
    { Id = 3 ; Code = "RECEIVE" ; Memo = ".." } ; 
    { Id = 4 ; Code = "PAY" ; Memo = ".." } ;
    { Id = 5 ; Code = "ACCRUE" ; Memo = ".." } ; 
    { Id = 6 ; Code = "VALUATE" ; Memo = ".." } ; 
    { Id = 7 ; Code = "TERMINATE" ; Memo = ".." } ; 
    { Id = 8 ; Code = "MATURE" ; Memo = ".." } ]

let DAYCONV = [
    { Id = 1 ; Code = "30360" ; Memo = ".." } ;
    { Id = 2 ; Code = "AC360" ; Memo = ".." } ;
    { Id = 3 ; Code = ".." ; Memo = ".." } ; 
    { Id = 4 ; Code = ".." ; Memo = ".." } ;
    { Id = 5 ; Code = ".." ; Memo = ".." } ; 
    { Id = 6 ; Code = ".." ; Memo = ".." } ; 
    { Id = 7 ; Code = ".." ; Memo = ".." } ; 
    { Id = 8 ; Code = ".." ; Memo = ".." } ]

let RATECODE = [
    { Id = 1 ; Code = "3ML" ; Memo = "3 months LIBOR" } ;
    { Id = 2 ; Code = "EURIBOR" ; Memo = ".." } ;
    { Id = 3 ; Code = ".." ; Memo = ".." } ]

let DIRECTION = [
    { Id = 1 ; Code = "PLUS" ; Memo = "To add or expand." } ;
    { Id = 2 ; Code = "MINUS" ; Memo = "To subtract or shrink." } ]

let CURRENCY = [
    { Id = 8 ; Code = "ALL" ; Memo = "Lek" }
    { Id = 12 ; Code = "DZD" ; Memo = "Algerian Dinar" }
    { Id = 32 ; Code = "ARS" ; Memo = "Argentine Peso" }
    { Id = 36 ; Code = "AUD" ; Memo = "Australian Dollar" }
    { Id = 44 ; Code = "BSD" ; Memo = "Bahamian Dollar" }
    { Id = 48 ; Code = "BHD" ; Memo = "Bahraini Dinar" }
    { Id = 50 ; Code = "BDT" ; Memo = "Taka" }
    { Id = 51 ; Code = "AMD" ; Memo = "Armenian Dram" }
    { Id = 52 ; Code = "BBD" ; Memo = "Barbados Dollar" }
    { Id = 60 ; Code = "BMD" ; Memo = "Bermudian Dollar" }
    { Id = 64 ; Code = "BTN" ; Memo = "Ngultrum" }
    { Id = 68 ; Code = "BOB" ; Memo = "Boliviano" }
    { Id = 72 ; Code = "BWP" ; Memo = "Pula" }
    { Id = 84 ; Code = "BZD" ; Memo = "Belize Dollar" }
    { Id = 90 ; Code = "SBD" ; Memo = "Solomon Islands Dollar" }
    { Id = 96 ; Code = "BND" ; Memo = "Brunei Dollar" }
    { Id = 104 ; Code = "MMK" ; Memo = "Kyat" }
    { Id = 108 ; Code = "BIF" ; Memo = "Burundi Franc" }
    { Id = 116 ; Code = "KHR" ; Memo = "Riel" }
    { Id = 124 ; Code = "CAD" ; Memo = "Canadian Dollar" }
    { Id = 132 ; Code = "CVE" ; Memo = "Cabo Verde Escudo" }
    { Id = 136 ; Code = "KYD" ; Memo = "Cayman Islands Dollar" }
    { Id = 144 ; Code = "LKR" ; Memo = "Sri Lanka Rupee" }
    { Id = 152 ; Code = "CLP" ; Memo = "Chilean Peso" }
    { Id = 156 ; Code = "CNY" ; Memo = "Yuan Renminbi" }
    { Id = 170 ; Code = "COP" ; Memo = "Colombian Peso" }
    { Id = 174 ; Code = "KMF" ; Memo = "Comorian Franc " }
    { Id = 188 ; Code = "CRC" ; Memo = "Costa Rican Colon" }
    { Id = 191 ; Code = "HRK" ; Memo = "Kuna" }
    { Id = 192 ; Code = "CUP" ; Memo = "Cuban Peso" }
    { Id = 203 ; Code = "CZK" ; Memo = "Czech Koruna" }
    { Id = 208 ; Code = "DKK" ; Memo = "Danish Krone" }
    { Id = 214 ; Code = "DOP" ; Memo = "Dominican Peso" }
    { Id = 222 ; Code = "SVC" ; Memo = "El Salvador Colon" }
    { Id = 230 ; Code = "ETB" ; Memo = "Ethiopian Birr" }
    { Id = 232 ; Code = "ERN" ; Memo = "Nakfa" }
    { Id = 238 ; Code = "FKP" ; Memo = "Falkland Islands Pound" }
    { Id = 242 ; Code = "FJD" ; Memo = "Fiji Dollar" }
    { Id = 262 ; Code = "DJF" ; Memo = "Djibouti Franc" }
    { Id = 270 ; Code = "GMD" ; Memo = "Dalasi" }
    { Id = 292 ; Code = "GIP" ; Memo = "Gibraltar Pound" }
    { Id = 320 ; Code = "GTQ" ; Memo = "Quetzal" }
    { Id = 324 ; Code = "GNF" ; Memo = "Guinean Franc" }
    { Id = 328 ; Code = "GYD" ; Memo = "Guyana Dollar" }
    { Id = 332 ; Code = "HTG" ; Memo = "Gourde" }
    { Id = 340 ; Code = "HNL" ; Memo = "Lempira" }
    { Id = 344 ; Code = "HKD" ; Memo = "Hong Kong Dollar" }
    { Id = 348 ; Code = "HUF" ; Memo = "Forint" }
    { Id = 352 ; Code = "ISK" ; Memo = "Iceland Krona" }
    { Id = 356 ; Code = "INR" ; Memo = "Indian Rupee" }
    { Id = 360 ; Code = "IDR" ; Memo = "Rupiah" }
    { Id = 364 ; Code = "IRR" ; Memo = "Iranian Rial" }
    { Id = 368 ; Code = "IQD" ; Memo = "Iraqi Dinar" }
    { Id = 376 ; Code = "ILS" ; Memo = "New Israeli Sheqel" }
    { Id = 388 ; Code = "JMD" ; Memo = "Jamaican Dollar" }
    { Id = 392 ; Code = "JPY" ; Memo = "Yen" }
    { Id = 398 ; Code = "KZT" ; Memo = "Tenge" }
    { Id = 400 ; Code = "JOD" ; Memo = "Jordanian Dinar" }
    { Id = 404 ; Code = "KES" ; Memo = "Kenyan Shilling" }
    { Id = 408 ; Code = "KPW" ; Memo = "North Korean Won" }
    { Id = 410 ; Code = "KRW" ; Memo = "Won" }
    { Id = 414 ; Code = "KWD" ; Memo = "Kuwaiti Dinar" }
    { Id = 417 ; Code = "KGS" ; Memo = "Som" }
    { Id = 418 ; Code = "LAK" ; Memo = "Lao Kip" }
    { Id = 422 ; Code = "LBP" ; Memo = "Lebanese Pound" }
    { Id = 426 ; Code = "LSL" ; Memo = "Loti" }
    { Id = 430 ; Code = "LRD" ; Memo = "Liberian Dollar" }
    { Id = 434 ; Code = "LYD" ; Memo = "Libyan Dinar" }
    { Id = 446 ; Code = "MOP" ; Memo = "Pataca" }
    { Id = 454 ; Code = "MWK" ; Memo = "Malawi Kwacha" }
    { Id = 458 ; Code = "MYR" ; Memo = "Malaysian Ringgit" }
    { Id = 462 ; Code = "MVR" ; Memo = "Rufiyaa" }
    { Id = 480 ; Code = "MUR" ; Memo = "Mauritius Rupee" }
    { Id = 484 ; Code = "MXN" ; Memo = "Mexican Peso" }
    { Id = 496 ; Code = "MNT" ; Memo = "Tugrik" }
    { Id = 498 ; Code = "MDL" ; Memo = "Moldovan Leu" }
    { Id = 504 ; Code = "MAD" ; Memo = "Moroccan Dirham" }
    { Id = 512 ; Code = "OMR" ; Memo = "Rial Omani" }
    { Id = 516 ; Code = "NAD" ; Memo = "Namibia Dollar" }
    { Id = 524 ; Code = "NPR" ; Memo = "Nepalese Rupee" }
    { Id = 532 ; Code = "ANG" ; Memo = "Netherlands Antillean Guilder" }
    { Id = 533 ; Code = "AWG" ; Memo = "Aruban Florin" }
    { Id = 548 ; Code = "VUV" ; Memo = "Vatu" }
    { Id = 554 ; Code = "NZD" ; Memo = "New Zealand Dollar" }
    { Id = 558 ; Code = "NIO" ; Memo = "Cordoba Oro" }
    { Id = 566 ; Code = "NGN" ; Memo = "Naira" }
    { Id = 578 ; Code = "NOK" ; Memo = "Norwegian Krone" }
    { Id = 586 ; Code = "PKR" ; Memo = "Pakistan Rupee" }
    { Id = 590 ; Code = "PAB" ; Memo = "Balboa" }
    { Id = 598 ; Code = "PGK" ; Memo = "Kina" }
    { Id = 600 ; Code = "PYG" ; Memo = "Guarani" }
    { Id = 604 ; Code = "PEN" ; Memo = "Sol" }
    { Id = 608 ; Code = "PHP" ; Memo = "Philippine Peso" }
    { Id = 634 ; Code = "QAR" ; Memo = "Qatari Rial" }
    { Id = 643 ; Code = "RUB" ; Memo = "Russian Ruble" }
    { Id = 646 ; Code = "RWF" ; Memo = "Rwanda Franc" }
    { Id = 654 ; Code = "SHP" ; Memo = "Saint Helena Pound" }
    { Id = 682 ; Code = "SAR" ; Memo = "Saudi Riyal" }
    { Id = 690 ; Code = "SCR" ; Memo = "Seychelles Rupee" }
    { Id = 694 ; Code = "SLL" ; Memo = "Leone" }
    { Id = 702 ; Code = "SGD" ; Memo = "Singapore Dollar" }
    { Id = 704 ; Code = "VND" ; Memo = "Dong" }
    { Id = 706 ; Code = "SOS" ; Memo = "Somali Shilling" }
    { Id = 710 ; Code = "ZAR" ; Memo = "Rand" }
    { Id = 728 ; Code = "SSP" ; Memo = "South Sudanese Pound" }
    { Id = 748 ; Code = "SZL" ; Memo = "Lilangeni" }
    { Id = 752 ; Code = "SEK" ; Memo = "Swedish Krona" }
    { Id = 756 ; Code = "CHF" ; Memo = "Swiss Franc" }
    { Id = 760 ; Code = "SYP" ; Memo = "Syrian Pound" }
    { Id = 764 ; Code = "THB" ; Memo = "Baht" }
    { Id = 776 ; Code = "TOP" ; Memo = "Paâ€™anga" }
    { Id = 780 ; Code = "TTD" ; Memo = "Trinidad and Tobago Dollar" }
    { Id = 784 ; Code = "AED" ; Memo = "UAE Dirham" }
    { Id = 788 ; Code = "TND" ; Memo = "Tunisian Dinar" }
    { Id = 800 ; Code = "UGX" ; Memo = "Uganda Shilling" }
    { Id = 807 ; Code = "MKD" ; Memo = "Denar" }
    { Id = 818 ; Code = "EGP" ; Memo = "Egyptian Pound" }
    { Id = 826 ; Code = "GBP" ; Memo = "Pound Sterling" }
    { Id = 834 ; Code = "TZS" ; Memo = "Tanzanian Shilling" }
    { Id = 840 ; Code = "USD" ; Memo = "US Dollar" }
    { Id = 858 ; Code = "UYU" ; Memo = "Peso Uruguayo" }
    { Id = 860 ; Code = "UZS" ; Memo = "Uzbekistan Sum" }
    { Id = 882 ; Code = "WST" ; Memo = "Tala" }
    { Id = 886 ; Code = "YER" ; Memo = "Yemeni Rial" }
    { Id = 901 ; Code = "TWD" ; Memo = "New Taiwan Dollar" }
    { Id = 927 ; Code = "UYW" ; Memo = "Unidad Previsional" }
    { Id = 928 ; Code = "VES" ; Memo = "BolÃ­var Soberano" }
    { Id = 929 ; Code = "MRU" ; Memo = "Ouguiya" }
    { Id = 930 ; Code = "STN" ; Memo = "Dobra" }
    { Id = 931 ; Code = "CUC" ; Memo = "Peso Convertible" }
    { Id = 932 ; Code = "ZWL" ; Memo = "Zimbabwe Dollar" }
    { Id = 933 ; Code = "BYN" ; Memo = "Belarusian Ruble" }
    { Id = 934 ; Code = "TMT" ; Memo = "Turkmenistan New Manat" }
    { Id = 936 ; Code = "GHS" ; Memo = "Ghana Cedi" }
    { Id = 938 ; Code = "SDG" ; Memo = "Sudanese Pound" }
    { Id = 940 ; Code = "UYI" ; Memo = "Uruguay Peso en Unidades Indexadas (UI)" }
    { Id = 941 ; Code = "RSD" ; Memo = "Serbian Dinar" }
    { Id = 943 ; Code = "MZN" ; Memo = "Mozambique Metical" }
    { Id = 944 ; Code = "AZN" ; Memo = "Azerbaijan Manat" }
    { Id = 946 ; Code = "RON" ; Memo = "Romanian Leu" }
    { Id = 947 ; Code = "CHE" ; Memo = "WIR Euro" }
    { Id = 948 ; Code = "CHW" ; Memo = "WIR Franc" }
    { Id = 949 ; Code = "TRY" ; Memo = "Turkish Lira" }
    { Id = 950 ; Code = "XAF" ; Memo = "CFA Franc BEAC" }
    { Id = 951 ; Code = "XCD" ; Memo = "East Caribbean Dollar" }
    { Id = 952 ; Code = "XOF" ; Memo = "CFA Franc BCEAO" }
    { Id = 953 ; Code = "XPF" ; Memo = "CFP Franc" }
    { Id = 955 ; Code = "XBA" ; Memo = "Bond Markets Unit European Composite Unit (EURCO)" }
    { Id = 956 ; Code = "XBB" ; Memo = "Bond Markets Unit European Monetary Unit (E.M.U.-6)" }
    { Id = 957 ; Code = "XBC" ; Memo = "Bond Markets Unit European Unit of Account 9 (E.U.A.-9)" }
    { Id = 958 ; Code = "XBD" ; Memo = "Bond Markets Unit European Unit of Account 17 (E.U.A.-17)" }
    { Id = 959 ; Code = "XAU" ; Memo = "Gold" }
    { Id = 960 ; Code = "XDR" ; Memo = "SDR (Special Drawing Right)" }
    { Id = 961 ; Code = "XAG" ; Memo = "Silver" }
    { Id = 962 ; Code = "XPT" ; Memo = "Platinum" }
    { Id = 963 ; Code = "XTS" ; Memo = "Codes specifically reserved for testing purposes" }
    { Id = 964 ; Code = "XPD" ; Memo = "Palladium" }
    { Id = 965 ; Code = "XUA" ; Memo = "ADB Unit of Account" }
    { Id = 967 ; Code = "ZMW" ; Memo = "Zambian Kwacha" }
    { Id = 968 ; Code = "SRD" ; Memo = "Surinam Dollar" }
    { Id = 969 ; Code = "MGA" ; Memo = "Malagasy Ariary" }
    { Id = 970 ; Code = "COU" ; Memo = "Unidad de Valor Real" }
    { Id = 971 ; Code = "AFN" ; Memo = "Afghani" }
    { Id = 972 ; Code = "TJS" ; Memo = "Somoni" }
    { Id = 973 ; Code = "AOA" ; Memo = "Kwanza" }
    { Id = 975 ; Code = "BGN" ; Memo = "Bulgarian Lev" }
    { Id = 976 ; Code = "CDF" ; Memo = "Congolese Franc" }
    { Id = 977 ; Code = "BAM" ; Memo = "Convertible Mark" }
    { Id = 978 ; Code = "EUR" ; Memo = "Euro" }
    { Id = 979 ; Code = "MXV" ; Memo = "Mexican Unidad de Inversion (UDI)" }
    { Id = 980 ; Code = "UAH" ; Memo = "Hryvnia" }
    { Id = 981 ; Code = "GEL" ; Memo = "Lari" }
    { Id = 984 ; Code = "BOV" ; Memo = "Mvdol" }
    { Id = 985 ; Code = "PLN" ; Memo = "Zloty" }
    { Id = 986 ; Code = "BRL" ; Memo = "Brazilian Real" }
    { Id = 990 ; Code = "CLF" ; Memo = "Unidad de Fomento" }
    { Id = 994 ; Code = "XSU" ; Memo = "Sucre" }
    { Id = 997 ; Code = "USN" ; Memo = "US Dollar (Next day)" }
    { Id = 999 ; Code = "XXX" ; Memo = "The codes assigned for transactions where no currency is involved" } ]