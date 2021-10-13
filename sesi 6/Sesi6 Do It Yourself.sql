CREATE DATABASE staff;

CREATE TABLE data_staff(
	nik int PRIMARY KEY,
	nama varchar(50),
	alamat varchar(200),
	handphone varchar(15)
);

INSERT INTO data_staff(nik, nama, alamat, handphone) VALUES 
(1, 'Nicolavickh', 'Bandung', '0123456789'),
(2, 'Yohanes', 'Jakarta', '9876543210'),
(3, 'ABC', 'Surabaya', '4698715687'),
(4, 'DEF', 'Malang', '648974354'),
(5, 'GHI', 'Purwakarta', '6546843158');

ALTER TABLE data_staff ADD joinDate date;

INSERT INTO data_staff(nik, nama, alamat, handphone, joinDate) VALUES (6, 'JKL', 'Yogyakarta', '786546873', GETDATE());

SELECT TOP 2 * FROM data_staff;

SELECT TOP 3 * FROM data_staff;

CREATE TABLE staffOutSource(
	nik int PRIMARY KEY,
	nama varchar(50),
	alamat varchar(200),
	handphone varchar(15),
	joinDate date
);

INSERT INTO staffOutSource VALUES 
(1, 'Dummy1', 'Kota1', '789654123', GETDATE()),
(2, 'Dummy2', 'Kota2', '789654123', '2021-10-1'),
(3, 'Dummy3', 'Kota3', '789654123', '2021-10-2'),
(4, 'Dummy4', 'Kota4', '789654123', '2021-10-3'),
(5, 'Dummy5', 'Kota5', '789654123', '2021-10-4'),
(6, 'Dummy6', 'Kota6', '789654123', '2021-10-5'),
(7, 'Dummy7', 'Kota7', '789654123', '2021-10-6'),
(8, 'Dummy8', 'Kota8', '789654123', '2021-10-7'),
(9, 'Dummy9', 'Kota9', '789654123', '2021-10-8'),
(10, 'Dumm10', 'Kota10', '789654123', '2021-10-9');

SELECT s.*, d.* FROM data_staff d JOIN staffOutSource s ON s.joinDate = d.joinDate WHERE s.joinDate = d.joinDate;

SELECT d.* FROM data_staff d RIGHT JOIN staffOutSource s ON s.joinDate = d.joinDate;

SELECT s.* FROM data_staff d LEFT JOIN staffOutSource s ON s.joinDate = d.joinDate;

SELECT s.*, d.* FROM data_staff d FULL JOIN staffOutSource s ON s.joinDate = d.joinDate;
 
