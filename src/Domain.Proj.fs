module Irene.Domain.Proj


// Roll 



// Proj

type Proj = 
  | Contract of tradeDate : Date * notionalLocal : Money * numContract : Count 
  | Effect of feeRate : Rate * notionalLocal : Money * numContract : Count 
  | Interest  
  | Accrue 
  | Valuate 
  | Reduce of feeRate : Rate option
  | Terminate of feeRate: Rate option 
  | Mature 



(*
CREATE TYPE currency AS (
    code text,
    value decimal(20,2));
*)


// Tran 



// Journal
