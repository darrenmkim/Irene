module Irene.Route

open Microsoft.AspNetCore.Http
open Giraffe
open Irene.TranCash
open Irene.Mock

let router : HttpFunc -> HttpContext -> HttpFuncResult =
    choose [
        route "/ping"       >=> text "pong"
        // route "/stances"    >=> json valStance
        //route "/abilities"  >=> json abilities
        route "/payfreqs"     >=> json PayFreqVal
        //route "/events"       >=> json Event
        //route "/dayconvs"   >=> json DayConv
        //route "/drvclasses" >=> json dealclasses
        //route "/currencies" >=> json Currency
        route "/transample"   >=> json testing
        route "/"             >=> text "hello darren" ]
