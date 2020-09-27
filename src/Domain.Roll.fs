module Irene.Domain.Roll

(* It wasn't easy to decide what data types should be used for argument passing.
   I have finally decided to only use primitive data types, mostly Ids. 
   The whole object can be found by the id and then called within the function. 
   As a rule, only primitive data (e.g. ids, dates) can be passed to function. *)

(*
let roll id =
    (* This function is the entry point of rolling order. 
       It only takes the rollId and do the rest of the jobs. *)
    let roll = getRollById id
    let dealIds = getDealsByDates roll.StartDate roll.EndDate
    let legIds = getLegIdsByDealIds dealIds

    legIds

*)