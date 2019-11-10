use dbEntity

create table Departments(
Id int primary key identity,
Name varchar(20))

create table Employees(
Id int primary key identity,
Name varchar(20),
DepartmentId int)