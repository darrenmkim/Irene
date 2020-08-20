[<AutoOpen>]

module Irene.Port

open System
open System.Data.SQLite

open Irene.Mock

let dbName = "db.sqlite"
let connInfo = sprintf "Data Source=%s;Version=3;" dbName  
SQLiteConnection.CreateFile(dbName)

let conn = new SQLiteConnection(connInfo)
conn.Open()

let structureSql =
    "create table Trades (" +
    "Symbol varchar(20), " +
    "Timestamp datetime, " + 
    "Price float, " + 
    "TradeSize float)"

let structureCommand = new SQLiteCommand(structureSql, conn)
structureCommand.ExecuteNonQuery() |> ignore

let getDealsByDates startDate endDate =
    mockdeals
    |> lfilt (fun d 
                -> d.TradeDate > startDate 
                || d.MatureDate < endDate)
    |> lmap (fun d -> d.Id)

let getDealById id = 
    mockdeals |> lfind (fun d -> d.Id = id) 
    
let getLegById id =
    mocklegs |> lfind (fun l -> l.Id = id) 

let getLegIdsByDealIds dealIds =
    mocklegs
    |> lfilt (fun l -> lcont l.DealId dealIds) 
    |> lmap (fun l -> l.Id)

let getRollById id = 
    mockrolls |> lfind (fun r -> r.Id = id) 

let getFreqById id = 
    FREQS |> lfind (fun e -> e.Id = id) 