[<AutoOpen>]

module Irene.DomainStructure

let defaultAbilities = [
    { Id = 131 ; Level = "Admin" ; Desc = "Can edit on system and db level." }
    { Id = 231 ; Level = "Approver" ; Desc = "Can approve entries." }
    { Id = 331 ; Level = "Preparer" ; Desc = "Can create and book entries." }
    { Id = 431 ; Level = "Viewer" ; Desc = "Can view." } ]

let defaultActs = [
    { Id = 1 ; Key = "contract" }
    { Id = 2 ; Key = "effect" }
    { Id = 3 ; Key = "receive" }
    { Id = 4 ; Key = "pay" }
    { Id = 5 ; Key = "revalue" }
    { Id = 6 ; Key = "mature" }
    { Id = 7 ; Key = "terminate" } ]

let defaultStances = [
    { Id = 1 ; Key = "payer" }
    { Id = 2 ; Key = "receiver" }
    { Id = 3 ; Key = "buyer" }
    { Id = 4 ; Key = "seller" } ]