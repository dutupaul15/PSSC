CREATE DATABASE Shop;
GO

USE Shop;
GO

-- Tabela Product
CREATE TABLE Product (
    ProductId INT PRIMARY KEY,
    Code VARCHAR(50) NOT NULL,
    Stoc INT
);

--1 Calculator 10
--2 Iphone 20
--3 Samsung 30

-- Tabela OrderHeader
CREATE TABLE OrderHeader (
    OrderId INT PRIMARY KEY,
    Address VARCHAR(100),
    Total DECIMAL(10, 2)
);

--100 Timisoara ...
--200 Cluj      ...



-- Tabela OrderLine
CREATE TABLE OrderLine (
    OrderId INT PRIMARY KEY,
    ProductId INT,
    Quantity INT,
    Price DECIMAL(10, 2),
    FOREIGN KEY (ProductId) REFERENCES Product(ProductId),
	FOREIGN KEY (OrderId) REFERENCES OrderHeader(OrderId)
);

--100 1 5 ...
--100 2 2 ...
--100 3 1 ...

--200 1 5 ...

