-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: Apr 08, 2022 at 10:37 AM
-- Server version: 5.7.32
-- PHP Version: 7.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `TheInventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `chemical`
--

CREATE TABLE `chemical` (
  `id` int(10) NOT NULL,
  `location_id` int(10) NOT NULL,
  `name` varchar(255) NOT NULL,
  `quantity` int(11) NOT NULL,
  `cost` int(11) NOT NULL,
  `state` varchar(255) NOT NULL,
  `catergory` varchar(255) NOT NULL,
  `image` varchar(255) NOT NULL,
  `access_key` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `chemical`
--

INSERT INTO `chemical` (`id`, `location_id`, `name`, `quantity`, `cost`, `state`, `catergory`, `image`, `access_key`) VALUES
(9, 1, 'Hydrogen', 8, 1, 'gas', 'raw', 'H', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(10, 1, 'Carbon', 0, 10, 'solid', 'raw', 'C', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(11, 1, 'Oxygen', 21, 5, 'gas', 'raw', 'O2', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(12, 1, 'Sulfur', 9, 20, 'solid', 'raw', 'S', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(13, 1, 'Iron', 4, 100, 'solid', 'raw', 'Fe', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(14, 1, 'Nitrogen', 3, 10, 'gas', 'raw', 'N', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(15, 1, 'Nickel', 4, 17, 'solid', 'raw', 'Ni', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(16, 1, 'Copper', 7, 12, 'solid', 'raw', 'Cu', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(17, 1, 'Zinc', 34, 9, 'solid', 'raw', 'Zn', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(18, 1, 'Tin', 22, 9, 'solid', 'raw', 'Sn', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(19, 1, 'Chromium', 18, 15, 'solid', 'raw', 'Cr', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(20, 1, 'Chlorine', 30, 30, 'gas', 'raw', 'Cl', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(21, 2, 'Hydrogen', 100, 1, 'gas', 'raw', 'H', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(22, 2, 'Carbon', 50, 10, 'solid', 'raw', 'C', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(23, 2, 'Oxygen', 50, 5, 'gas', 'raw', 'O2', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(24, 2, 'Sulfur', 10, 20, 'solid', 'raw', 'S', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(25, 2, 'Iron', 80, 100, 'solid', 'raw', 'Fe', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(26, 2, 'Nitrogen', 50, 10, 'gas', 'raw', 'N', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(27, 2, 'Nickel', 50, 17, 'solid', 'raw', 'Ni', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(28, 2, 'Copper', 70, 12, 'solid', 'raw', 'Cu', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(29, 2, 'Zinc', 10, 9, 'solid', 'raw', 'Zn', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(30, 2, 'Tin', 10, 9, 'solid', 'raw', 'Sn', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(31, 2, 'Chromium', 20, 15, 'solid', 'raw', 'Cr', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(32, 2, 'Chlorine', 30, 30, 'gas', 'raw', 'Cl', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(33, 3, 'Hydrogen', 97, 1, 'gas', 'raw', 'H', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(34, 3, 'Carbon', 50, 10, 'solid', 'raw', 'C', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(35, 3, 'Oxygen', 45, 5, 'gas', 'raw', 'O2', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(36, 3, 'Sulfur', 0, 20, 'solid', 'raw', 'S', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(37, 3, 'Iron', 80, 100, 'solid', 'raw', 'Fe', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(38, 3, 'Nitrogen', 50, 10, 'gas', 'raw', 'N', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(39, 3, 'Nickel', 50, 17, 'solid', 'raw', 'Ni', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(40, 3, 'Copper', 70, 12, 'solid', 'raw', 'Cu', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(41, 3, 'Zinc', 10, 9, 'solid', 'raw', 'Zn', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(42, 3, 'Tin', 10, 9, 'solid', 'raw', 'Sn', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(43, 3, 'Chromium', 20, 15, 'solid', 'raw', 'Cr', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(44, 3, 'Chlorine', 30, 30, 'gas', 'raw', 'Cl', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(48, 1, 'Carbon Dioxide', 15, 50, 'gas', 'compound', 'CO2', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(49, 1, 'Nitinol', 1, 50, 'solid', 'compound', 'NiTi', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(50, 1, 'Sulfuric Acid', 3, 50, 'liquid', 'compound', 'H2SO4', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(51, 1, 'Stainless Steel', 4, 50, 'solid', 'compound', 'FeCCrNi', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(52, 1, 'Water', 5, 50, 'liquid', 'compound', 'H2O', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(53, 1, 'Hydrochloric acid', 2, 50, 'liquid', 'compound', 'HCl', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(54, 1, 'Nitrous Oxide', 1, 50, 'gas', 'compound', 'NO2', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(55, 1, 'Brass', 1, 50, 'solid', 'compound', 'ZnCu', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(57, 2, 'Water', 1, 50, 'liquid', 'compound', 'H2O', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(58, 3, 'Stainless Steel', 1, 50, 'solid', 'compound', 'FeCCrNi', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(59, 3, 'Water', 1, 50, 'liquid', 'compound', 'H2O', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(60, 3, 'Sulfuric Acid', 1, 50, 'liquid', 'compound', 'H2SO4', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(61, 1, 'Acetylene', 1, 50, 'gas', 'compound', 'C2H2', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(62, 1, 'Uranium', 20, 7500, 'solid', 'radioactive', 'U', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(63, 2, 'Uranium', 20, 7500, 'solid', 'radioactive', 'U', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(64, 3, 'Uranium', 20, 7500, 'solid', 'radioactive', 'U', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(65, 1, 'Plutonium', 100, 90000, 'solid', 'radioactive', 'Pu', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(66, 2, 'Plutonium', 11, 90000, 'solid', 'radioactive', 'Pu', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(67, 3, 'Plutonium', 11, 90000, 'solid', 'radioactive', 'Pu', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(68, 1, 'Radium', 125, 5000, 'solid', 'radioactive', 'Ra', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(69, 2, 'Radium', 25, 5000, 'solid', 'radioactive', 'Ra', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(70, 3, 'Radium', 25, 5000, 'solid', 'radioactive', 'Ra', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(71, 1, 'Radon', 29, 1000, 'solid', 'radioactive', 'Rn', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(72, 2, 'Radon', 30, 1000, 'solid', 'radioactive', 'Rn', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(73, 3, 'Radon', 30, 1000, 'solid', 'radioactive', 'Rn', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(74, 1, 'Plutonium-244', 1, 50, 'solid', 'isotope', 'Pu-244', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(75, 1, 'Butane', 1, 50, 'gas', 'compound', 'C4H10', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(76, 1, 'Plutonium-239', 1, 50, 'solid', 'isotope', 'Pu-239', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(77, 1, 'Radon-228', 1, 50, 'solid', 'isotope', 'Rn-228', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(78, 1, 'Propane', 2, 50, 'gas', 'compound', 'C3H8', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220');

-- --------------------------------------------------------

--
-- Table structure for table `location`
--

CREATE TABLE `location` (
  `id` int(10) NOT NULL,
  `name` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `money` int(11) NOT NULL,
  `location_active` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `location`
--

INSERT INTO `location` (`id`, `name`, `address`, `money`, `location_active`) VALUES
(1, 'Chernobyl', 'Kyiv Oblast, Ukraine', 2292, 0),
(2, 'Koeberg', 'Cape Farms, Cape Town', 5000, 0),
(3, 'Muruntau', 'Kyzyl Kum Desert, Uzbekistan', 7000, 1);

-- --------------------------------------------------------

--
-- Table structure for table `reaction`
--

CREATE TABLE `reaction` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `chemical_one` varchar(255) DEFAULT NULL,
  `chemical_one_quantity` int(11) DEFAULT NULL,
  `chemical_two` varchar(255) DEFAULT NULL,
  `chemical_two_quantity` int(11) DEFAULT NULL,
  `chemical_three` varchar(255) DEFAULT NULL,
  `chemical_three_quantity` int(11) DEFAULT NULL,
  `chemical_four` varchar(255) DEFAULT NULL,
  `chemical_four_quantity` int(11) DEFAULT NULL,
  `chemical_five` varchar(255) NOT NULL,
  `chemical_five_quantity` int(11) NOT NULL,
  `chemical_six` varchar(255) NOT NULL,
  `chemical_six_quantity` int(11) NOT NULL,
  `payment` int(11) NOT NULL,
  `image` varchar(255) NOT NULL,
  `state` varchar(255) NOT NULL,
  `category` varchar(255) NOT NULL,
  `access_key` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `reaction`
--

INSERT INTO `reaction` (`id`, `name`, `chemical_one`, `chemical_one_quantity`, `chemical_two`, `chemical_two_quantity`, `chemical_three`, `chemical_three_quantity`, `chemical_four`, `chemical_four_quantity`, `chemical_five`, `chemical_five_quantity`, `chemical_six`, `chemical_six_quantity`, `payment`, `image`, `state`, `category`, `access_key`) VALUES
(1, 'Carbon Dioxide', 'Carbon', 1, 'Oxygen', 2, '', 0, '', 0, '', 0, '', 0, 20, 'CO2', 'gas', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(2, 'Water', 'Hydrogen', 2, 'Oxygen', 1, '', 0, '', 0, '', 0, '', 0, 50, 'H2O', 'liquid', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(6, 'Sulfuric Acid', 'Hydrogen', 4, 'Sulfur', 1, 'Oxygen', 4, '', 0, '', 0, '', 0, 23, 'H2SO4', 'liquid', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(7, 'Ethylene', 'Carbon', 2, 'Hydrogen', 4, '', 0, '', 0, '', 0, '', 0, 54, 'C2H4', 'liquid', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(10, 'Sodium Hydroxide', 'Soduim', 1, 'Oxygen', 1, 'Hydrogen', 1, '', 0, '', 0, '', 0, 32, 'NaOH', 'liquid', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(11, 'Propylene', 'Carbon', 3, 'Hydrogen', 6, '', 0, '', 0, '', 0, '', 0, 76, 'C3H6', 'gas', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(16, 'Nitrous Oxide', 'Nitrogen', 2, 'Oxygen', 1, '', 0, '', 0, '', 0, '', 0, 73, 'NO2', 'gas', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(17, 'Hydrochloric acid', 'Hydrogen', 1, 'Chlorine', 1, '', 0, '', 0, '', 0, '', 0, 72, 'HCl', 'liquid', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(19, 'Brass', 'Copper', 1, 'Zinc', 1, '', 0, '', 0, '', 0, '', 0, 23, 'ZnCu', 'solid', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(20, 'Bronze', 'Copper', 1, 'Tin', 1, '', 0, '', 0, '', 0, '', 0, 76, 'ZnSn', 'solid', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(21, 'Stainless Steel', 'Iron', 1, 'Carbon', 1, 'Chromium', 1, 'Nickel', 1, '', 0, '', 0, 100, 'FeCCrNi', 'solid', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(22, 'Nickel Steel', 'Iron', 1, 'Nickel', 1, '', 0, '', 0, '', 0, '', 0, 34, 'FeNi', 'solid', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(23, 'Carbon Steel', 'Iron', 1, 'Nickel', 1, '', 0, '', 0, '', 0, '', 0, 15, 'CFe', 'solid', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(24, 'Nitinol', 'Nickel', 1, 'Titanium', 1, '', 0, '', 0, '', 0, '', 0, 64, 'NiTi', 'solid', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(25, 'Oxygen', 'Oxygen', 2, '', 0, '', 0, '', 0, '', 0, '', 0, 13, 'O2', 'gas', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(26, 'Acetylene', 'Carbon', 2, 'Hydrogen', 2, '', 0, '', 0, '', 0, '', 0, 53, 'C2H2', 'gas', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(27, 'Propane', 'Carbon', 3, 'Hydrogen', 8, '', 0, '', 0, '', 0, '', 0, 62, 'C3H8', 'gas', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(28, 'Butane', 'Carbon', 4, 'Hydrogen', 10, '', 0, '', 0, '', 0, '', 0, 36, 'C4H10', 'gas', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(29, 'Nitrous Oxide', 'Nitrogen', 1, 'Oxygen', 2, '', 0, '', 0, '', 0, '', 0, 36, 'NO2', 'gas', 'compound', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(30, 'Uranium-235', 'Uranium', 1, '', 0, '', 0, '', 0, '', 0, '', 0, 10000, 'U-235', 'solid', 'isotope', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(31, 'Uranium-238', 'Uranium', 2, '', 0, '', 0, '', 0, '', 0, '', 0, 20000, 'U-238', 'solid', 'isotope', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(32, 'Plutonium-244', 'Plutonium', 1, '', 0, '', 0, '', 0, '', 0, '', 0, 91000, 'Pu-244', 'solid', 'isotope', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(33, 'Plutonium-239', 'Plutonium', 5, '', 0, '', 0, '', 0, '', 0, '', 0, 500000, 'Pu-239', 'solid', 'isotope', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(34, 'Radium-226', 'Radium', 1, '', 0, '', 0, '', 0, '', 0, '', 0, 7000, 'Ra-226', 'solid', 'isotope', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(35, 'Radium-234', 'Radium', 8, '', 0, '', 0, '', 0, '', 0, '', 0, 50000, 'Ra-234', 'solid', 'isotope', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(36, 'Radon-211', 'Radon', 1, '', 0, '', 0, '', 0, '', 0, '', 0, 2000, 'Rn-211', 'solid', 'isotope', 'b3813d818be9a849d138783c3a2236d8dc9b2373'),
(37, 'Radon-228', 'Radon', 17, '', 0, '', 0, '', 0, '', 0, '', 0, 20000, 'Rn-228', 'solid', 'isotope', 'b3813d818be9a849d138783c3a2236d8dc9b2373');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `chemical`
--
ALTER TABLE `chemical`
  ADD PRIMARY KEY (`id`),
  ADD KEY `location_id` (`location_id`);

--
-- Indexes for table `location`
--
ALTER TABLE `location`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `reaction`
--
ALTER TABLE `reaction`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `chemical`
--
ALTER TABLE `chemical`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=79;

--
-- AUTO_INCREMENT for table `location`
--
ALTER TABLE `location`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `reaction`
--
ALTER TABLE `reaction`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
