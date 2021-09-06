--create table customer(id int primary key identity(1,1),Name varchar(255),zipcode varchar(255),email varchar(255));
--create table Login(id int primary key identity(1,1),customer_Id int,username varchar(255),password varchar(255));



--CREATE PROCEDURE Add_customer @Name varchar(255),@zipcode varchar(255),@email varchar(255)--as--insert into customer(Name,zipcode,email) values(@Name,@zipcode,@email);--new--CREATE PROCEDURE Login_customer @customer_id int,@username varchar(255),@password varchar(255)--as--insert into Login(customer_Id,username,password) values(@customer_id,@username,@password);select * from Login;
select * from customer

