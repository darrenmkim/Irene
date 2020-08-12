module Irene.Mock

open System

let mock_rates = [ 
    (make_rate (None) (DateTime(2020,1,1)) (LIBOR) (1.5)) ; 
    (make_rate (None) (DateTime(2020,1,3)) (LIBOR) (1.5)) ; 
    (make_rate (None) (DateTime(2020,6,3)) (LIBOR) (1.5)) ; 
    (make_rate (None) (DateTime(2021,1,3)) (LIBOR) (1.5)) ; 
    (make_rate (None) (DateTime(2021,6,3)) (LIBOR) (1.5)) ; 
    (make_rate (None) (DateTime(2022,1,3)) (LIBOR) (1.5)) ; 
    (make_rate (None) (DateTime(2022,6,3)) (LIBOR) (1.5)) ; 
    (make_rate (None) (DateTime(2023,1,3)) (LIBOR) (1.5)) ; 
    (make_rate (None) (DateTime(2023,6,3)) (LIBOR) (1.5)) ; 
    (make_rate (None) (DateTime(2024,1,3)) (LIBOR) (1.5)) ; 
    (make_rate (None) (DateTime(2024,6,3)) (LIBOR) (1.5)) ; 
    (make_rate (None) (DateTime(2025,1,3)) (LIBOR) (1.5)) ;
    (make_rate (None) (DateTime(2025,6,3)) (LIBOR) (1.5)) ; 
    (make_rate (None) (DateTime(2026,1,3)) (LIBOR) (1.5)) ] 

let mock_pact_irsfix = (make_pact (Some 1) "IRSFIX" "Interest Rate Swap Fixed Leg") 
let mock_pact_irsflt = (make_pact (Some 2) "IRSFLT" "Interest Rate Swap Float Leg") 

(*
let mock_accounts = [
    (make_account None "Cash" IRSFIX Pay "12340000" "Cash clearing") ;
    (make_account None "Cash" IRSFIX Pay "12340000" "Cash clearing") ;
    (make_account None "Cash" IRSFIX Pay "12340000" "Cash clearing") ;
    (make_account None "Cash" IRSFIX Pay "12340000" "Cash clearing") ;
    (make_account None "Cash" IRSFIX Pay "12340000" "Cash clearing") ;
    (make_account None "Cash" IRSFIX Pay "12340000" "Cash clearing") ;
    (make_account None "Cash" IRSFIX Pay "12340000" "Cash clearing") ;
    (make_account None "Cash" IRSFIX Pay "12340000" "Cash clearing") ;
]
*)






let mock_leg_a = 
    (make_leg 
        (Some 11)
        mock_pact_irsfix
        (Payer)
        (USD)
        (SemiAnnually)
        (DC'AC360)
        (1000000.0)
        (Some 2.0))

let mock_leg_b = 
    (make_leg 
        (Some 12)
        mock_pact_irsflt
        (Receiver)
        (USD)
        (SemiAnnually)
        (DC'AC360)
        (1000000.0)
        (None))

let mock_deal = 
    (make_deal 
        (Some 4)
        ("IRS01")
        (IRS)
        [mock_leg_a ; mock_leg_b]
        (DateTime(2020,1,1))
        (DateTime(2020,1,3))
        (DateTime(2025,1,3))
        (None))

let mock_roll = 
    (make_roll 
        (Some 1) 
        (Calc) 
        (DateTime(2020,3,1))
        (DateTime(2020,7,31)))

let mock_sys_date = (DateTime(2020,3,3))