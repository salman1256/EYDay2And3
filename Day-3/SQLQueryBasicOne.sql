--create object objectName
--create database <DatabaseName>
create database FirstDb
use FirstDb
--create table <tableName>
--(ColumnName Datatype [Constraint],
 ---   ColumnName Datatype [Constraint],
---	ColumnName Datatype [Constraint])
create table Employee
(Id int primary key,
 Fname nvarchar(50) not null,
 Lname nvarchar(50) not null,
 Salary float )

 select * from Employee
 insert into Employee values (1,'Sam','Dicosta',98000.90)
 insert into Employee(Id,Fname,Lname) values(2,'Deep','Sharma')
 insert into Employee(Id,Salary,Fname,Lname) values (4,76000.50,'Jai','Deep')
  insert into Employee values 
	(5,'Nitin','Dhimaan',48000.30),
    (6,'Neha','Garg',78000.20),
	(3,'Danish','Wani',68000.50)
	select * from Employee
delete from Employee where Id=6
select * from Employee where Id=2
update Employee set Salary=55000.50 where Id=2
select * from Employee
--primary key
-- not null ,unique 
-- 1 primary key per table
-- create clustered index on table 
select * from Employee
 insert into Employee values 
	(6,'Amit','Kapoor',78000.30)
	 insert into Employee(Fname,Lname,Salary) values ('Sam','Dicosta',98000.90)
--	 Cannot insert the value NULL into column 'Id',table 'FirstDb.dbo.Employee'; column does not allow nulls. INSERT fails.

	 insert into Employee(Id,Fname,Lname,Salary) values (6,'Sam','Dicosta',98000.90)
	-- Violation of PRIMARY KEY constraint 'PK__Employee__3214EC07F14EB898'. Cannot insert duplicate key in object 'dbo.Employee'. The duplicate key value is (6).
	 insert into Employee(Id,Fname,Lname,Salary) values (10,'Sam','Dicosta',98000.90)

	 --primary key, not null
	 --unique : you can'not insert duplicate values , you can insert null but once only
	 --It's a non clustered index, we can write multiple unique keys in a table.
	 drop table Employee
create table Employee
(Id int primary key,
 Fname nvarchar(50) not null,
 Lname nvarchar(50) not null,
 Salary float,
 Email nvarchar(100) unique,
 Mobile varchar(10) unique)
insert into Employee(Id,Fname,Lname,Salary,Mobile) values(1,'Arsh','Maan',76000,'9876543210')	
select * from Employee
insert into Employee(Id,Fname,Lname,Salary,Email) values(2,'Jitin','K.',76000,'jatin_k@mail.com')
insert into Employee(Id,Fname,Lname,Salary,Mobile,Email) values(4,'Anam','Aalif',76000,'876543901','mail.com')
insert into Employee(Id,Fname,Lname,Salary,Email,Mobile) values(8,'Jitin','K.',76000,'asd_k@mail.com','9876543217')
--check, identity, foreign key
--Check:
 drop table Employee
create table Employee
(Id int primary key,
 Fname nvarchar(50) not null,
 Lname nvarchar(50) not null,
 Salary float check (Salary>=10000 and Salary<=100000),
 Email nvarchar(100) unique,
 Mobile varchar(10) unique)
insert into Employee(Id,Fname,Lname,Salary,Mobile) values(1,'Arsh','Maan',76000,'9876543210')	
select * from Employee
insert into Employee(Id,Fname,Lname,Salary,Email) values(2,'Jitin','K.',7600,'jatin_k@mail.com')
--The INSERT statement conflicted with the CHECK constraint "CK__Employee__Salary__3E52440B". 
--The conflict occurred in database "FirstDb", table "dbo.Employee", column 'Salary'.

insert into Employee(Id,Fname,Lname,Mobile,Email) values(4,'Anam','Aalif','8765439010','mail.com')

-----------------------------------------
create table Employee
(Id int primary key,
 Fname nvarchar(50) not null,
 Lname nvarchar(50) not null,
 Salary float not null check (Salary>=10000 and Salary<=100000),
 Email nvarchar(100) not null unique,
 Mobile varchar(10) not null unique check (Mobile like'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))

 insert into Employee values (1,'Raj','Kumar',98000,'raj_k@gmail.com','9876543210')
  insert into Employee values (2,'Sudhir','Gaur',98000,'sudhir_g@gmail.com','675432')
 -- The INSERT statement conflicted with the CHECK constraint "CK__Employee__Mobile__440B1D61".
 --The conflict occurred in database "FirstDb", table "dbo.Employee", column 'Mobile'.
 insert into Employee values (2,'Sudhir','Gaur',98000,'sudhir_g@gmail.com','6754320000')
 select * from Employee
insert into Employee(Id,Fname,Lname,Mobile,Email) values(4,'Anam','Aalif','8765439010','mail.com')

--Cannot insert the value NULL into column 'Salary', table 'FirstDb.dbo.Employee'; column does not allow nulls. INSERT fails.
--Identity
--identity(seed,increment)
create table Customer (CId int identity,CName nvarchar(50) not null, ODLimit float not null)
insert into Customer values ('Sam',550000)
insert into Customer values ('Ravi',500000)
insert into Customer values ('Nishi',850000)
insert into Customer values ('Arsh',650000)
select * from Customer
drop table Customer2
create table Customer2 (CId int identity(1000,5),CName nvarchar(50) not null, ODLimit float not null)
insert into Customer2 values ('Sam',550000)
insert into Customer2 values ('Ravi',500000)
insert into Customer2 values ('Nishi',850000)
insert into Customer2 values ('Arsh',650000)
select * from Customer2

--delete Vs Drop
delete from Customer where CId=2
select * from Customer
delete  from Customer
insert into Customer values ('Arsh',650000)
select * from Customer
drop table Customer

--Truncate Vs Delete
delete from Customer2
insert into Customer2 values ('Nishi',850000)
select * from Customer2
truncate table Customer2
insert into Customer2 values ('Nishi',850000)
select * from Customer2
-------------------------------------------------------------------------------------------------

