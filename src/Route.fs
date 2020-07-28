module Irene.Route

open Microsoft.AspNetCore.Http
open Giraffe

let router : HttpFunc -> HttpContext -> HttpFuncResult =
    choose [
        route "/ping"       >=> text "pong"
        route "/stances"    >=> json stances
        route "/abilities"  >=> json abilities
        route "/acts"       >=> json acts
        route "/dayconvs"   >=> json dayconvs
        route "/drvclasses" >=> json drvclasses
        route "/currencies" >=> json currencies
        route "/"           >=> text "hello darren" ]
