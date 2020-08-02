module Irene.TranVal

open System
open Irene.Mock

(*
let getDateOnEndOfMonth (date:DateTime) =
    let d = DateTime(date.Year, date.Month+1, 1)
    d.AddDays(-1.0)

let rec tranIrsFixedInterestAccrual 
    (deal:Deal) (datePoint:DateTime) 
    =
    if (datePoint >= deal.MatureDate) then []
    else
        let newDatePoint = getDateOnEndOfMonth (datePoint.AddMonths(1))
        datePoint :: tranIrsFixedInterestAccrual deal newDatePoint 
    


let testing3 = 
    tranIrsFixedInterestAccrual testerdeal2 (DateTime(2020,3,1))
*)