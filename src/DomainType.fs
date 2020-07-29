[<AutoOpen>]

module Irene.DomainType
open System

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

type DealClass = {
  Id : int
  Key : string
  Name : string }

type PayFreq = {
  Id : int
  Name : string
  NumMonths : int }

type LegType = {
  Id : int 
  Name : string }

type Leg = {
  Id : int
  Name : string
  LegTypeId : int
  DealId : int
  StanceId : int 
  CurrencyId : int 
  PayFreqId : int
  DayConvId : int
  Notional : float
  FixedRate : float option }
 
type DealType = {
  Id : int 
  Key : string 
  Name : string 
  DealClassId : int }
   
 type Deal = {
  Id : int
  Name : string 
  DealTypeId : int 
  TradeDate : DateTime
  EffectiveDate : DateTime
  MatureDate : DateTime
  TerminateDate : DateTime }

type RateInfo = {
  Id : int
  Name : string }

type Rate = {
  Id : int
  Date : DateTime
  RateInfoId : int
  Fraction : float }

type Tran = {
  Id : int
  Date : DateTime
  LegId : int
  ActId : int
  NumContracts : int
  Amount : float }