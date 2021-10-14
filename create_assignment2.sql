CREATE DATABASE Bank;
USE Bank;

CREATE TABLE productLines(
	productLine int identity(1,1) PRIMARY KEY,
	textDescription varchar(250),
	htmlDescription varchar(100),
	image varchar(100)
);

CREATE TABLE products(
	productCode int identity(1,1) PRIMARY KEY,
	productName varchar(100),
	productLine int,
	productScale int,
	productVendor varchar(100),
	productDescription varchar(250),
	quantityInStock int,
	buyPrice int,
	MSRP int,
	FOREIGN KEY (productLine) REFERENCES productLines(productLine)
);

CREATE TABLE offices(
	officeCode int identity(1,1) PRIMARY KEY,
	phone varchar(15),
	addressLine1 varchar(100),
	addressLine2 varchar(100),
	city varchar(50),
	state varchar(50),
	country varchar(50),
	postalCode varchar(10),
	territory varchar(50)
);

CREATE TABLE employees(
	employeeNumber int identity(1,1) PRIMARY KEY,
	firstName varchar(50),
	lastName varchar(50),
	extension varchar(100),
	email varchar(100),
	officeCode int,
	reportsTo int,
	jobTitle varchar(50),
	FOREIGN KEY (officeCode) REFERENCES offices(officeCode),
	FOREIGN KEY (reportsTo) REFERENCES employees(employeeNumber)
);

CREATE TABLE customers(
	customerNumber int identity(1,1) PRIMARY KEY,
	customerName varchar(50),
	contactFirstName varchar(50),
	contactLastName varchar(50),
	phone varchar(15),
	addressLine1 varchar(100),
	addressLine2 varchar(100),
	city varchar(50),
	state varchar(50),
	postalCode varchar(10),
	country varchar(50),
	salesRepEmployeeNumber int,
	creditLimit int,
	FOREIGN KEY (salesRepEmployeeNumber) REFERENCES employees(employeeNumber)
);

CREATE TABLE orders(
	orderNumber int identity(1,1) PRIMARY KEY,
	orderDate date,
	requiredDate date,
	shippedDate date,
	status varchar(50),
	comments varchar(100),
	customerNumber int,
	FOREIGN KEY (customerNumber) REFERENCES customers(customerNumber)
);

CREATE TABLE orderDetails(
	orderNumber int,
	productCode int,
	quantityOrdered int,
	priceEach int,
	orderLineNumber int,
	FOREIGN KEY (orderNumber) REFERENCES orders(orderNUmber),
	FOREIGN KEY (productCode) REFERENCES products(productCode)
);

CREATE TABLE payments(
	checkNumber int identity(1,1) PRIMARY KEY,
	customerNumber int, 
	paymentDate date,
	amount int,
	FOREIGN KEY (customerNumber) REFERENCES customers(customerNumber)
);