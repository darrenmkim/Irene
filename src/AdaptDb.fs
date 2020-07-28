module Irene.AdaptDb

open System
open System.Data.SQLite

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