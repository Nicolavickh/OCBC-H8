use Bank;
/* ===== Product Lines =====*/
INSERT INTO productLines(textDescription, htmlDescription, image) VALUES 
('text description 1', 'html description 1', 'image location 1'), 
('text description 2', 'html description 2', 'image location 2'), 
('text description 3', 'html description 3', 'image location 3'), 
('text description 4', 'html description 4', 'image location 4'), 
('text description 5', 'html description 5', 'image location 5'), 
('text description 6', 'html description 6', 'image location 6'), 
('text description 7', 'html description 7', 'image location 7'), 
('text description 8', 'html description 8', 'image location 8'), 
('text description 9', 'html description 9', 'image location 9'), 
('text description 10', 'html description 10', 'image location 10');

SELECT * FROM productLines;
/* ==============================================================*/

/* ===== Products =====*/
INSERT INTO products(productName, productLine, productScale, productVendor, productDescription, quantityInStock, buyPrice, MSRP) VALUES 
('Name 1', 1, 1, 'Vendor 1', 'Description 1', 10, 1000, 1500),
('Name 2', 2, 2, 'Vendor 2', 'Description 2', 20, 2000, 2500),
('Name 3', 3, 3, 'Vendor 3', 'Description 3', 30, 3000, 3500),
('Name 4', 4, 4, 'Vendor 4', 'Description 4', 40, 4000, 4500),
('Name 5', 5, 5, 'Vendor 5', 'Description 5', 50, 5000, 5500),
('Name 6', 6, 6, 'Vendor 6', 'Description 6', 60, 6000, 6500),
('Name 7', 7, 7, 'Vendor 7', 'Description 7', 70, 7000, 7500),
('Name 8', 8, 8, 'Vendor 8', 'Description 8', 80, 8000, 8500),
('Name 9', 9, 9, 'Vendor 9', 'Description 9', 90, 9000, 9500),
('Name 10', 10, 10, 'Vendor 10', 'Description 10', 100, 10000, 10500);

SELECT * FROM products;
/* ==============================================================*/

/* ===== Offices =====*/
INSERT INTO offices(city, phone, addressLine1, addressLine2, state, country, postalCode, territory) VALUES 
('city 1', '0123654789', 'address line 1', 'address line 11', 'state 1', 'country 1', '12345', 'territory 1'), 
('city 2', '9874563210', 'address line 2', 'address line 12', 'state 2', 'country 2', '67890', 'territory 2'), 
('city 3', '1523647890', 'address line 3', 'address line 13', 'state 3', 'country 3', '54321', 'territory 3'), 
('city 4', '0325147896', 'address line 4', 'address line 14', 'state 4', 'country 4', '09876', 'territory 4'), 
('city 5', '4631258790', 'address line 5', 'address line 15', 'state 5', 'country 5', '45687', 'territory 5'), 
('city 6', '0325698741', 'address line 6', 'address line 16', 'state 6', 'country 6', '41258', 'territory 6'), 
('city 7', '1239874560', 'address line 7', 'address line 17', 'state 7', 'country 7', '41256', 'territory 7'), 
('city 8', '0125469783', 'address line 8', 'address line 18', 'state 8', 'country 8', '45879', 'territory 8'), 
('city 9', '6314528790', 'address line 9', 'address line 19', 'state 9', 'country 9', '45632', 'territory 9'), 
('city 10', '4523879610', 'address line 10', 'address line 20', 'state 10', 'country 10', '45120', 'territory 10');

SELECT * FROM offices;
/* ==============================================================*/

/* ===== Employees =====*/
INSERT INTO employees(firstName, lastName, extension, email, officeCode, reportsTo, jobTitle) VALUES
('First Name 1', 'Last Name 1', 'extension 1', 'email 1', 1, 1, 'Job Title 1'),
('First Name 2', 'Last Name 2', 'extension 2', 'email 2', 1, 2, 'Job Title 2'),
('First Name 3', 'Last Name 3', 'extension 3', 'email 3', 2, 3, 'Job Title 3'),
('First Name 4', 'Last Name 4', 'extension 4', 'email 4', 3, 4, 'Job Title 4'),
('First Name 5', 'Last Name 5', 'extension 5', 'email 5', 4, 5, 'Job Title 5'),
('First Name 6', 'Last Name 6', 'extension 6', 'email 6', 5, 6, 'Job Title 6'),
('First Name 7', 'Last Name 7', 'extension 7', 'email 7', 6, 7, 'Job Title 7'),
('First Name 8', 'Last Name 8', 'extension 8', 'email 8', 7, 8, 'Job Title 8'),
('First Name 9', 'Last Name 9', 'extension 9', 'email 9', 8, 9, 'Job Title 9'),
('First Name 10', 'Last Name 10', 'extension 10', 'email 10', 9, 10, 'Job Title 10');

SELECT * FROM employees;
/* ==============================================================*/

/* ===== Customers =====*/
INSERT INTO customers(customerName, contactFirstName, contactLastName, phone, addressLine1, addressLine2, city, state, postalCode, country, salesRepEmployeeNumber, creditLimit) VALUES 
('Name 1', 'Contact First Name 1', 'Contact Last Name 1', '0147852369', 'Address Line 10', 'Address Line 20', 'City 1', 'State 1', '45871', 'Country 1', 1, 1),
('Name 2', 'Contact First Name 2', 'Contact Last Name 2', '0321456987', 'Address Line 11', 'Address Line 21', 'City 2', 'State 2', '45632', 'Country 2', 2, 2),
('Name 3', 'Contact First Name 3', 'Contact Last Name 3', '0123654789', 'Address Line 12', 'Address Line 22', 'City 3', 'State 3', '45826', 'Country 3', 3, 3),
('Name 4', 'Contact First Name 4', 'Contact Last Name 4', '0123456789', 'Address Line 13', 'Address Line 23', 'City 4', 'State 4', '41236', 'Country 4', 4, 4),
('Name 5', 'Contact First Name 5', 'Contact Last Name 5', '0987456321', 'Address Line 14', 'Address Line 24', 'City 5', 'State 5', '45698', 'Country 5', 5, 5),
('Name 6', 'Contact First Name 6', 'Contact Last Name 6', '0987654321', 'Address Line 15', 'Address Line 25', 'City 6', 'State 6', '47125', 'Country 6', 6, 6),
('Name 7', 'Contact First Name 7', 'Contact Last Name 7', '0365214789', 'Address Line 16', 'Address Line 26', 'City 7', 'State 7', '49635', 'Country 7', 7, 7),
('Name 8', 'Contact First Name 8', 'Contact Last Name 8', '0153246987', 'Address Line 17', 'Address Line 27', 'City 8', 'State 8', '41025', 'Country 8', 8, 8),
('Name 9', 'Contact First Name 9', 'Contact Last Name 9', '0325641789', 'Address Line 18', 'Address Line 28', 'City 9', 'State 9', '40369', 'Country 9', 9, 9),
('Name 10', 'Contact First Name 10', 'Contact Last Name 10', '0547891236', 'Address Line 91', 'Address Line 29', 'City 10', 'State 10', '49870', 'Country 10', 10, 10);

SELECT * FROM customers;
/* ==============================================================*/

/* ===== Orders =====*/
INSERT INTO orders(orderDate, requiredDate, shippedDate, status, comments, customerNumber) VALUES
('2021-01-01', '2021-03-03', '2021-02-02', 'status 1', 'comments 1', 1),
('2021-02-02', '2021-04-04', '2021-03-03', 'status 2', 'comments 2', 2),
('2021-03-03', '2021-05-05', '2021-04-04', 'status 3', 'comments 3', 3),
('2021-04-04', '2021-06-06', '2021-05-05', 'status 4', 'comments 4', 4),
('2021-05-05', '2021-07-07', '2021-06-06', 'status 5', 'comments 5', 5),
('2021-06-06', '2021-08-08', '2021-07-07', 'status 6', 'comments 6', 6),
('2021-07-07', '2021-09-09', '2021-08-08', 'status 7', 'comments 7', 7),
('2021-08-08', '2021-10-10', '2021-09-09', 'status 8', 'comments 8', 8),
('2021-09-09', '2021-11-11', '2021-10-10', 'status 9', 'comments 9', 9),
('2021-10-10', '2021-12-12', '2021-11-11', 'status 10', 'comments 10', 10);

SELECT * FROM orders;
/* ==============================================================*/

/* ===== Orders Details =====*/
INSERT INTO orderDetails(orderNumber, productCode, quantityOrdered, priceEach, orderLineNumber) VALUES
(11, 1, 11, 1000, 1),
(12, 2, 12, 2000, 2),
(13, 3, 13, 3000, 3),
(14, 4, 14, 4000, 4),
(15, 5, 15, 5000, 5),
(16, 6, 16, 6000, 6),
(17, 7, 17, 7000, 7),
(18, 8, 18, 8000, 8),
(19, 9, 19, 9000, 9),
(20, 10, 20, 10000, 10);

SELECT * FROM orderDetails;
/* ==============================================================*/

/* ===== Payments =====*/
INSERT INTO payments(customerNumber, paymentDate, amount) VALUES
(1, '2021-01-01', 100000),
(2, '2021-02-02', 200000),
(3, '2021-03-03', 300000),
(4, '2021-04-04', 400000),
(5, '2021-05-05', 500000),
(6, '2021-06-06', 600000),
(7, '2021-07-07', 700000),
(8, '2021-08-08', 800000),
(9, '2021-09-09', 900000),
(10, '2021-10-10', 1000000);

SELECT * FROM payments;
/* ==============================================================*/
