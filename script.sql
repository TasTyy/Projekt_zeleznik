/*
Created		2. 10. 2018
Modified		2. 10. 2018
Project		
Model		
Company		
Author		
Version		
Database		mySQL 5 
*/


Create table Uporabniki (
	id_u Int NOT NULL,
	upor_ime Char(30) NOT NULL,
	geslo Char(32) NOT NULL,
 Primary Key (id_u)) ENGINE = MyISAM;

Create table Darila (
	id_d Int NOT NULL,
	datum Timestamp NOT NULL,
	opis Text NOT NULL,
	id_u Int NOT NULL,
	id_v Int NOT NULL,
 Primary Key (id_d)) ENGINE = MyISAM;

Create table Vrste_daril (
	id_v Int NOT NULL,
	vrsta Char(30) NOT NULL,
 Primary Key (id_v)) ENGINE = MyISAM;

Create table Komentarji (
	id_k Int NOT NULL,
	datum Timestamp NOT NULL,
	id_u Int NOT NULL,
	id_d Int NOT NULL,
 Primary Key (id_k)) ENGINE = MyISAM;


Alter table Komentarji add Foreign Key (id_u) references Uporabniki (id_u) on delete  restrict on update  restrict;
Alter table Darila add Foreign Key (id_u) references Uporabniki (id_u) on delete  restrict on update  restrict;
Alter table Komentarji add Foreign Key (id_d) references Darila (id_d) on delete  restrict on update  restrict;
Alter table Darila add Foreign Key (id_v) references Vrste_daril (id_v) on delete  restrict on update  restrict;


