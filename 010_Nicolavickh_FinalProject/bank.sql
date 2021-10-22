-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 22, 2021 at 02:59 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bank`
--

-- --------------------------------------------------------

--
-- Table structure for table `paymentdetails`
--

CREATE TABLE `paymentdetails` (
  `paymentDetailId` int(11) NOT NULL,
  `cardOwnerName` varchar(100) DEFAULT NULL,
  `cardNumber` varchar(50) DEFAULT NULL,
  `expirationDate` date DEFAULT NULL,
  `securityCode` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `paymentdetails`
--

INSERT INTO `paymentdetails` (`paymentDetailId`, `cardOwnerName`, `cardNumber`, `expirationDate`, `securityCode`) VALUES
(1, 'Nicolavickh', '123456789', '2021-12-31', '987654321'),
(2, 'Yohanes', '987654321', '2022-08-31', '123456789'),
(3, 'Nicolavickh Yohanes Ilias', 'car number baru', '2011-11-11', 'security code baru');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `paymentdetails`
--
ALTER TABLE `paymentdetails`
  ADD PRIMARY KEY (`paymentDetailId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `paymentdetails`
--
ALTER TABLE `paymentdetails`
  MODIFY `paymentDetailId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
