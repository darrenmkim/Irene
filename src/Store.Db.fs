module Irene.Store.Db 

(*  
get into postgres environment: 
$ sudo -u postgres psql 

create user: 
postgres=# create user admin with password '1324';

create database:
create database IreneDb owner admin;
*)

open Dapper.FSharp
open Dapper.FSharp.PostgreSQL

