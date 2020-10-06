module Irene.Domain.Deal

open System
open Npgsql // #r "/home/drnmk/Documents/irene/bin/Debug/netcoreapp3.1/Npgsql.dll";; 

// Leg

let legSql = 
  "create table if not exists " +
  "Leg (" +
  "Id serial primary key, " +
  "Name text not null, " + 
  "Pact text not null, " +  
  "Stance text not null, " +
  "Period text not null, " +
  "Span text not null, " +
  "Day text not null, " +
  "ContractNum int not null, " +
  "Notional int not null, " +
  "FixedQuote int not null, " +
  "MovingQuote int not null, " +
  "Memo text) " 

let sampleDeal : DealIn = 
  { Id = 1u
  ; Name = "sampleDeal"
  ; Breed = Breed.IRS
  ; Strategy = Strategy.FVHIRS
  ; TradeDate = DateTime(2011, 1, 1)
  ; EffectDate = DateTime(2011, 1, 3)
  ; MatureDate = DateTime(2020, 1, 3)
  ; TerminateDate = DateTime(2020, 1, 3)
  ; Leg = [{ Id = 1u
            ; Name = "my leg 1"
            ; Pact = Pact.IRSFIX
            ; Stance = Stance.Pay
            ; Period = 10us
            ; Span = Span.Annual
            ; Day = Day.D30360
            ; ContractNum = 1uy
            ; Notional = { Currency = Currency.EUR 
                         ; Number = 1000000.0 }
            ; FixedQuote = { Ticker = Ticker.Libor1Y
                           ; Number = 0.023 }
            ; MovingTicker = Ticker.None 
            ; Memo = "my memo" } ; 
            { Id = 2u
            ; Name = "my leg 2"
            ; Pact = Pact.IRSFLT
            ; Stance = Stance.Receive
            ; Period = 10us
            ; Span = Span.Annual
            ; Day = Day.D30360
            ; ContractNum = 1uy
            ; Notional = { Currency = Currency.EUR 
                         ; Number = 1000000.0 }
            ; FixedQuote = { Ticker = Ticker.Euribor1Y 
                           ; Number = 0.023 }
            ; MovingTicker = Ticker.None
            ; Memo = "my memo" }]
  ; Active = true
  ; Memo = "abc"}




type Meat = 
  | Chicken 
  | Beef 
type Fruit = 
  | Apple
  | Orange 
type Lunch = 
  { Meat : Meat 
  ; Fruit : Fruit }

let mine = 
  { Meat = Meat.Chicken
  ; Fruit = Fruit.Orange }

let sql 
  = "create table if not exists " 
  + "lunch (" 
  + "id serial primary key, " 
  + "meat text, "
  + "fruit text)"

