module Irene.Server

open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Hosting
open Irene.Config

let main _ =
    Host.CreateDefaultBuilder()
        .ConfigureWebHostDefaults(
            fun webHostBuilder ->
                webHostBuilder
                    .Configure(configureApp)
                    .ConfigureServices(configureServices)
                    |> ignore)
        .Build()
        .Run()
    // 0