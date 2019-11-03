create table Products(
Id int primary key identity,
Name varchar(30))

create table Suppliers(
Id int primary key identity,
Name varchar(30),
Location varchar(30),
Price int,
ProductId int foreign key references Products(Id))

create table Customers(
Id int,
Name varchar(30),
Quantity int,
ProductId int foreign key references Products(Id),
SupplierId int foreign key references Suppliers(Id))

create procedure InsertCustomer(@Id int,@Name varchar(30),@Quantity int,@ProductId int,@SupplierId int)
as
begin
insert into Customers values (@Id,@Name,@Quantity,@ProductId,@SupplierId)
end


create procedure DisplaySuppliers(@ProductId int)
as
begin
select * from Suppliers where ProductId=@ProductId
end

create procedure DisplayCustomers
as
begin
select distinct Id,Name from Customers 
end

create table CustomerCount(
Id int unique,
CusCount int)

create procedure DisplayProducts
as
begin
select * from Products
end
exec DisplayProducts


create procedure CustomerDetails(@Id int)
as
begin
select p.Name,c.Quantity,s.Name,s.Price from Customers as c 
inner join Products as p
on c.ProductId=p.Id 
inner join Suppliers as s
on c.SupplierId=s.Id
where c.Id=@Id
end