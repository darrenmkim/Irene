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
   