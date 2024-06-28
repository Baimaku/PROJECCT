-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 28, 2024 at 06:24 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `login`
--

-- --------------------------------------------------------

--
-- Table structure for table `votersdata`
--

CREATE TABLE `votersdata` (
  `id` int(11) NOT NULL,
  `username` varchar(20) NOT NULL,
  `votecount` int(255) NOT NULL,
  `president` varchar(20) NOT NULL,
  `vp` varchar(20) NOT NULL,
  `secretary` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `votersdata`
--

INSERT INTO `votersdata` (`id`, `username`, `votecount`, `president`, `vp`, `secretary`) VALUES
(1, 'Laco', 1, 'IMOT', '', ''),
(4, 'ada', 1, '1', '', ''),
(5, 'ada', 1, '1', '', ''),
(6, '123', 1, '4', '', ''),
(7, 'brt brt', 1, '3', '', ''),
(8, '', 1, 'OFFICIAL 1', '', ''),
(9, '', 1, 'OFFICIAL 1', '', ''),
(10, '', 1, 'OFFICIAL 1', '', ''),
(11, '', 1, 'OFFICIAL 1', '', ''),
(12, '', 1, 'OFFICIAL 4', '', ''),
(13, '', 1, 'OFFICIAL 1', '', ''),
(14, '', 1, 'OFFICIAL 4', '', ''),
(15, '', 1, 'OFFICIAL 3', '', ''),
(16, '', 1, 'OFFICIAL 3', '', ''),
(17, '', 1, 'OFFICIAL 3', '', ''),
(18, '', 1, '', 'OFFICIAL 4', ''),
(19, '', 1, '', '', 'OFFICIAL 3'),
(20, '', 1, 'OFFICIAL 1', '', ''),
(21, '', 1, '', 'OFFICIAL 1', ''),
(22, '', 1, '', '', 'OFFICIAL 1');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `votersdata`
--
ALTER TABLE `votersdata`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `votersdata`
--
ALTER TABLE `votersdata`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
