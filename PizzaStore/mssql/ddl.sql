use master;
go

create database PizzaStoreDb;
go

CREATE SCHEMA OrderPizza;
go

create SCHEMA Pizza;
GO

CREATE TABLE Pizza.Pizza
(
    PizzaId int not null PRIMARY key,
    --CrustId int null foreign key REFERENCES Pizza.Crust(CrustId),
    Crust nvarchar(100),
    SizeId int null,
    --Size nvarchar(100),
    [Name] nvarchar(250) not null,
    DateModified DATETIME2(0) not null,
    Active bit not null default 1,
    constraint SizeId foreign key references Pizza.Size(SizeId)
);

--CREATE TABLE Pizza.Crust
--(

  --  CrustId int not null PRIMARY key,
  --  [Name] NVARCHAR(100) not null,
  --  Active bit not null,
  --  constraint CrustId primary key,
  --  constraint Active default 1
--);

CREATE Table Pizza.SIZE
(
    SizeId int not null PRIMARY key,
    Price DECIMAL not null,
    [Name] nvarchar(100) not null,
    Active bit not null
);

CREATE Table Pizza.Topping
(
    ToppingId int not null primary key,
    PizzaId int not null,
    [Name] nvarchar(100) not null

);

CREATE TABLE Pizza.PizzaTopping
(
    ToppingId int not null,
    PizzaId int not null,
    [Name] nvarchar(100) not null,
    Active bit not null
);
GO