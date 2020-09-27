module Irene.Server.Route

open Microsoft.AspNetCore.Http
open Giraffe

let router : HttpFunc -> HttpContext -> HttpFuncResult =
    choose [
        route "/ping" >=> text "pong"
        //route "/rollkinds" >=> json roll_kinds
        route "/" >=> text "hello darren" ]
