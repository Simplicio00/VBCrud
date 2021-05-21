--criando bd

create database Projvb

go

use Projvb


go
--criando tabelas

create table contato(
	IdContato int primary key identity,
	Nome varchar(200) not null,
	Email varchar(200) unique not null
)

