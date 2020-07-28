[<AutoOpen>]

module Irene.DomainType

type Ability = { 
  Id : int
  Level : string
  Desc : string }

type Act = {
  Id : int
  Key : string }

type Stance = {
  Id : int
  Key : string }

type Chart = {
  Id : int
  Name : string
  Activity : string
  Account : int
  DocNumber : int }

type Currency = {
  Id : int
  Code : string
  Name : string }

type DayConv = {
  Id : int
  Name : string }

type DrvClass = {
  Id : int
  Key : string
  Name : string }