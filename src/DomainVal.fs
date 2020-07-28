[<AutoOpen>]

module Irene.DomainVal

let abilities = [
    { Id = 131 ; Level = "Admin" ; Desc = "Can edit on system and db level." }
    { Id = 231 ; Level = "Approver" ; Desc = "Can approve entries." }
    { Id = 331 ; Level = "Preparer" ; Desc = "Can create and book entries." }
    { Id = 431 ; Level = "Viewer" ; Desc = "Can view." } ]

let acts : Act list = [
    { Id = 1 ; Key = "contract" }
    { Id = 2 ; Key = "effect" }
    { Id = 3 ; Key = "receive" }
    { Id = 4 ; Key = "pay" }
    { Id = 5 ; Key = "revalue" }
    { Id = 6 ; Key = "mature" }
    { Id = 7 ; Key = "terminate" } ]

let stances : Stance list = [
    { Id = 1 ; Key = "payer" }
    { Id = 2 ; Key = "receiver" }
    { Id = 3 ; Key = "buyer" }
    { Id = 4 ; Key = "seller" } ]

let dayconvs : DayConv list = [
    { Id = 1 ; Name = "30/360" }
    { Id = 2 ; Name = "AC/360" } ]

let payfreqs : PayFreq list = [
    { Id = 13 ; Name = "Continously" ; NumMonths = 0 }
    { Id = 23 ; Name = "Monthly" ; NumMonths = 1 }
    { Id = 33 ; Name = "Quarterly" ; NumMonths = 3 }
    { Id = 43 ; Name = "Semi-Annually" ; NumMonths = 6 }
    { Id = 53 ; Name = "Annually" ; NumMonths = 12 } ]

let dealclasses : DealClass list = [
    { Id = 1 ; Key = "swp" ; Name = "Swap" }
    { Id = 2 ; Key = "opt" ; Name = "Option" } ]

let dealtypes : DealType list = [
    { Id = 1135 ; Key = "ftr" ; Name = "Future" ; DealClassId = 2 }
    { Id = 1235 ; Key = "ftr" ; Name = "FX Forward" ; DealClassId = 2 }
    { Id = 1335 ; Key = "ftr" ; Name = "Future" ; DealClassId = 2 }
    { Id = 1435 ; Key = "ftr" ; Name = "Bond Forward" ; DealClassId = 2 }
    { Id = 1535 ; Key = "ftr" ; Name = "Total Return Swap" ; DealClassId = 2 }
    { Id = 1635 ; Key = "irs" ; Name = "Interest Rate Swap" ; DealClassId = 2 }
    { Id = 1735 ; Key = "ftr" ; Name = "Currency Swap" ; DealClassId = 2 }
    { Id = 1835 ; Key = "ftr" ; Name = "Call Option" ; DealClassId = 2 }
    { Id = 1935 ; Key = "ftr" ; Name = "Put Option" ; DealClassId = 2 }
    { Id = 2035 ; Key = "ftr" ; Name = "Corridor Option" ; DealClassId = 2 }
    { Id = 2135 ; Key = "ftr" ; Name = "Interest Rate Cap" ; DealClassId = 2 }
    { Id = 2235 ; Key = "ftr" ; Name = "Credit Default Swap" ; DealClassId = 2 }
    { Id = 2335 ; Key = "ftr" ; Name = "Foreign Currency Spot" ; DealClassId = 2 }
    { Id = 2435 ; Key = "ftr" ; Name = "Inflation Swap" ; DealClassId = 2 }
    { Id = 2535 ; Key = "ftr" ; Name = "Treasury Lock" ; DealClassId = 2 }
    { Id = 2635 ; Key = "ftr" ; Name = "Reverse Treasury Lock" ; DealClassId = 2 }
    { Id = 2735 ; Key = "ftr" ; Name = "Swaption" ; DealClassId = 2 }
    { Id = 2835 ; Key = "ftr" ; Name = "Commodity Swap" ; DealClassId = 2 } ]

let legtypes : LegType list = [
    { Id = 1 ; Name = "irs-fix" }
    { Id = 2 ; Name = "irs-float" } ]

let currencies : Currency list = [
    { Id = 8 ; Code = "ALL" ; Name = "Lek" }
    { Id = 12 ; Code = "DZD" ; Name = "Algerian Dinar" }
    { Id = 32 ; Code = "ARS" ; Name = "Argentine Peso" }
    { Id = 36 ; Code = "AUD" ; Name = "Australian Dollar" }
    { Id = 44 ; Code = "BSD" ; Name = "Bahamian Dollar" }
    { Id = 48 ; Code = "BHD" ; Name = "Bahraini Dinar" }
    { Id = 50 ; Code = "BDT" ; Name = "Taka" }
    { Id = 51 ; Code = "AMD" ; Name = "Armenian Dram" }
    { Id = 52 ; Code = "BBD" ; Name = "Barbados Dollar" }
    { Id = 60 ; Code = "BMD" ; Name = "Bermudian Dollar" }
    { Id = 64 ; Code = "BTN" ; Name = "Ngultrum" }
    { Id = 68 ; Code = "BOB" ; Name = "Boliviano" }
    { Id = 72 ; Code = "BWP" ; Name = "Pula" }
    { Id = 84 ; Code = "BZD" ; Name = "Belize Dollar" }
    { Id = 90 ; Code = "SBD" ; Name = "Solomon Islands Dollar" }
    { Id = 96 ; Code = "BND" ; Name = "Brunei Dollar" }
    { Id = 104 ; Code = "MMK" ; Name = "Kyat" }
    { Id = 108 ; Code = "BIF" ; Name = "Burundi Franc" }
    { Id = 116 ; Code = "KHR" ; Name = "Riel" }
    { Id = 124 ; Code = "CAD" ; Name = "Canadian Dollar" }
    { Id = 132 ; Code = "CVE" ; Name = "Cabo Verde Escudo" }
    { Id = 136 ; Code = "KYD" ; Name = "Cayman Islands Dollar" }
    { Id = 144 ; Code = "LKR" ; Name = "Sri Lanka Rupee" }
    { Id = 152 ; Code = "CLP" ; Name = "Chilean Peso" }
    { Id = 156 ; Code = "CNY" ; Name = "Yuan Renminbi" }
    { Id = 170 ; Code = "COP" ; Name = "Colombian Peso" }
    { Id = 174 ; Code = "KMF" ; Name = "Comorian Franc " }
    { Id = 188 ; Code = "CRC" ; Name = "Costa Rican Colon" }
    { Id = 191 ; Code = "HRK" ; Name = "Kuna" }
    { Id = 192 ; Code = "CUP" ; Name = "Cuban Peso" }
    { Id = 203 ; Code = "CZK" ; Name = "Czech Koruna" }
    { Id = 208 ; Code = "DKK" ; Name = "Danish Krone" }
    { Id = 214 ; Code = "DOP" ; Name = "Dominican Peso" }
    { Id = 222 ; Code = "SVC" ; Name = "El Salvador Colon" }
    { Id = 230 ; Code = "ETB" ; Name = "Ethiopian Birr" }
    { Id = 232 ; Code = "ERN" ; Name = "Nakfa" }
    { Id = 238 ; Code = "FKP" ; Name = "Falkland Islands Pound" }
    { Id = 242 ; Code = "FJD" ; Name = "Fiji Dollar" }
    { Id = 262 ; Code = "DJF" ; Name = "Djibouti Franc" }
    { Id = 270 ; Code = "GMD" ; Name = "Dalasi" }
    { Id = 292 ; Code = "GIP" ; Name = "Gibraltar Pound" }
    { Id = 320 ; Code = "GTQ" ; Name = "Quetzal" }
    { Id = 324 ; Code = "GNF" ; Name = "Guinean Franc" }
    { Id = 328 ; Code = "GYD" ; Name = "Guyana Dollar" }
    { Id = 332 ; Code = "HTG" ; Name = "Gourde" }
    { Id = 340 ; Code = "HNL" ; Name = "Lempira" }
    { Id = 344 ; Code = "HKD" ; Name = "Hong Kong Dollar" }
    { Id = 348 ; Code = "HUF" ; Name = "Forint" }
    { Id = 352 ; Code = "ISK" ; Name = "Iceland Krona" }
    { Id = 356 ; Code = "INR" ; Name = "Indian Rupee" }
    { Id = 360 ; Code = "IDR" ; Name = "Rupiah" }
    { Id = 364 ; Code = "IRR" ; Name = "Iranian Rial" }
    { Id = 368 ; Code = "IQD" ; Name = "Iraqi Dinar" }
    { Id = 376 ; Code = "ILS" ; Name = "New Israeli Sheqel" }
    { Id = 388 ; Code = "JMD" ; Name = "Jamaican Dollar" }
    { Id = 392 ; Code = "JPY" ; Name = "Yen" }
    { Id = 398 ; Code = "KZT" ; Name = "Tenge" }
    { Id = 400 ; Code = "JOD" ; Name = "Jordanian Dinar" }
    { Id = 404 ; Code = "KES" ; Name = "Kenyan Shilling" }
    { Id = 408 ; Code = "KPW" ; Name = "North Korean Won" }
    { Id = 410 ; Code = "KRW" ; Name = "Won" }
    { Id = 414 ; Code = "KWD" ; Name = "Kuwaiti Dinar" }
    { Id = 417 ; Code = "KGS" ; Name = "Som" }
    { Id = 418 ; Code = "LAK" ; Name = "Lao Kip" }
    { Id = 422 ; Code = "LBP" ; Name = "Lebanese Pound" }
    { Id = 426 ; Code = "LSL" ; Name = "Loti" }
    { Id = 430 ; Code = "LRD" ; Name = "Liberian Dollar" }
    { Id = 434 ; Code = "LYD" ; Name = "Libyan Dinar" }
    { Id = 446 ; Code = "MOP" ; Name = "Pataca" }
    { Id = 454 ; Code = "MWK" ; Name = "Malawi Kwacha" }
    { Id = 458 ; Code = "MYR" ; Name = "Malaysian Ringgit" }
    { Id = 462 ; Code = "MVR" ; Name = "Rufiyaa" }
    { Id = 480 ; Code = "MUR" ; Name = "Mauritius Rupee" }
    { Id = 484 ; Code = "MXN" ; Name = "Mexican Peso" }
    { Id = 496 ; Code = "MNT" ; Name = "Tugrik" }
    { Id = 498 ; Code = "MDL" ; Name = "Moldovan Leu" }
    { Id = 504 ; Code = "MAD" ; Name = "Moroccan Dirham" }
    { Id = 512 ; Code = "OMR" ; Name = "Rial Omani" }
    { Id = 516 ; Code = "NAD" ; Name = "Namibia Dollar" }
    { Id = 524 ; Code = "NPR" ; Name = "Nepalese Rupee" }
    { Id = 532 ; Code = "ANG" ; Name = "Netherlands Antillean Guilder" }
    { Id = 533 ; Code = "AWG" ; Name = "Aruban Florin" }
    { Id = 548 ; Code = "VUV" ; Name = "Vatu" }
    { Id = 554 ; Code = "NZD" ; Name = "New Zealand Dollar" }
    { Id = 558 ; Code = "NIO" ; Name = "Cordoba Oro" }
    { Id = 566 ; Code = "NGN" ; Name = "Naira" }
    { Id = 578 ; Code = "NOK" ; Name = "Norwegian Krone" }
    { Id = 586 ; Code = "PKR" ; Name = "Pakistan Rupee" }
    { Id = 590 ; Code = "PAB" ; Name = "Balboa" }
    { Id = 598 ; Code = "PGK" ; Name = "Kina" }
    { Id = 600 ; Code = "PYG" ; Name = "Guarani" }
    { Id = 604 ; Code = "PEN" ; Name = "Sol" }
    { Id = 608 ; Code = "PHP" ; Name = "Philippine Peso" }
    { Id = 634 ; Code = "QAR" ; Name = "Qatari Rial" }
    { Id = 643 ; Code = "RUB" ; Name = "Russian Ruble" }
    { Id = 646 ; Code = "RWF" ; Name = "Rwanda Franc" }
    { Id = 654 ; Code = "SHP" ; Name = "Saint Helena Pound" }
    { Id = 682 ; Code = "SAR" ; Name = "Saudi Riyal" }
    { Id = 690 ; Code = "SCR" ; Name = "Seychelles Rupee" }
    { Id = 694 ; Code = "SLL" ; Name = "Leone" }
    { Id = 702 ; Code = "SGD" ; Name = "Singapore Dollar" }
    { Id = 704 ; Code = "VND" ; Name = "Dong" }
    { Id = 706 ; Code = "SOS" ; Name = "Somali Shilling" }
    { Id = 710 ; Code = "ZAR" ; Name = "Rand" }
    { Id = 728 ; Code = "SSP" ; Name = "South Sudanese Pound" }
    { Id = 748 ; Code = "SZL" ; Name = "Lilangeni" }
    { Id = 752 ; Code = "SEK" ; Name = "Swedish Krona" }
    { Id = 756 ; Code = "CHF" ; Name = "Swiss Franc" }
    { Id = 760 ; Code = "SYP" ; Name = "Syrian Pound" }
    { Id = 764 ; Code = "THB" ; Name = "Baht" }
    { Id = 776 ; Code = "TOP" ; Name = "Pa’anga" }
    { Id = 780 ; Code = "TTD" ; Name = "Trinidad and Tobago Dollar" }
    { Id = 784 ; Code = "AED" ; Name = "UAE Dirham" }
    { Id = 788 ; Code = "TND" ; Name = "Tunisian Dinar" }
    { Id = 800 ; Code = "UGX" ; Name = "Uganda Shilling" }
    { Id = 807 ; Code = "MKD" ; Name = "Denar" }
    { Id = 818 ; Code = "EGP" ; Name = "Egyptian Pound" }
    { Id = 826 ; Code = "GBP" ; Name = "Pound Sterling" }
    { Id = 834 ; Code = "TZS" ; Name = "Tanzanian Shilling" }
    { Id = 840 ; Code = "USD" ; Name = "US Dollar" }
    { Id = 858 ; Code = "UYU" ; Name = "Peso Uruguayo" }
    { Id = 860 ; Code = "UZS" ; Name = "Uzbekistan Sum" }
    { Id = 882 ; Code = "WST" ; Name = "Tala" }
    { Id = 886 ; Code = "YER" ; Name = "Yemeni Rial" }
    { Id = 901 ; Code = "TWD" ; Name = "New Taiwan Dollar" }
    { Id = 927 ; Code = "UYW" ; Name = "Unidad Previsional" }
    { Id = 928 ; Code = "VES" ; Name = "Bolívar Soberano" }
    { Id = 929 ; Code = "MRU" ; Name = "Ouguiya" }
    { Id = 930 ; Code = "STN" ; Name = "Dobra" }
    { Id = 931 ; Code = "CUC" ; Name = "Peso Convertible" }
    { Id = 932 ; Code = "ZWL" ; Name = "Zimbabwe Dollar" }
    { Id = 933 ; Code = "BYN" ; Name = "Belarusian Ruble" }
    { Id = 934 ; Code = "TMT" ; Name = "Turkmenistan New Manat" }
    { Id = 936 ; Code = "GHS" ; Name = "Ghana Cedi" }
    { Id = 938 ; Code = "SDG" ; Name = "Sudanese Pound" }
    { Id = 940 ; Code = "UYI" ; Name = "Uruguay Peso en Unidades Indexadas (UI)" }
    { Id = 941 ; Code = "RSD" ; Name = "Serbian Dinar" }
    { Id = 943 ; Code = "MZN" ; Name = "Mozambique Metical" }
    { Id = 944 ; Code = "AZN" ; Name = "Azerbaijan Manat" }
    { Id = 946 ; Code = "RON" ; Name = "Romanian Leu" }
    { Id = 947 ; Code = "CHE" ; Name = "WIR Euro" }
    { Id = 948 ; Code = "CHW" ; Name = "WIR Franc" }
    { Id = 949 ; Code = "TRY" ; Name = "Turkish Lira" }
    { Id = 950 ; Code = "XAF" ; Name = "CFA Franc BEAC" }
    { Id = 951 ; Code = "XCD" ; Name = "East Caribbean Dollar" }
    { Id = 952 ; Code = "XOF" ; Name = "CFA Franc BCEAO" }
    { Id = 953 ; Code = "XPF" ; Name = "CFP Franc" }
    { Id = 955 ; Code = "XBA" ; Name = "Bond Markets Unit European Composite Unit (EURCO)" }
    { Id = 956 ; Code = "XBB" ; Name = "Bond Markets Unit European Monetary Unit (E.M.U.-6)" }
    { Id = 957 ; Code = "XBC" ; Name = "Bond Markets Unit European Unit of Account 9 (E.U.A.-9)" }
    { Id = 958 ; Code = "XBD" ; Name = "Bond Markets Unit European Unit of Account 17 (E.U.A.-17)" }
    { Id = 959 ; Code = "XAU" ; Name = "Gold" }
    { Id = 960 ; Code = "XDR" ; Name = "SDR (Special Drawing Right)" }
    { Id = 961 ; Code = "XAG" ; Name = "Silver" }
    { Id = 962 ; Code = "XPT" ; Name = "Platinum" }
    { Id = 963 ; Code = "XTS" ; Name = "Codes specifically reserved for testing purposes" }
    { Id = 964 ; Code = "XPD" ; Name = "Palladium" }
    { Id = 965 ; Code = "XUA" ; Name = "ADB Unit of Account" }
    { Id = 967 ; Code = "ZMW" ; Name = "Zambian Kwacha" }
    { Id = 968 ; Code = "SRD" ; Name = "Surinam Dollar" }
    { Id = 969 ; Code = "MGA" ; Name = "Malagasy Ariary" }
    { Id = 970 ; Code = "COU" ; Name = "Unidad de Valor Real" }
    { Id = 971 ; Code = "AFN" ; Name = "Afghani" }
    { Id = 972 ; Code = "TJS" ; Name = "Somoni" }
    { Id = 973 ; Code = "AOA" ; Name = "Kwanza" }
    { Id = 975 ; Code = "BGN" ; Name = "Bulgarian Lev" }
    { Id = 976 ; Code = "CDF" ; Name = "Congolese Franc" }
    { Id = 977 ; Code = "BAM" ; Name = "Convertible Mark" }
    { Id = 978 ; Code = "EUR" ; Name = "Euro" }
    { Id = 979 ; Code = "MXV" ; Name = "Mexican Unidad de Inversion (UDI)" }
    { Id = 980 ; Code = "UAH" ; Name = "Hryvnia" }
    { Id = 981 ; Code = "GEL" ; Name = "Lari" }
    { Id = 984 ; Code = "BOV" ; Name = "Mvdol" }
    { Id = 985 ; Code = "PLN" ; Name = "Zloty" }
    { Id = 986 ; Code = "BRL" ; Name = "Brazilian Real" }
    { Id = 990 ; Code = "CLF" ; Name = "Unidad de Fomento" }
    { Id = 994 ; Code = "XSU" ; Name = "Sucre" }
    { Id = 997 ; Code = "USN" ; Name = "US Dollar (Next day)" }
    { Id = 999 ; Code = "XXX" ; Name = "The codes assigned for transactions where no currency is involved" } ]