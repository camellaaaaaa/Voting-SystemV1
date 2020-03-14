-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 14, 2020 at 08:08 PM
-- Server version: 10.3.16-MariaDB
-- PHP Version: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vms`
--

-- --------------------------------------------------------

--
-- Table structure for table `added_voter_logs`
--

CREATE TABLE `added_voter_logs` (
  `voters_id` int(11) NOT NULL,
  `first_name` varchar(255) NOT NULL,
  `middle` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `date_created` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `course` varchar(255) NOT NULL,
  `year` varchar(255) NOT NULL,
  `section` varchar(255) NOT NULL,
  `student_number` varchar(255) NOT NULL,
  `status` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `added_voter_logs`
--

INSERT INTO `added_voter_logs` (`voters_id`, `first_name`, `middle`, `last_name`, `date_created`, `course`, `year`, `section`, `student_number`, `status`) VALUES
(1, '', 'B', 'B', '2020-02-21 16:37:45', 'Pelayo', '5', '5', 'Camille', 0),
(2, '', 'E', 'E', '2020-02-21 16:43:09', 'Jimenez', '5', '5', '201400637MN0', 0),
(3, '', 'E', 'E', '2020-02-21 16:43:15', 'Jimenez', '5', '5', '201400637MN0', 0),
(4, '', '', '', '2020-02-21 16:49:25', '', '', '', '20150396', 0),
(5, 'hjhj', '', '', '2020-02-21 17:02:20', '', '', '', '', 0),
(6, 'hjhj', '', '', '2020-02-21 17:02:31', 'jhjh', '', '', '', 0),
(7, 'hjhj', '', '', '2020-02-21 17:02:38', 'jhjh', '', '', '', 0),
(8, '', '', 'dsd', '2020-02-21 18:15:24', '', '', '', '', 0),
(9, '', '', '', '2020-02-21 18:24:48', '', '', '', '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `candidate`
--

CREATE TABLE `candidate` (
  `candidate_id` int(11) NOT NULL,
  `party_name` varchar(255) NOT NULL,
  `position` varchar(255) NOT NULL,
  `first_name` varchar(255) NOT NULL,
  `middle` varchar(2) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `full_name` varchar(255) NOT NULL,
  `year` varchar(255) NOT NULL,
  `section` varchar(255) NOT NULL,
  `course` varchar(255) NOT NULL,
  `date_created` timestamp(6) NOT NULL DEFAULT current_timestamp(6) ON UPDATE current_timestamp(6),
  `vote` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `candidate`
--

INSERT INTO `candidate` (`candidate_id`, `party_name`, `position`, `first_name`, `middle`, `last_name`, `full_name`, `year`, `section`, `course`, `date_created`, `vote`) VALUES
(1, 'LEADERS', '2nd Year Governor', 'Camille Anne', 'B', 'Pelayo', 'Camille Anne B Pelayo', 'BSCPE', '5', 'BSCPE', '2020-03-14 19:00:46.298716', 1),
(2, 'LEADERS', '3rd Year Governor', 'Jonathan', 'E', 'Jimenez', 'Jonathan E Jimenez', 'BSCPE', '5', 'BSCPE', '2020-03-14 19:00:54.320948', 1),
(4, 'LEADERS', '4th Year Governor', 'Diane', 'E', 'Indfante', 'Diane E Indfante', 'BSCPE', '5', 'BSCPE', '2020-03-14 19:02:14.411681', 1),
(5, 'LEADERS', '5th Year Governor', 'Hello', 'J', 'World', 'Hello J World', 'BSCPE', '1', 'BSCPE', '2020-03-14 19:02:14.473377', 1),
(6, 'LEADERS', 'Auditor', 'Mine', 'M', 'Mine', 'Mine M Mine', 'BSCPE', '5', 'BSCPE', '2020-03-14 19:02:14.505919', 1),
(7, 'LEADERS', 'Business Manager', 'Jessica', 'J', 'Jessie', 'Jessica J Jessie', 'BSCPE', '2', 'BSCPE', '2020-03-14 19:02:14.564655', 1),
(8, 'LEADERS', 'Control Officer', 'Mama', 'E', 'Moo', 'Mama E Moo', 'BSCPE', '1', 'BSCPE', '2020-03-14 19:02:14.620356', 1),
(9, 'LEADERS', 'Executive Vice President', 'Justin', 'M', 'Maramot', 'Justin M Maramot', 'BSCPE', '2', 'BSCPE', '2020-03-14 19:02:14.650295', 1),
(10, 'LEADERS', 'Head Governor', 'World', 'P', 'Hello', 'World P Hello', '5', '5', 'BSCPE', '2020-03-14 19:02:14.687258', 1),
(11, 'LEADERS', 'President', 'Jambo', 'Z', 'Hotdog', 'Jambo Z Hotdog', 'BSCPE', '4', 'BSCPE', '2020-03-14 19:02:14.717160', 1),
(12, 'LEADERS', 'Secretary General', 'Mama', 'B', 'Cat', 'Mama B Cat', 'BSCPE', '5', 'BSCPE', '2020-03-14 19:02:14.789832', 1),
(13, 'LEADERS', 'Treasurer ', 'Thank', 'U', 'Next', 'Thank U Next', 'BSCPE', '1', 'BSCPE', '2020-03-14 19:02:14.830754', 1),
(14, 'LEADERS', 'Vice President for Academic Affairs', 'Jaime', 'E', 'Jimenez', 'Jaime E Jimenez', 'ITECH', '2', 'ITECH', '2020-03-14 19:02:14.931468', 1),
(15, 'LEADERS', 'Vice President for Organization Relation', 'Teka ', 'A', 'Lang', 'Teka  A Lang', 'ITECH', '2', 'ITECH', '2020-03-14 18:53:44.397283', 40),
(16, 'LEADERS', 'Vice President for Research and Development', 'Bear', 'N', 'Brand', 'Bear N Brand', 'BSCPE', '2', 'BSCPE', '2020-03-14 18:53:44.397283', 40),
(17, 'LEADERS', 'Vice President for Student Affairs', 'Hey', 'S', 'Sister', 'Hey S Sister', 'BSCPE', '2', 'BSCPE', '2020-03-14 18:53:44.397283', 40),
(18, 'PARTY', '2nd Year Governor', 'Project', 'M', 'File', 'Project M File', '2', '2', 'BSCPE', '2020-03-14 18:54:27.962545', 2),
(19, 'PARTY', '3rd Year Governor', 'HighSchool', '', 'Musical', 'HighSchool  Musical', '3', '3', 'BSCPE', '2020-03-14 18:54:27.962545', 2),
(20, 'PARTY', '4th Year Governor', 'User', '', 'Candidate', 'User  Candidate', '5', '5', 'BSCPE', '2020-03-14 18:54:27.962545', 2),
(21, 'PARTY', '4th Year Governor', 'Hello', 'B', 'Morning', 'Hello B Morning', '4', '3\r\n3', 'BSCPE', '2020-03-14 18:54:27.962545', 1),
(22, 'PARTY', '5th Year Governor', 'Colyn', '', 'Atencio', 'Colyn  Atencio', '5', '5', 'BSCPE', '2020-03-14 18:54:27.962545', 2),
(23, 'PARTY', 'Auditor', 'Mabon', '', 'Ocliaso', 'Mabon  Ocliaso', '5', '5', 'BSCPE', '2020-03-14 18:54:27.962545', 2),
(24, 'PARTY', 'Business Manager', 'Corewin', '', 'Toral', 'Corewin  Toral', '5', '5', 'BSCPE', '2020-03-14 18:54:27.962545', 2),
(25, 'PARTY', 'Control Officer', 'Jorly', '5', 'Pajabera', 'Jorly 5 Pajabera', '5', 'FS1N', 'BSCPE', '2020-03-14 18:54:27.962545', 2),
(26, 'PARTY', 'Executive Vice President', 'Cameron', '', 'Diaz', 'Cameron  Diaz', '5', '2', 'BSCPE', '2020-03-14 18:54:27.962545', 2),
(27, 'PARTY', 'Head Governor', 'Ji Chang', 'E', 'Wook', 'Ji Chang E Wook', '6', '4', 'BSCPE', '2020-03-14 18:54:27.962545', 2),
(28, 'PARTY', 'President', 'Hazel', '', 'Maramot', 'Hazel  Maramot', '5', '5', 'BSCPE', '2020-03-14 18:54:27.962545', 2),
(29, 'PARTY', 'Secretary General', 'Milo', '', 'Rolloque', 'Milo  Rolloque', '5', '2', 'BSCPE', '2020-03-14 18:54:27.962545', 2),
(30, 'PARTY', 'Vice President for Academic Affairs', 'Adriane', '', 'Sodela', 'Adriane  Sodela', '5', '5', 'BSCPE', '2020-03-14 18:54:27.962545', 2),
(31, 'PARTY', 'Vice President for Organization Relation', 'Jojo', '', 'Cansino', 'Jojo  Cansino', '5', '5', 'BSCPE', '2020-03-14 18:54:27.962545', 2),
(32, 'PARTY', 'Vice President for Research and Development', 'Muhi', '', 'Emmanuel', 'Muhi  Emmanuel', '5', '0', 'BSCPE', '2020-03-14 18:54:27.962545', 2),
(33, 'PARTY', 'Vice President for Student Affairs', 'Mingming', '', 'Nikki', 'Mingming  Nikki', '5', '1', 'BSCPE', '2020-03-14 18:54:27.962545', 2),
(34, 'LEADERS', 'Treasurer ', 'Camille', 'Z', 'Jimenez', 'Camille Z Jimenez', '5', '5', 'BSCPE', '2020-03-14 18:42:11.217015', 2);

-- --------------------------------------------------------

--
-- Table structure for table `create_election`
--

CREATE TABLE `create_election` (
  `create_id` int(11) NOT NULL,
  `organization_name` varchar(255) NOT NULL,
  `start_date` datetime(6) NOT NULL,
  `end_date` datetime(6) NOT NULL,
  `date_created` timestamp(6) NOT NULL DEFAULT current_timestamp(6) ON UPDATE current_timestamp(6)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `create_party`
--

CREATE TABLE `create_party` (
  `party_id` int(11) NOT NULL,
  `party_name` varchar(255) NOT NULL,
  `date_created` timestamp(6) NOT NULL DEFAULT current_timestamp(6) ON UPDATE current_timestamp(6),
  `candidate` varchar(11) DEFAULT NULL,
  `position` varchar(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `create_party`
--

INSERT INTO `create_party` (`party_id`, `party_name`, `date_created`, `candidate`, `position`) VALUES
(2, 'camille', '2020-02-19 17:58:54.870855', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `election`
--

CREATE TABLE `election` (
  `elec_key` int(11) NOT NULL,
  `create_electionFKkey` int(11) NOT NULL,
  `create_partyFKkey` int(11) NOT NULL,
  `date_created` timestamp(6) NOT NULL DEFAULT current_timestamp(6) ON UPDATE current_timestamp(6)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `login_logs`
--

CREATE TABLE `login_logs` (
  `id` int(11) NOT NULL,
  `voter_name` varchar(255) NOT NULL,
  `logged_in` varchar(255) NOT NULL,
  `logged_out` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `org`
--

CREATE TABLE `org` (
  `org_id` int(11) NOT NULL,
  `org_name` varchar(255) NOT NULL,
  `start_date` date NOT NULL,
  `end_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `org`
--

INSERT INTO `org` (`org_id`, `org_name`, `start_date`, `end_date`) VALUES
(1, 'Camille', '2020-02-28', '2020-03-14');

-- --------------------------------------------------------

--
-- Table structure for table `party_name`
--

CREATE TABLE `party_name` (
  `party_id` int(11) NOT NULL,
  `party_name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `party_name`
--

INSERT INTO `party_name` (`party_id`, `party_name`) VALUES
(1, 'LEADERS'),
(2, 'PARTY');

-- --------------------------------------------------------

--
-- Table structure for table `position`
--

CREATE TABLE `position` (
  `pos_id` int(11) NOT NULL,
  `position` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `position`
--

INSERT INTO `position` (`pos_id`, `position`) VALUES
(15, '2nd Year Governor'),
(14, '3rd Year Governor'),
(13, '4th Year Governor'),
(12, '5th Year Governor'),
(9, 'Auditor'),
(10, 'Business Manager'),
(16, 'Control Officer'),
(3, 'Executive Vice President'),
(11, 'Head Governor'),
(1, 'President'),
(7, 'Secretary General'),
(8, 'Treasurer '),
(4, 'Vice President for Academic Affairs'),
(6, 'Vice President for Organization Relation'),
(5, 'Vice President for Research and Development'),
(2, 'Vice President for Student Affairs');

-- --------------------------------------------------------

--
-- Table structure for table `voters`
--

CREATE TABLE `voters` (
  `voters_id` int(11) NOT NULL,
  `first_name` varchar(255) NOT NULL,
  `middle` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `course` varchar(255) NOT NULL,
  `year` varchar(255) NOT NULL,
  `section` varchar(255) NOT NULL,
  `student_number` varchar(255) NOT NULL,
  `active` int(11) NOT NULL DEFAULT 1,
  `role` varchar(255) NOT NULL DEFAULT 'USER',
  `date_created` timestamp(6) NOT NULL DEFAULT current_timestamp(6) ON UPDATE current_timestamp(6),
  `voter_status` varchar(255) NOT NULL DEFAULT 'NEW',
  `full_name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `voters`
--

INSERT INTO `voters` (`voters_id`, `first_name`, `middle`, `last_name`, `password`, `course`, `year`, `section`, `student_number`, `active`, `role`, `date_created`, `voter_status`, `full_name`) VALUES
(1, 'Camille Anne ', 'D.C', 'Pelayo', 'Pelayo', 'ITECH', 'ITECH', '5', '201503953MN0', 1, 'ADMIN', '2020-03-14 18:27:59.719698', 'NEW', 'Camille Anne B. Pelayo'),
(2, 'Patricia Diane', 'L', 'Infante', 'Infante', 'BSCPE', 'BSCPE', '5', '201503953MN1', 1, 'USER', '2020-03-14 18:53:44.523417', 'VOTED', 'Patricia L Infante'),
(3, 'Jonathan', 'E.', 'Jimenez', 'Jimenez', 'BSCPE', '5', '3', '201400637MN0', 1, 'USER', '2020-03-14 18:10:26.960693', 'NEW', 'Jonathan E. Jimenez'),
(6, 'Camille Anne', 'B', 'Pelayo', 'Pelayo', 'BSCPE', '5', '5', '201603953MN0', 1, 'USER', '2020-03-14 18:54:28.121257', 'VOTED', 'Camille Anne B. Pelayo');

-- --------------------------------------------------------

--
-- Table structure for table `vote_logs`
--

CREATE TABLE `vote_logs` (
  `vote_logs_id` int(255) NOT NULL,
  `party_name` varchar(255) NOT NULL,
  `president` varchar(255) NOT NULL,
  `vp_executive` varchar(255) NOT NULL,
  `vp_academic` varchar(255) NOT NULL,
  `vp_student` varchar(255) NOT NULL,
  `vp_relation` varchar(255) NOT NULL,
  `vp_organization` varchar(255) NOT NULL,
  `secretary` varchar(255) NOT NULL,
  `treasurer` varchar(255) NOT NULL,
  `auditor` varchar(255) NOT NULL,
  `business` varchar(255) NOT NULL,
  `control` varchar(255) NOT NULL,
  `head` varchar(255) NOT NULL,
  `second` varchar(255) NOT NULL,
  `third` varchar(255) NOT NULL,
  `fourth` varchar(255) NOT NULL,
  `fifth` varchar(255) NOT NULL,
  `voter_name` varchar(255) NOT NULL,
  `voter_student_num` varchar(255) NOT NULL,
  `date` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `vote_logs`
--

INSERT INTO `vote_logs` (`vote_logs_id`, `party_name`, `president`, `vp_executive`, `vp_academic`, `vp_student`, `vp_relation`, `vp_organization`, `secretary`, `treasurer`, `auditor`, `business`, `control`, `head`, `second`, `third`, `fourth`, `fifth`, `voter_name`, `voter_student_num`, `date`) VALUES
(21, '', 'dcfvbnmkg  ', 'fghjkl  ', 'poklpo  ', 'ygvbntg  ', 'vnbvnbvn  ', 'hvbnbnvbnv  ', 'cvbnluytfgjk  ', 'bvnmbm  ', 'hjh  iuyyutds', 'dsfhghjlk  ', 'rtyuio  ', 'cvbnvbnmvbn  ', 'nhjh  jhjh', 'jhjhj  jhjh', 'mother  fcker', 'camille  pelayo', 'Camille', '201503953MN0', '2020-03-14, 14:03:22'),
(22, '', 'dcfvbnmkg  ', 'fghjkl  ', 'poklpo  ', 'ygvbntg  ', 'vnbvnbvn  ', 'hvbnbnvbnv  ', 'cvbnluytfgjk  ', 'bvnmbm  ', 'hjh  iuyyutds', 'dsfhghjlk  ', 'rtyuio  ', 'cvbnvbnmvbn  ', 'nhjh  jhjh', 'jhjhj  jhjh', 'mother  fcker', 'camille  pelayo', 'Camille', '201503953MN1', '2020-03-14, 23:03:09'),
(23, '', 'dcfvbnmkg  ', 'fghjkl  ', 'poklpo  ', 'ygvbntg  ', 'vnbvnbvn  ', 'hvbnbnvbnv  ', 'cvbnluytfgjk  ', 'bvnmbm  ', 'hjh  iuyyutds', 'dsfhghjlk  ', 'rtyuio  ', 'cvbnvbnmvbn  ', 'nhjh  jhjh', 'jhjhj  jhjh', 'mother  fcker', 'camille  pelayo', '', '', '2020-03-15, 02:03:51'),
(24, 'LEADERS', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 'Jonathan', '201400637MN0', '2020-03-15, 02:03:47'),
(25, '', 'dcfvbnmkg  ', 'fghjkl  ', 'poklpo  ', 'ygvbntg  ', 'vnbvnbvn  ', 'hvbnbnvbnv  ', 'cvbnluytfgjk  ', 'bvnmbm  ', 'hjh  iuyyutds', 'dsfhghjlk  ', 'rtyuio  ', 'cvbnvbnmvbn  ', 'nhjh  jhjh', 'jhjhj  jhjh', 'mother  fcker', 'camille  pelayo', 'Patricia', '201503953MN1', '2020-03-15, 02:03:34'),
(26, '', 'Hazel  Maramot', 'Cameron  Diaz', 'Adriane  Sodela', 'Mingming  Nikki', 'Muhi  Emmanuel', 'Jojo  Cansino', 'Milo  Rolloque', 'bvnmbm  ', 'Mabon  Ocliaso', 'Corewin  Toral', 'Jorly 5 Pajabera', 'Ji Chang E Wook', 'Colyn  Atencio', 'User  Candidate', 'HighSchool  Musical', 'Project M File', 'Patricia', '201503953MN1', '2020-03-15, 02:03:59'),
(27, '', 'Jambo Z Hotdog', 'Justin M Maramot', 'Jaime E Jimenez', 'Hey S Sister', 'Bear N Brand', 'Teka  A Lang', 'Mama B Cat', 'Thank U Next', 'Mine M Mine', 'Jessica J Jessie', 'Mama E Moo', 'World P Hello', 'Hello J World', 'Diane E Indfante', 'Jonathan E Jimenez', 'Camille Anne B Pelayo', '', '', '2020-03-15, 02:03:40'),
(28, 'LEADERS', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '2020-03-15, 02:03:35'),
(29, 'LEADERS', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 'Patricia', '201503953MN1', '2020-03-15, 02:03:09'),
(30, '', 'Jambo Z Hotdog', 'Justin M Maramot', 'Jaime E Jimenez', 'Hey S Sister', 'Bear N Brand', 'Teka  A Lang', 'Mama B Cat', 'Thank U Next', 'Mine M Mine', 'Jessica J Jessie', 'Mama E Moo', 'World P Hello', 'Hello J World', 'Diane E Indfante', 'Jonathan E Jimenez', 'Camille Anne B Pelayo', 'Patricia Diane', '201503953MN1', '2020-03-15, 02:03:37'),
(31, 'PARTY', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 'Camille Anne', '201603953MN0', '2020-03-15, 02:03:22');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `added_voter_logs`
--
ALTER TABLE `added_voter_logs`
  ADD PRIMARY KEY (`voters_id`);

--
-- Indexes for table `candidate`
--
ALTER TABLE `candidate`
  ADD PRIMARY KEY (`candidate_id`);

--
-- Indexes for table `create_election`
--
ALTER TABLE `create_election`
  ADD PRIMARY KEY (`create_id`);

--
-- Indexes for table `create_party`
--
ALTER TABLE `create_party`
  ADD PRIMARY KEY (`party_id`),
  ADD KEY `candidate_FK` (`candidate`),
  ADD KEY `position_FK` (`position`);

--
-- Indexes for table `election`
--
ALTER TABLE `election`
  ADD PRIMARY KEY (`elec_key`),
  ADD KEY `create_electionFKkey` (`create_electionFKkey`),
  ADD KEY `create_partyFKkey` (`create_partyFKkey`);

--
-- Indexes for table `login_logs`
--
ALTER TABLE `login_logs`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `org`
--
ALTER TABLE `org`
  ADD PRIMARY KEY (`org_id`);

--
-- Indexes for table `party_name`
--
ALTER TABLE `party_name`
  ADD PRIMARY KEY (`party_id`);

--
-- Indexes for table `position`
--
ALTER TABLE `position`
  ADD PRIMARY KEY (`pos_id`),
  ADD UNIQUE KEY `position` (`position`);

--
-- Indexes for table `voters`
--
ALTER TABLE `voters`
  ADD PRIMARY KEY (`voters_id`);

--
-- Indexes for table `vote_logs`
--
ALTER TABLE `vote_logs`
  ADD PRIMARY KEY (`vote_logs_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `added_voter_logs`
--
ALTER TABLE `added_voter_logs`
  MODIFY `voters_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `candidate`
--
ALTER TABLE `candidate`
  MODIFY `candidate_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT for table `create_election`
--
ALTER TABLE `create_election`
  MODIFY `create_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `create_party`
--
ALTER TABLE `create_party`
  MODIFY `party_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `election`
--
ALTER TABLE `election`
  MODIFY `elec_key` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `login_logs`
--
ALTER TABLE `login_logs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `org`
--
ALTER TABLE `org`
  MODIFY `org_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `party_name`
--
ALTER TABLE `party_name`
  MODIFY `party_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `position`
--
ALTER TABLE `position`
  MODIFY `pos_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `voters`
--
ALTER TABLE `voters`
  MODIFY `voters_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `vote_logs`
--
ALTER TABLE `vote_logs`
  MODIFY `vote_logs_id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `election`
--
ALTER TABLE `election`
  ADD CONSTRAINT `create_electionFKkey` FOREIGN KEY (`create_electionFKkey`) REFERENCES `create_election` (`create_id`),
  ADD CONSTRAINT `create_partyFKkey` FOREIGN KEY (`create_partyFKkey`) REFERENCES `create_party` (`party_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
