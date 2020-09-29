[<AutoOpen>]

module Irene.Domain.Quote


open System
open System.Net
open FSharp.Data
open Thoth.Fetch // #r "/home/drnmk/Documents/irene/bin/Debug/netcoreapp3.1/Thoth.Fetch.dll";; 
open Thoth.Json // #r "/home/drnmk/Documents/irene/bin/Debug/netcoreapp3.1/Thoth.Json.dll";; 

open Fed.Fred
// #r "/home/drnmk/Documents/irene/bin/Debug/netcoreapp3.1/Fed.Fred.dll";; 


// Quote 

type Quote =
  | Fixed 
  | Libor1D of Rate  
  | Libor1W of Rate  
  | Libor2W of Rate   
  | Libor1M of Rate    
  | Libor2M of Rate  
  | Libor3M of Rate   
  | Libor6M of Rate   
  | Libor1Y of Rate   
  | Euribor1W of Rate   
  | Euribor2W of Rate   
  | Euribor1M of Rate   
  | Euribor2M of Rate   
  | Euribor3M of Rate   
  | Euribor6M of Rate  
  | Euribor9M of Rate   
  | Euribor1Y of Rate 
  | Nothing   

let getQuoteValueFromType (a : Quote) : (Name * Rate) =
  match a with 
  | Fixed -> ("Fixed", 0.0)
  | Libor1D r -> ("Libor1D", r) 
  | Libor1W r -> ("Libor1W", r) 
  | Libor2W r -> ("Libor2W", r)  
  | Libor1M r -> ("Libor1M", r)   
  | Libor2M r -> ("Libor2M", r) 
  | Libor3M r -> ("Libor3M", r) 
  | Libor6M r -> ("Libor6M", r) 
  | Libor1Y r -> ("Libor1Y", r) 
  | Euribor1W r -> ("Euribor1W", r) 
  | Euribor2W r -> ("Euribor2W", r) 
  | Euribor1M r -> ("Euribor1M", r) 
  | Euribor2M r -> ("Euribor2M", r)   
  | Euribor3M r -> ("Euribor3M", r)  
  | Euribor6M r -> ("Euribor6M", r) 
  | Euribor9M r -> ("Euribor9M", r) 
  | Euribor1Y r -> ("Euribor1Y", r) 
  | Nothing -> ("Nothing", 0.0)

let getQuoteTypeFromValue (value : (Name * Rate)) : Quote =
  match value with 
  | ("Fixed", r) -> Fixed
  | ("Libor1D", r) -> Libor1D r 
  | ("Libor1W", r) -> Libor1W r 
  | ("Libor2W", r) -> Libor2W r
  | ("Libor1M", r) -> Libor1M r
  | ("Libor2M", r) -> Libor2M r
  | ("Libor3M", r) -> Libor3M r 
  | ("Libor6M", r) -> Libor6M r
  | ("Libor1Y", r) -> Libor1Y r
  | ("Euribor1W", r) -> Euribor1W r
  | ("Euribor2W", r) -> Euribor2W r
  | ("Euribor1M", r) -> Euribor1M r
  | ("Euribor2M", r) -> Euribor2M r 
  | ("Euribor3M", r) -> Euribor3M r
  | ("Euribor6M", r) -> Euribor6M r 
  | ("Euribor9M", r) -> Euribor9M r
  | ("Euribor1Y", r) -> Euribor1Y r
  | ("Nothing", r) -> Nothing 
  | _ -> Nothing 






// monadss
let fredApiKey = "d9f839ac26eb80f8a42efe6e07c4e1a6"
let seriesApi = "https://api.stlouisfed.org/fred/series?series_id=GNPCA&api_key=" + fredApiKey
let sourceApi = "https://api.stlouisfed.org/fred/sources?api_key=" + fredApiKey

let fredSp500Api = "https://api.stlouisfed.org/fred/series/observations?series_id=GNPCA&api_key=" 
                 + fredApiKey 
                 + "&file_type=json"


let fred = Fred(fredApiKey)
let seriesObservation = fred.GetSeriesObservations( "SP500"
                                                  //, Limit = 10
                                                  , ObservationStart = "1/1/2020"
                                                 // , ObservationEnd = "6/30/2020"
                                                  )


// 

let sources = fred.GetSource
(*
CREATE TYPE rate AS (
    code text,
    value numeric);
*)


// var fred = new Fred("api key", RequestCacheLevel.BypassCache); //Default Option
// /home/drnmk/Documents/irene/bin/Debug/netcoreapp3.1/Dapper.FSharp.dll


let getBookById () =
  let url = fredSp500Api
  Fetch.get(url) // decoder = Book.Decoder
   