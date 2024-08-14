use FirstDb
drop table Teams
create table Teams
(Id int identity primary key,
 Name nvarchar(50) not null,
 Slogan nvarchar(100) not null unique,
 City nvarchar(50))
 insert into Teams values ('CSK','Whistle Podu','Chennai')
 select * from Teams
  insert into Teams values ('MI','Duniya Hila Denge','Mumbai')
  set identity_insert Teams on

  insert into Teams (Id,Name,Slogan,City) values (2,'KKR','Korbo Lorbo Jeetbo Re','Kolkatta')
  select * from Teams

  set identity_insert Teams off
  insert into Teams values ('DC','D...D.. Dilli..','Delhi')

  select * from Teams
  
 alter table Teams drop column City
 select * from Teams
 alter table Teams drop column Id
 alter table Teams drop constraint PK__Teams__3214EC0748F8CCDC
 alter table Teams drop column Id
 select * from Teams
 alter table Teams drop column Slogan
 alter table Teams drop constraint UQ__Teams__015D3D1092C30C89
 alter table Teams drop column Slogan
 select * from Teams
 alter table Teams drop column Name
 --ALTER TABLE DROP COLUMN failed because 'Name' is the only data column in table 'Teams'. A table must have at least one data column.
 drop table Teams
 create table Teams
(Id int ,
 Name nvarchar(50),
 Slogan nvarchar(100) not null unique,
 City nvarchar(50))
 alter table Teams add constraint pk_Team Primary key (Id)
 --Cannot define PRIMARY KEY constraint on nullable column in table 'Teams'.
 alter table Teams alter column Id int not null

 alter table Teams add constraint pk_Team Primary key (Id)
 -----------------------------------------------------------------------------
  drop table Teams
 create table Teams
(Id int ,
 Name nvarchar(50),
 Slogan nvarchar(100) not null unique,
 City nvarchar(50))
 insert into Teams values (1,'MI','Duniya Hila Denge','Mumbai')
   insert into Teams (Id,Name,Slogan,City) values (1,'KKR','Korbo Lorbo Jeetbo Re','Kolkatta')
 alter table Teams add constraint pk_Team Primary key (Id)
 --Cannot define PRIMARY KEY constraint on nullable column in table 'Teams'.
 alter table Teams alter column Id int not null

 alter table Teams add constraint pk_Team Primary key (Id)
 -------------------------------------------------------------------------
 --functions
 --Built In
 --userdefine function
 --Built in 
 --aggergate function avg,max,min,sum...
 select getdate()

 create table Expenditure
 (ExpId int  primary key identity(1000,1),
  ExpName nvarchar(50) not null,
  ExpAmount float not null,
  ExpCat nvarchar(50) not null check(ExpCat in('Stationary','Snacks','Foods','Other')),
  ExpDate date not null default getdate())
  insert into Expenditure values ('Annual fucntion Guest Lunch',4500,'Foods','12/12/2023')
    insert into Expenditure values ('Annual fucntion Welcome Tea',4500,'Snacks','12/09/2023')
	  insert into Expenditure values ('Annual fucntion-Farewell',4500,'Foods','12/12/2023')
	    insert into Expenditure values ('Annual fucntion- notebook pens',2500,'Stationary','12/01/2024')
		  insert into Expenditure values ('Annual fucntion-book,flags',2500,'Stationary','12/12/2023')
		    insert into Expenditure values ('Trainig- note book',6500,'Stationary','12/12/2023')
			  insert into Expenditure values ('Trainig 20 days-Stationary',7500,'Stationary','12/03/2024')
			    insert into Expenditure values ('Training-Participants Tea',5600,'Snacks','03/01/2023')
				select * from Expenditure
				select sum(ExpAmount) as 'Total Expense' from Expenditure
					select avg(ExpAmount) as 'Average  Expense' from Expenditure
						select min(ExpAmount) as 'Min  Expense' from Expenditure
							select max(ExpAmount) as 'Max Expense' from Expenditure
							select distinct ExpCat from Expenditure

							select sum(ExpAmount) 'Expenses',  ExpCat from Expenditure group by ExpCat

							select sum(ExpAmount) 'Datewise Expenses',  ExpDate from Expenditure group by ExpDate

								select sum(ExpAmount) 'Datewise Expenses',  ExpDate from Expenditure 
								group by ExpDate having ExpDate='12/12/2023'
								-------------------------------------------------------
create table Emps
(Id int primary key,
Fname nvarchar(50) not null,
Lname nvarchar(50) not null,
DOJ date not null)
insert into Emps values (1,'Raj','Ratan','12/12/2021')
insert into Emps values (2,'Garima','Garg','06/12/2021')
insert into Emps values (3,'Rishi','Dhawan','07/12/2006')
insert into Emps values (4,'Nidhi','Kumari','01/23/2022')
insert into Emps values (5,'Jai','Kumar','08/12/2021')
insert into Emps values (6,'Ruhee','Nazeer','11/23/2021')
insert into Emps values (7,'Faiz','Khan','02/10/2019')
select * from Emps
--strings
select LEFT(Fname,2) from Emps
select Right(Fname,2) from Emps
select UPPER(Fname)from Emps
select Lower(Fname)from Emps

select left(Fname,1) +'. '+left(Lname,1) +' .'  'Initial' ,Fname,Lname,DOJ from Emps
select Fname,Lname,DOJ,DATEPART(DAY,DOJ) 'Joining Date' from Emps
select Fname,Lname,DOJ,DATEPART(Month,DOJ) 'Joining Month' from Emps
select Fname,Lname,DOJ,DATEPART(Year,DOJ) 'Joining Year' from Emps
select Fname,Lname,DOJ,DATEDIFF(Year,DOJ,GETDATE()) 'Working in Company for  Years ' from Emps
