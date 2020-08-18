module Irene.Route

open Microsoft.AspNetCore.Http
open Giraffe
open Irene.TranCash
open Irene.Mock

let router : HttpFunc -> HttpContext -> HttpFuncResult =
    choose [
        route "/ping" >=> text "pong"
        //route "/rollkinds" >=> json roll_kinds
        //route "/mock" >=> json trial_mock_a
        route "/" >=> text "hello darren" ]
