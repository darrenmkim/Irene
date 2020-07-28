[<AutoOpen>]

module DomainType

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