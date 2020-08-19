[<AutoOpen>]

module Irene.Func

// Aliases

let lfilt = List.filter
let lfind = List.find 
let lmap = List.map
let lcont = List.contains
let lsort = List.sort
let lfindex = List.findIndex
let asort = Array.sort
let afindex = Array.findIndex

// Helper

let findIndex lst elem = 
    lfindex (fun e -> e = elem) lst

let addMonths (date:Date) months = 
    date.AddMonths(months)