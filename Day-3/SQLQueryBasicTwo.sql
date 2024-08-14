create database SecondDb
use SecondDb

create table Student
(Id int primary key,
Name nvarchar(50) not null,
Mobile nvarchar(10) not null unique check (Mobile like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))

insert into Student values (1,'Sam','9876543244')
insert into Student values (2,'Amit','9876543255')
insert into Student values (3,'Vijay','9876543290')
insert into Student values (4,'Jai','9876543278')

create table Fee
(FId int identity,
 SId int foreign key references Student(Id),
 FMonth int not null,
 FYear int not null,
 FAmount int not null,
 constraint pk_fee_id primary key (SId,FMonth,FYear)
 )
 insert into Fee values (1,03,24,5000)
  insert into Fee values (1,04,24,5000)
   insert into Fee values (2,03,24,5000)
  insert into Fee values (2,04,24,5000)
   insert into Fee values (4,03,24,5000)
  insert into Fee values (4,04,24,5000)
    insert into Fee values (7,04,24,5000)
	---The INSERT statement conflicted with the FOREIGN KEY constraint "FK__Fee__SId__3E52440B". 
	--The conflict occurred in database "SecondDb", table "dbo.Student", column 'Id'.
	select * from Fee
	select * from Student, Fee where Student.Id=Fee.FId

	select * from Student s, Fee f where s.Id=f.FId

	select s.Id,s.Name,s.Mobile,f.FMonth,F.FYear,F.FAmount from Student s, Fee f where s.Id=f.FId

	--default
	create table Emp (Id int primary key , Name nvarchar(50) not null, City nvarchar(50) not null default 'Delhi')
	insert into Emp values (1,'Sameer','Noida')
		insert into Emp values (2,'Rohan','Hyderabad')
		insert into Emp(Id,Name) values (4,'Shinu')
		select * from Emp
		insert into Emp(Id,Name) values (5,'Shruti')
		insert into Emp(Id,Name,City) values (6,'Naina','Chennai')
		select * from Emp