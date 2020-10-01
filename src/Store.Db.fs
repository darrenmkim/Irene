module Irene.Store.Db 

(*  
get into postgres environment: 
$ sudo -u postgres psql 

create user: 
postgres=# create user admin with password '1324';

create database:
create database IreneDb owner admin;


<manjaro linux>
https://github.com/malnvenshorn/OctoPrint-FilamentManager/wiki/Setup-PostgreSQL-on-Arch-Linux
-Installation-
Install the postgresql package:
$ sudo pacman -S postgresql
Create a new database cluster:
$ sudo -u postgres -i initdb --locale $LANG -E UTF8 -D /var/lib/postgres/data
Start and enable postgresql.service:
$ sudo systemctl start postgresql.service
$ sudo systemctl enable postgresql.service
Create new user and database
Switch to the postgres user:
$ sudo -u postgres -i
Create user octoprint:
[postgres]$ createuser --interactive -P
Enter name of role to add: admin
Enter password for new role: 4231
Enter it again: 4231
Shall the new role be a superuser? (y/n) y
Create database:
[postgres]$ createdb -O irenedb

*)

open System
open Npgsql // #r "/home/drnmk/Documents/irene/bin/Debug/netcoreapp3.1/Npgsql.dll";; 


let conInfo = "Host=localhost;Username=admin;Password=4231;Database=irenedb"

let query (sql : string) = 
  let sql = "select * from lunch;"
  let conn = new NpgsqlConnection(conInfo)
  conn.Open ()
  let cmd = new NpgsqlCommand(sql, conn)
  // let vers = cmd.ExecuteScalar().ToString()
  // cmd.CommandText <- sql
  //cmd.ExecuteNonQuery() |> ignore
  let reader = cmd.ExecuteReader()
  conn.Close ()
  // ??
    

let read = query "select * from lunch;"


(*
           var cs = "Host=localhost;Username=postgres;Password=s$cret;Database=testdb";

            using var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM cars";
            using var cmd = new NpgsqlCommand(sql, con);

            using NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0} {1} {2}", rdr.GetInt32(0), rdr.GetString(1),
                        rdr.GetInt32(2));
            }

*)
