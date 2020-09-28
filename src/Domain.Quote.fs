[<AutoOpen>]

module Irene.Domain.Quote


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

(*
CREATE TYPE rate AS (
    code text,
    value numeric);
*)