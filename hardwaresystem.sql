-- phpMyAdmin SQL Dump
-- version 4.3.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Oct 15, 2016 at 05:11 AM
-- Server version: 5.6.24
-- PHP Version: 5.6.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `hardwaresystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `activity`
--

CREATE TABLE IF NOT EXISTS `activity` (
  `ActivityID` int(10) NOT NULL,
  `TransactionID` int(11) NOT NULL,
  `Action` varchar(50) NOT NULL,
  `username` varchar(30) NOT NULL,
  `DateTime` varchar(25) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=202 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `activity`
--

INSERT INTO `activity` (`ActivityID`, `TransactionID`, `Action`, `username`, `DateTime`) VALUES
(1, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:37'),
(2, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:38'),
(3, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:39'),
(4, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:39'),
(5, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:39'),
(6, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:40'),
(7, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:40'),
(8, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:40'),
(9, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:41'),
(10, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:41'),
(11, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:41'),
(12, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:42'),
(13, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:42'),
(14, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:42'),
(15, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:42'),
(16, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:42'),
(17, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:43'),
(18, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:43'),
(19, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:22:43'),
(20, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:24:41'),
(21, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:32:01'),
(22, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:33:07'),
(23, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:33:11'),
(24, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:33:11'),
(25, 0, 'Generate Inventory Report', 'admin', '2016-10-08 13:33:11'),
(26, 0, 'Generate Inventory Report', 'admin', '2016-10-08 18:15:14'),
(27, 0, 'Generate Inventory Report', 'admin', '2016-10-08 18:35:10'),
(28, 0, 'Generate Inventory Report', 'admin', '2016-10-08 18:37:27'),
(29, 0, 'Generate Sales Report', 'admin', '2016-10-08 18:37:35'),
(30, 0, 'Generate Inventory Report', 'admin', '2016-10-08 18:37:41'),
(31, 0, 'Generate Inventory Report', 'admin', '2016-10-08 18:39:16'),
(32, 0, 'Generate Sales Report', 'admin', '2016-10-08 18:44:12'),
(33, 0, 'Generate Inventory Report', 'admin', '2016-10-08 18:44:39'),
(34, 0, 'Generate Sales Report', 'admin', '2016-10-08 18:44:43'),
(35, 0, 'Generate Sales Report', 'admin', '2016-10-08 18:46:09'),
(36, 0, 'Generate Inventory Report', 'admin', '2016-10-08 18:46:38'),
(37, 0, 'Generate Sales Report', 'admin', '2016-10-08 18:46:40'),
(38, 0, 'Generate Inventory Report', 'admin', '2016-10-08 18:46:56'),
(39, 53, 'Sales', 'admin', '2016-10-08 19:02:38'),
(42, 56, 'Sales', 'admin', '2016-10-08 20:13:26'),
(43, 0, 'Generate Sales Report', 'admin', '2016-10-08 21:05:38'),
(44, 0, 'Generate Sales Report', 'admin', '2016-10-08 21:18:42'),
(45, 0, 'Generate Inventory Report', 'admin', '2016-10-08 21:18:50'),
(46, 0, 'Generate Inventory Report', 'admin', '2016-10-08 21:19:14'),
(47, 0, 'Generate Inventory Report', 'admin', '2016-10-08 21:20:24'),
(48, 0, 'Generate Sales Report', 'admin', '2016-10-08 22:34:25'),
(49, 0, 'Generate Sales Report', 'admin', '2016-10-08 22:35:58'),
(50, 0, 'Generate Inventory Report', 'admin', '2016-10-08 22:36:19'),
(51, 0, 'Adding new Client', 'admin', '2016-10-08 23:22:55'),
(52, 0, 'Modift Client: 6', 'admin', '2016-10-08 23:56:23'),
(53, 0, 'Modift Client: 6', 'admin', '2016-10-08 23:56:27'),
(54, 0, 'Modify Client: 3', 'admin', '2016-10-09 00:04:20'),
(55, 0, 'Modify Client: 4', 'admin', '2016-10-09 00:06:17'),
(56, 0, 'Adding new Client', 'admin', '2016-10-09 00:06:43'),
(57, 0, 'Delete Product :7', 'admin', '2016-10-09 00:07:49'),
(58, 0, 'Delete Product :7', 'admin', '2016-10-09 00:08:33'),
(59, 0, 'Adding new Client', 'admin', '2016-10-09 00:09:57'),
(60, 0, 'Modify Client: 8', 'admin', '2016-10-09 00:10:20'),
(61, 0, 'Delete Product :8', 'admin', '2016-10-09 00:10:29'),
(62, 0, 'Adding new Client', 'admin', '2016-10-09 00:43:12'),
(63, 0, 'Update Supplier :hello', 'admin', '2016-10-09 01:31:30'),
(64, 0, 'Delete Supplier :0', 'admin', '2016-10-09 01:31:39'),
(65, 0, 'Update Supplier :hello', 'admin', '2016-10-09 01:33:38'),
(66, 0, 'Update Supplier :hello', 'admin', '2016-10-09 01:33:47'),
(67, 0, 'Update Supplier :hello', 'admin', '2016-10-09 01:34:23'),
(68, 0, 'Generate Sales Report', 'admin', '2016-10-09 02:20:45'),
(69, 0, 'Adding new User: ManageUsers', 'admin', '2016-10-09 02:27:50'),
(70, 0, 'Adding new User: ManageUsers', 'admin', '2016-10-09 02:28:22'),
(71, 0, 'Adding new User: ManageUsers', 'admin', '2016-10-09 02:29:07'),
(72, 0, 'Update Supplier :', 'admin', '2016-10-09 13:19:17'),
(73, 0, 'Update Employee :Alpha Tester', 'admin', '2016-10-09 14:17:36'),
(74, 0, 'Update Employee :Beta Tester', 'admin', '2016-10-09 14:19:14'),
(75, 0, 'Update Employee :Jahdiel Villosa', 'admin', '2016-10-09 14:20:50'),
(76, 0, 'Delete Product :343434', 'admin', '2016-10-09 14:27:27'),
(77, 0, 'Login', 'admin', '2016-10-09 14:44:43'),
(78, 0, 'Login', 'admin', '2016-10-09 14:45:38'),
(79, 0, 'Login', 'admin', '2016-10-09 14:46:06'),
(80, 0, 'Login', 'admin', '2016-10-09 15:02:03'),
(81, 0, 'Login', 'helloworld', '2016-10-09 15:33:46'),
(82, 0, 'Login', 'helloworld', '2016-10-09 15:35:30'),
(83, 0, 'Delete product attempt :4', 'helloworld', '2016-10-09 15:35:42'),
(84, 0, 'Delete product attempt :2', 'helloworld', '2016-10-09 15:35:44'),
(85, 0, 'Login', 'admin', '2016-10-09 15:41:20'),
(86, 0, 'Login', 'admin', '2016-10-09 15:43:18'),
(87, 0, 'Login', 'admin', '2016-10-09 15:45:53'),
(88, 0, 'Login', 'admin', '2016-10-09 15:48:19'),
(89, 0, 'Generate Inventory Report', 'admin', '2016-10-09 15:48:36'),
(90, 0, 'Login', 'admin', '2016-10-09 15:51:43'),
(91, 0, 'Generate Inventory Report', 'admin', '2016-10-09 15:51:50'),
(92, 0, 'Generate Inventory Report', 'admin', '2016-10-09 15:52:34'),
(93, 0, 'Login', 'admin', '2016-10-09 15:57:54'),
(94, 0, 'Login', 'helloworld', '2016-10-09 15:58:16'),
(95, 0, 'Login', 'admin', '2016-10-09 16:02:49'),
(96, 0, 'Login', 'helloworld', '2016-10-09 16:06:40'),
(97, 0, 'Login', 'admin', '2016-10-09 17:31:42'),
(98, 0, 'Login', 'admin', '2016-10-09 17:36:12'),
(99, 0, 'Login', 'admin', '2016-10-09 17:38:00'),
(100, 0, 'Login', 'admin', '2016-10-09 17:41:02'),
(101, 0, 'Login', 'admin', '2016-10-09 17:42:00'),
(102, 0, 'Login', 'admin', '2016-10-09 17:47:25'),
(103, 0, 'Login', 'admin', '2016-10-09 17:48:57'),
(104, 0, 'Login', 'admin', '2016-10-09 17:51:24'),
(105, 0, 'Update Supplier :globe', 'admin', '2016-10-09 17:51:51'),
(106, 0, 'Login', 'admin', '2016-10-09 17:55:44'),
(107, 0, 'Login', 'admin', '2016-10-09 18:05:32'),
(108, 0, 'Login', 'admin', '2016-10-09 18:06:20'),
(109, 0, 'Login', 'admin', '2016-10-09 18:16:54'),
(110, 0, 'Login', 'admin', '2016-10-09 18:31:56'),
(111, 0, 'Login', 'admin', '2016-10-09 18:38:34'),
(112, 0, 'Login', 'admin', '2016-10-09 18:39:42'),
(113, 0, 'Login', 'admin', '2016-10-09 19:00:40'),
(114, 0, 'Login', 'admin', '2016-10-09 19:22:30'),
(115, 0, 'Login', 'admin', '2016-10-09 19:24:39'),
(116, 0, 'Login', 'admin', '2016-10-09 19:24:55'),
(117, 0, 'Login', 'helloworld', '2016-10-09 19:52:36'),
(118, 0, 'Adding new User: ManageUsers', 'helloworld', '2016-10-09 19:53:42'),
(119, 0, 'Login', 'delta', '2016-10-09 20:08:36'),
(120, 0, 'Login', 'delta', '2016-10-09 20:10:08'),
(121, 0, 'Login', 'delta', '2016-10-09 20:12:44'),
(122, 0, 'Login', 'delta', '2016-10-09 20:17:35'),
(123, 0, 'Login', 'delta', '2016-10-09 20:33:01'),
(124, 0, 'Login', 'delta', '2016-10-09 20:34:15'),
(125, 0, 'Search Product :broken', 'delta', '2016-10-09 20:35:29'),
(126, 0, 'Search Product :', 'delta', '2016-10-09 20:35:35'),
(127, 0, 'Login', 'admin', '2016-10-09 20:52:52'),
(128, 0, 'Search Product :none', 'admin', '2016-10-09 20:53:42'),
(129, 0, 'Login', 'delta', '2016-10-09 21:30:03'),
(130, 0, 'Login', 'admin', '2016-10-09 21:37:51'),
(131, 0, 'Login', 'admin', '2016-10-09 21:45:12'),
(132, 0, 'Login', 'admin', '2016-10-09 21:45:51'),
(133, 0, 'Login', 'admin', '2016-10-09 21:55:27'),
(134, 0, 'Login', 'admin', '2016-10-09 21:55:51'),
(135, 0, 'Login', 'admin', '2016-10-09 23:15:36'),
(136, 0, 'Login', 'admin', '2016-10-09 23:18:10'),
(137, 0, 'Login', 'admin', '2016-10-09 23:41:25'),
(138, 0, 'Login', 'admin', '2016-10-09 23:44:27'),
(139, 0, 'Login', 'admin', '2016-10-10 00:00:38'),
(140, 0, 'Login', 'admin', '2016-10-10 00:02:24'),
(141, 0, 'Login', 'admin', '2016-10-10 00:04:24'),
(142, 0, 'Login', 'admin', '2016-10-10 00:07:02'),
(143, 0, 'Login', 'admin', '2016-10-10 00:09:42'),
(144, 0, 'Login', 'admin', '2016-10-10 00:10:44'),
(145, 0, 'Login', 'admin', '2016-10-10 00:16:07'),
(146, 0, 'Login', 'admin', '2016-10-10 00:25:29'),
(147, 0, 'Generate Inventory Report', 'admin', '2016-10-10 00:25:43'),
(148, 0, 'Login', 'admin', '2016-10-10 00:27:54'),
(149, 0, 'Generate Inventory Report', 'admin', '2016-10-10 00:27:58'),
(150, 0, 'Login', 'admin', '2016-10-10 00:32:55'),
(151, 0, 'Generate Inventory Report', 'admin', '2016-10-10 00:33:03'),
(152, 0, 'Login', 'admin', '2016-10-10 00:35:22'),
(153, 0, 'Generate Inventory Report', 'admin', '2016-10-10 00:35:30'),
(154, 0, 'Login', 'admin', '2016-10-10 00:37:39'),
(155, 0, 'Generate Inventory Report', 'admin', '2016-10-10 00:37:44'),
(156, 0, 'Login', 'admin', '2016-10-10 00:38:41'),
(157, 0, 'Generate Inventory Report', 'admin', '2016-10-10 00:38:44'),
(158, 0, 'Login', 'admin', '2016-10-10 00:39:36'),
(159, 0, 'Generate Inventory Report', 'admin', '2016-10-10 00:39:45'),
(160, 0, 'Login', 'admin', '2016-10-10 00:46:36'),
(161, 0, 'Generate Inventory Report', 'admin', '2016-10-10 00:46:43'),
(162, 0, 'Login', 'admin', '2016-10-10 00:49:20'),
(163, 0, 'Generate Inventory Report', 'admin', '2016-10-10 00:49:25'),
(164, 0, 'Login', 'admin', '2016-10-10 00:51:30'),
(165, 0, 'Generate Inventory Report', 'admin', '2016-10-10 00:51:40'),
(166, 0, 'Login', 'admin', '2016-10-10 00:52:38'),
(167, 0, 'Generate Inventory Report', 'admin', '2016-10-10 00:52:42'),
(168, 0, 'Login', 'admin', '2016-10-10 00:54:26'),
(169, 0, 'Generate Inventory Report', 'admin', '2016-10-10 00:54:31'),
(170, 0, 'Login', 'admin', '2016-10-10 00:56:15'),
(171, 0, 'Generate Inventory Report', 'admin', '2016-10-10 00:56:23'),
(172, 0, 'Login', 'admin', '2016-10-10 00:59:10'),
(173, 0, 'Generate Inventory Report', 'admin', '2016-10-10 00:59:14'),
(174, 0, 'Login', 'admin', '2016-10-10 01:00:41'),
(175, 0, 'Generate Sales Report', 'admin', '2016-10-10 01:00:50'),
(176, 0, 'Generate Activity Report', 'admin', '2016-10-10 01:01:40'),
(177, 0, 'Generate Inventory Report', 'admin', '2016-10-10 01:02:36'),
(178, 0, 'Login', 'admin', '2016-10-10 01:03:06'),
(179, 0, 'Login', 'delta', '2016-10-10 01:04:31'),
(180, 0, 'Generate Inventory Report', 'delta', '2016-10-10 01:04:35'),
(181, 0, 'Login', 'admin', '2016-10-10 15:57:10'),
(182, 0, 'Search Product :smart', 'admin', '2016-10-10 15:57:42'),
(183, 0, 'Search Product :none', 'admin', '2016-10-10 15:58:00'),
(184, 0, 'Adding new User: ManageUsers', 'admin', '2016-10-10 16:01:56'),
(185, 0, 'Update Employee :catindig', 'admin', '2016-10-10 16:02:02'),
(186, 0, 'Login', 'korgx', '2016-10-10 16:02:29'),
(187, 0, 'Generate Inventory Report', 'korgx', '2016-10-10 16:02:53'),
(188, 0, 'Login', 'admin', '2016-10-10 16:04:15'),
(189, 0, 'Generate Activity Report', 'admin', '2016-10-10 16:04:26'),
(190, 0, 'Search Product :1', 'admin', '2016-10-10 16:06:49'),
(191, 0, 'Search Product :2', 'admin', '2016-10-10 16:06:53'),
(192, 0, 'Search Product :3', 'admin', '2016-10-10 16:06:56'),
(193, 0, 'Login', 'admin', '2016-10-10 16:09:19'),
(194, 0, 'Login', 'admin', '2016-10-10 16:14:17'),
(195, 0, 'Generate Inventory Report', 'admin', '2016-10-10 16:15:21'),
(196, 0, 'Generate Sales Report', 'admin', '2016-10-10 16:15:50'),
(197, 0, 'Generate Activity Report', 'admin', '2016-10-10 16:16:04'),
(198, 0, 'Login', 'korgx', '2016-10-10 16:20:35'),
(199, 0, 'Login', 'admin', '2016-10-14 10:36:23'),
(200, 0, 'Login', 'admin', '2016-10-14 13:04:43'),
(201, 0, 'Login', 'admin', '2016-10-14 16:40:46');

-- --------------------------------------------------------

--
-- Table structure for table `branch`
--

CREATE TABLE IF NOT EXISTS `branch` (
  `branchID` int(10) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Branch_Name` varchar(30) NOT NULL,
  `ContactNumber` varchar(15) NOT NULL,
  `Email` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `branch`
--

INSERT INTO `branch` (`branchID`, `Address`, `Branch_Name`, `ContactNumber`, `Email`) VALUES
(1, 'Davao City', 'Altech Davao', '0909090909', 'altechDavao@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE IF NOT EXISTS `client` (
  `ClientID` int(20) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `ContactNumber` varchar(15) NOT NULL,
  `Email` varchar(30) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`ClientID`, `Name`, `Address`, `ContactNumber`, `Email`) VALUES
(0, 'none', 'none', '0', 'none'),
(1, 'Jahdiel Villosa', 'Tugbok, Davao City', '09476629610', 'jahdielvillosa@gmail.com'),
(3, 'julie', 'mintal', '091234567', 'lieju@gmail.com'),
(4, 'alpha user', 'mintal DC', '1234123', 'hello@gmail.com'),
(6, 'cordova1', 'Matina, DC1', '0912344451', 'cordova@gmail.com1');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE IF NOT EXISTS `product` (
  `SerialNumber` varchar(20) NOT NULL,
  `Product` varchar(20) NOT NULL,
  `Model` varchar(30) NOT NULL,
  `Accessories` varchar(20) NOT NULL,
  `Qty` int(11) NOT NULL,
  `Price` float NOT NULL,
  `Sup_Name` varchar(30) NOT NULL,
  `DeliveryDate` varchar(30) NOT NULL,
  `WarrantyDate_Supplier` varchar(30) NOT NULL,
  `WarrantyDate_Client` varchar(30) NOT NULL,
  `Problem` varchar(30) NOT NULL,
  `itemStatus` varchar(15) NOT NULL,
  `isObsolete` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`SerialNumber`, `Product`, `Model`, `Accessories`, `Qty`, `Price`, `Sup_Name`, `DeliveryDate`, `WarrantyDate_Supplier`, `WarrantyDate_Client`, `Problem`, `itemStatus`, `isObsolete`) VALUES
('0313157065484162', 'Broadband Sim', 'Smart Broadband 3G', 'none', 1, 250, 'smart', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', 'none', 'available', 0),
('1', 'Flash Drive', 'Scan Disk 16GB', 'none', 0, 150, 'smart', '2016-08-28 00:00:00', '2018-08-28 00:00:00', '2017-10-08 20:13:24', 'none', 'Purchased', 0),
('2', 'mouse', 'acer mouse', 'none', 1, 120, 'smart', '2016-08-31 00:00:00', '2018-08-31 00:00:00', '2017-08-31 00:00:00', 'broken', 'returned', 0),
('3', 'keyboard', 'asus keyboard', 'none', 1, 250, 'smart', '2016-08-31 00:00:00', '2018-08-31 00:00:00', '2017-09-26 15:05:05', 'broken', 'returned', 0),
('4', 'soldering iron', 'tech1', 'none', 5, 150, 'none', '2016-09-09 00:00:00', '2018-09-09 00:00:00', '2017-09-25 15:11:00', 'none', 'available', 0);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE IF NOT EXISTS `supplier` (
  `Sup_Name` varchar(30) NOT NULL,
  `Sup_Email` varchar(30) NOT NULL,
  `Sup_ContactNum` varchar(15) NOT NULL,
  `Sup_Address` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`Sup_Name`, `Sup_Email`, `Sup_ContactNum`, `Sup_Address`) VALUES
('globe', 'none', '0983498357', 'globe@gmail.com'),
('hello', 'none', '09870894', 'hello world'),
('none', 'none@gmail.com', 'none', 'none'),
('smart', 'roxas ave.', '098123123', 'smart@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE IF NOT EXISTS `transaction` (
  `TransactionID` int(20) NOT NULL,
  `ClientID` int(10) NOT NULL,
  `Date` varchar(30) NOT NULL,
  `Boxes` int(5) NOT NULL,
  `Cost` float NOT NULL,
  `TransactionType` varchar(20) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`TransactionID`, `ClientID`, `Date`, `Boxes`, `Cost`, `TransactionType`) VALUES
(25, 0, '2016-09-21 12:15:47', 1, 1500, 'Purchase'),
(26, 0, '2016-09-21 12:15:47', 1, 1500, 'Purchase'),
(28, 0, '2016-09-21 12:15:47', 1, 150, 'Purchase'),
(29, 0, '2016-09-21 12:15:47', 1, 150, 'Purchase'),
(30, 0, '2016-09-22 12:15:47', 1, 120, 'Purchase'),
(31, 0, '2016-09-22 12:15:47', 1, 150, 'Purchase'),
(32, 0, '2016-09-22 12:15:47', 1, 150, 'Purchase'),
(33, 0, '2016-09-22 12:15:47', 1, 270, 'Purchase'),
(34, 0, '2016-09-23 12:15:47', 1, 250, 'Purchase'),
(35, 0, '2016-09-23 12:15:47', 1, 120, 'Purchase'),
(36, 0, '2016-09-23 12:15:47', 1, 106, 'Purchase'),
(37, 0, '2016-09-23 12:15:47', 1, 131, 'Purchase'),
(38, 0, '2016-09-23 12:15:47', 1, 150, 'Purchase'),
(39, 0, '2016-09-23 12:15:47', 1, 131, 'Purchase'),
(40, 0, '2016-09-24 12:15:47', 1, 130.5, 'Purchase'),
(41, 0, '2016-09-24 12:15:47', 2, 255.6, 'Purchase'),
(42, 0, '2016-09-24 12:15:47', 2, 255.6, 'Purchase'),
(43, 0, '2016-09-24 12:15:47', 3, 478, 'Purchase'),
(44, 0, '2016-09-24 12:15:47', 1, 150, 'Purchase'),
(45, 0, '2016-09-25 14:15:47', 1, 120, 'Purchase'),
(46, 0, '2016-09-25 14:23:40', 1, 150, 'Purchase'),
(47, 0, '2016-09-25 14:26:43', 1, 150, 'Purchase'),
(48, 0, '2016-09-25 15:11:00', 1, 150, 'Purchase'),
(49, 1, '2016-09-25 15:12:34', 1, 0, 'Return Item'),
(50, 0, '2016-09-26 15:03:29', 1, 150, 'Purchase'),
(51, 1, '2016-09-26 15:04:00', 1, 0, 'Return Item'),
(52, 0, '2016-09-26 15:05:05', 1, 250, 'Purchase'),
(53, 0, '2016-10-08 19:02:31', 1, 150, 'Purchase'),
(54, 0, '2016-10-08 19:04:23', 1, 0, 'Return Item'),
(55, 0, '2016-10-08 20:11:55', 1, 0, 'Return Item'),
(56, 0, '2016-10-08 20:13:24', 1, 150, 'Purchase');

-- --------------------------------------------------------

--
-- Table structure for table `trans_purchase`
--

CREATE TABLE IF NOT EXISTS `trans_purchase` (
  `PurchaseID` int(10) NOT NULL,
  `SerialNumber` varchar(20) NOT NULL,
  `Discount` int(5) NOT NULL,
  `SubTotal` float NOT NULL,
  `TransactionID` int(15) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `trans_purchase`
--

INSERT INTO `trans_purchase` (`PurchaseID`, `SerialNumber`, `Discount`, `SubTotal`, `TransactionID`) VALUES
(7, '1', 0, 150, 38),
(8, '1', 13, 130.5, 39),
(9, '1', 13, 130.5, 40),
(10, '2', 12, 105.6, 41),
(11, '1', 0, 150, 42),
(12, '3', 12, 220, 43),
(13, '2', 10, 108, 43),
(14, '1', 0, 150, 43),
(15, '1', 0, 150, 44),
(16, '2', 0, 120, 45),
(17, '1', 0, 150, 46),
(18, '1', 0, 150, 47),
(19, '4', 0, 150, 48),
(20, '1', 0, 150, 50),
(21, '3', 0, 250, 52),
(22, '1', 0, 150, 53),
(23, '1', 0, 150, 56);

-- --------------------------------------------------------

--
-- Table structure for table `trans_return`
--

CREATE TABLE IF NOT EXISTS `trans_return` (
  `returnID` int(10) NOT NULL,
  `SerialNumber` varchar(20) NOT NULL,
  `Problem` varchar(50) NOT NULL,
  `TransactionID` int(10) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `trans_return`
--

INSERT INTO `trans_return` (`returnID`, `SerialNumber`, `Problem`, `TransactionID`) VALUES
(1, '1', 'not working', 47),
(2, '4', 'not working', 49),
(3, '1', 'broken', 51),
(4, '1', 'none', 54),
(5, '3', 'broken', 55);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `Username` varchar(30) NOT NULL,
  `Password` varchar(70) NOT NULL,
  `Permission` int(5) NOT NULL,
  `Emp_Name` varchar(50) NOT NULL,
  `Emp_Position` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Username`, `Password`, `Permission`, `Emp_Name`, `Emp_Position`) VALUES
('admin', '1139724858BB08F005AF7851CF919229', 1, 'Jahdiel Villosa', 'Manager'),
('asdasd', '8uZij+jpfN1AbuWiAUTYxxgJe5KiUl+7ffyNVmuGCcM=', 2, 'Beta Tester', 'Employee'),
('delta', '63BCABF86A9A991864777C631C5B7617', 2, 'Delta Employee', 'Employee'),
('helloworld', '5D41402ABC4B2A76B9719D911017C592', 2, 'Alpha Tester', 'Employee'),
('korgx', 'BF9D8483876F9EBF2959D0AE874CCFB2', 2, 'catindig', 'Manager');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `activity`
--
ALTER TABLE `activity`
  ADD PRIMARY KEY (`ActivityID`), ADD KEY `username` (`username`);

--
-- Indexes for table `branch`
--
ALTER TABLE `branch`
  ADD PRIMARY KEY (`branchID`);

--
-- Indexes for table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`ClientID`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`SerialNumber`), ADD KEY `SupplierName` (`Sup_Name`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`Sup_Name`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`TransactionID`), ADD KEY `ClientID` (`ClientID`);

--
-- Indexes for table `trans_purchase`
--
ALTER TABLE `trans_purchase`
  ADD PRIMARY KEY (`PurchaseID`), ADD KEY `TransactionID` (`TransactionID`), ADD KEY `SerialNumber` (`SerialNumber`);

--
-- Indexes for table `trans_return`
--
ALTER TABLE `trans_return`
  ADD PRIMARY KEY (`returnID`), ADD KEY `SerialNumber` (`SerialNumber`), ADD KEY `TransactionID` (`TransactionID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `activity`
--
ALTER TABLE `activity`
  MODIFY `ActivityID` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=202;
--
-- AUTO_INCREMENT for table `client`
--
ALTER TABLE `client`
  MODIFY `ClientID` int(20) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `transaction`
--
ALTER TABLE `transaction`
  MODIFY `TransactionID` int(20) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=57;
--
-- AUTO_INCREMENT for table `trans_purchase`
--
ALTER TABLE `trans_purchase`
  MODIFY `PurchaseID` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=24;
--
-- AUTO_INCREMENT for table `trans_return`
--
ALTER TABLE `trans_return`
  MODIFY `returnID` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=6;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `activity`
--
ALTER TABLE `activity`
ADD CONSTRAINT `activity_ibfk_1` FOREIGN KEY (`username`) REFERENCES `users` (`Username`);

--
-- Constraints for table `product`
--
ALTER TABLE `product`
ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`Sup_Name`) REFERENCES `supplier` (`Sup_Name`);

--
-- Constraints for table `transaction`
--
ALTER TABLE `transaction`
ADD CONSTRAINT `transaction_ibfk_1` FOREIGN KEY (`ClientID`) REFERENCES `client` (`ClientID`);

--
-- Constraints for table `trans_purchase`
--
ALTER TABLE `trans_purchase`
ADD CONSTRAINT `trans_purchase_ibfk_1` FOREIGN KEY (`SerialNumber`) REFERENCES `product` (`SerialNumber`),
ADD CONSTRAINT `trans_purchase_ibfk_2` FOREIGN KEY (`TransactionID`) REFERENCES `transaction` (`TransactionID`);

--
-- Constraints for table `trans_return`
--
ALTER TABLE `trans_return`
ADD CONSTRAINT `trans_return_ibfk_1` FOREIGN KEY (`SerialNumber`) REFERENCES `product` (`SerialNumber`),
ADD CONSTRAINT `trans_return_ibfk_2` FOREIGN KEY (`TransactionID`) REFERENCES `transaction` (`TransactionID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
