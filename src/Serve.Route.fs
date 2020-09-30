module Irene.Serve.Route

open Microsoft.AspNetCore.Http
open Giraffe

open Irene.Domain.Deal

let router : HttpFunc -> HttpContext -> HttpFuncResult =
    choose [
        route "/ping" >=> text "pong"
        route "/deal" >=> json sampleDeal
        //route "/rollkinds" >=> json roll_kinds
        route "/" >=> text "hello darren" ]
