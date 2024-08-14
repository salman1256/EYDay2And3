create database JoinExDb
use JoinExDb
create table Department (DId int primary key,
DName nvarchar(50) not null unique)
insert into Department values (1,'App-Development')
insert into Department values (2,'Web-Development')
insert into Department values (3,'Agile-Scrum')
insert into Department values (4,'Account')
insert into Department values (5,'HR')
insert into Department values (6,'Testing')
select * from Department order by DId
create table Employee 
(Id int primary key,
 Fname nvarchar(50) not null,
 Lname nvarchar(50) not null,
 Salary float ,
 Department int )
 insert into Employee values (1,'Sam','Dicosta',98000.50,2)
  insert into Employee values (2,'Ravi','Kumar',76000.50,6)
   insert into Employee values (4,'Vipin','Garg',98000.50,1)
    insert into Employee(Id,Fname,Lname,Salary) values (3,'Arsh','Maan',98000.50)
  insert into Employee values (3,'Ravi','Kumar',76000.50,6)
   insert into Employee(Id,Fname,Lname,Salary) values (8,'Nitin','Vats',70000.50)
     insert into Employee values (9,'Rajiv','Gaur',76000.50,4)
	   insert into Employee values (7,'Ravish','Singh',50780.50,4)
	    insert into Employee values (6,'Fizi','J',50780.50,4)
	   select * from Employee
	   select * from Department
	   ---Joins
	   --select columns from table1 join table2 on Table1.commonColumn=table2.CommonColumn
	   --inner join : find out matching record from both the tables
	   select * from Employee join Department on Employee.Department=Department.DId

	    select * from Employee e join Department d on e.Department=d.DId

		select e.Id,e.Fname,e.Lname,e.Salary,d.DId,d.DName from Employee e join Department d on e.Department=d.DId

		select e.Id  'Employee Id',e.Fname+''+e.Lname 'Full Name', 
		e.Salary 'Employee Salary',d.DName 'Department Name' ,
		d.DId 'Department Id'
		from Employee e inner join Department d on e.Department=d.DId

		--outer join
		--left outer join : all the records from left hand side table and matching record from right hand side table
		select * from Employee order by Id 
		select count (Id) from Employee
		select * from Department
		select count (DId) from Department

		select e.Id  'Employee Id',e.Fname+''+e.Lname 'Full Name', 
		e.Salary 'Employee Salary',d.DName 'Department Name' ,
		d.DId 'Department Id'
		from Employee e  left outer join Department d on e.Department=d.DId

		--right outer join : all the records from right hand side table and matching record from left hand side table
		select e.Id  'Employee Id',e.Fname+''+e.Lname 'Full Name', 
		e.Salary 'Employee Salary',d.DName 'Department Name' ,
		d.DId 'Department Id'
		from Employee e  right outer join Department d on e.Department=d.DId

		--full outer join : all the records from right & left  table and matching record from both tables
		select e.Id  'Employee Id',e.Fname+''+e.Lname 'Full Name', 
		e.Salary 'Employee Salary',d.DName 'Department Name' ,
		d.DId 'Department Id'
		from Employee e  full outer join Department d on e.Department=d.DId
		----------------------------------------------------------------------------
		---cross join
		
		create table Sizes (Id int primary key, Size nvarchar(50) not null unique)
		insert into Sizes values (1,'Small'),(2,'Medium'),(3,'Large')
		create table Colors(Id int primary key , Color nvarchar(50) not null unique)
		insert into Colors values (1,'Blue'),(2,'Pink'),(3,'White'),(4,'Red'),(5,'Brown')
		select * from Sizes order by Id
		select * from Colors order by Id
		select count(Id) 'Number of Sizes' from Sizes
			select count(Id) 'Number of Colors' from Colors
			-- if have m records in first table and n in second table then cross join hanve m*n records
			select * from Sizes cross join Colors
			select s.Size,c.Color  from Sizes s cross join Colors c
			insert into Colors values (6,'Yellow')
				select s.Size,c.Color  from Sizes s cross join Colors c