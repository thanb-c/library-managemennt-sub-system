-- phpMyAdmin SQL Dump
-- version 2.10.3
-- http://www.phpmyadmin.net
-- 
-- Host: localhost
-- Generation Time: Mar 17, 2022 at 04:12 PM
-- Server version: 5.0.51
-- PHP Version: 5.2.6

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

-- 
-- Database: `final`
-- 
CREATE DATABASE `final` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `final`;

-- --------------------------------------------------------

-- 
-- Table structure for table `book`
-- 

CREATE TABLE `book` (
  `ISBN` varchar(255) NOT NULL,
  `type` varchar(255) NOT NULL,
  `title` varchar(255) NOT NULL,
  `author` varchar(255) NOT NULL,
  `genres` varchar(255) NOT NULL,
  `ShelfNo` int(11) NOT NULL,
  PRIMARY KEY  (`ISBN`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table `book`
-- 

INSERT INTO `book` VALUES ('110-9985-09', 'Fiction', 'The Odyssey', 'Homer', 'Action/Adventure', 4);
INSERT INTO `book` VALUES ('111-2349-32', 'Fiction', 'Treasure Island', 'Robert Louis Stevenson', 'Action/Adventure', 3);
INSERT INTO `book` VALUES ('113-2937-44', 'Fiction', 'The Adventures of Huckleberry Finn', 'Mark Twain', 'Action/Adventure', 3);
INSERT INTO `book` VALUES ('119-3456-33', 'Nonfiction', 'How to Win Friends & Influence People', 'Dale Carnegie', 'Business/economics', 5);
INSERT INTO `book` VALUES ('110-3845-68', 'Nonfiction', ' The Hard Thing About Hard Things: Building a Business When There Are No Easy Answers', 'Ben Horowitz', 'Business/economics', 6);
INSERT INTO `book` VALUES ('120-4356-45', 'Fiction', 'Pride and Prejudice', 'Jane Austen', 'Classic', 4);
INSERT INTO `book` VALUES ('114-0596-84', 'Fiction', 'Wide Sargasso Sea', 'Jean Rhys', 'Classic', 4);
INSERT INTO `book` VALUES ('121-4634-23', 'Fiction', 'V for Vendetta', 'Alan Moore', 'Comic Book', 8);
INSERT INTO `book` VALUES ('124-4532-45', 'Nonfiction', 'Webster''s New Explorer Large Print Dictionary', 'Merriam-Webster', 'Dictionary', 2);
INSERT INTO `book` VALUES ('124-3465-67', 'Nonfiction', ' Oxford English Dictionary', '-', 'Dictionary', 2);
INSERT INTO `book` VALUES ('2134-4361-35133', 'Nonfiction', 'An Area of Darkness', 'V. S. Naipaul', 'Travel', 15);
INSERT INTO `book` VALUES ('103-6454-76', 'Fiction', 'The Woman''s Hour: The Great Fight to Win the Vote', 'Elaine Weiss', 'History', 7);
INSERT INTO `book` VALUES ('1345-3635-36336', 'Fiction', 'Along the Ganges', 'Ilija Trojanow', 'Travel', 15);
INSERT INTO `book` VALUES ('134-6432-57', 'Nonfiction', '1776', 'David McCullough', 'History', 7);
INSERT INTO `book` VALUES ('154-6435-05', 'Nonfiction', 'The Crusades', 'Thomas Asbridge', 'History', 6);
INSERT INTO `book` VALUES ('149-4574-25', 'Nonfiction', 'On the Origins of Species', 'Charles Darwin', 'History', 8);
INSERT INTO `book` VALUES ('160-3465-76', 'Nonfiction', ' The Republic', 'Plato', 'History', 7);
INSERT INTO `book` VALUES ('23-46733-2343', 'Fiction', ' Beezus and Ramona ', ' BEVERLY CLEARY', 'Picture book', 12);
INSERT INTO `book` VALUES ('33-45632-6432', 'Fiction', ' James and the Giant Peach', 'ROALD DAHL', 'Picture book', 11);
INSERT INTO `book` VALUES ('23-47333-5366', 'Fiction', 'The Frog and Toad Collection', 'ARNOLD LOBEL', 'Picture book', 11);
INSERT INTO `book` VALUES ('323-45236-1431', 'Nonfiction', 'Beyond Good And Evil', 'Nietzsche', 'Philosophy', 10);
INSERT INTO `book` VALUES ('4154-54722-43', 'Fiction', 'A Walk to Remember', 'Nicholas Sparks ', 'Romance', 14);
INSERT INTO `book` VALUES ('3453-475621-53', 'Fiction', 'Virgin River', 'Robyn Carr', 'Romance', 14);
INSERT INTO `book` VALUES ('2354-56313-453', 'Fiction', ' It Had to Be You ', 'Susan Elizabeth Phillips ', 'Romance', 14);
INSERT INTO `book` VALUES ('435-5772-74672-2', 'Nonfiction', 'The Art of Travel', 'Alain de Botton', 'Travel', 15);
INSERT INTO `book` VALUES ('253-63255-5753', 'Nonfiction', 'Pocket Atlas of Remote Islands: Fifty Islands I Have Not Visited and Never Will', 'Judith Schalansky', 'Travel', 15);

-- --------------------------------------------------------

-- 
-- Table structure for table `booktype`
-- 

CREATE TABLE `booktype` (
  `typename` varchar(255) NOT NULL,
  `loanable` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table `booktype`
-- 

INSERT INTO `booktype` VALUES ('Fiction', 'Yes');
INSERT INTO `booktype` VALUES ('Nonfiction', 'No');

-- --------------------------------------------------------

-- 
-- Table structure for table `borrowed`
-- 

CREATE TABLE `borrowed` (
  `no` int(11) NOT NULL auto_increment,
  `memberId` int(11) NOT NULL,
  `ISBN` varchar(255) NOT NULL,
  `title` varchar(255) NOT NULL,
  `borrowDate` datetime NOT NULL,
  `returnDate` datetime default NULL,
  PRIMARY KEY  (`no`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=22 ;

-- 
-- Dumping data for table `borrowed`
-- 

INSERT INTO `borrowed` VALUES (4, 3, '134-6432-57', '1776', '2022-03-01 08:38:11', '2022-03-08 16:09:33');
INSERT INTO `borrowed` VALUES (3, 2, '4154-54722-43', 'A Walk to Remember', '2022-03-01 08:38:07', '2022-03-03 10:39:46');
INSERT INTO `borrowed` VALUES (5, 6, '2354-56313-453', 'It Had to Be You', '2022-03-02 08:38:58', '2022-03-09 15:48:11');
INSERT INTO `borrowed` VALUES (6, 4, '2354-56313-453', 'It Had to Be You', '2022-03-03 08:38:55', '2022-03-07 21:52:28');
INSERT INTO `borrowed` VALUES (7, 4, '113-2937-44', 'The Adventures of Huckleberry Finn', '2022-03-05 08:39:55', '2022-03-10 15:44:24');
INSERT INTO `borrowed` VALUES (8, 5, '111-2349-32', 'Treasure Island', '2022-03-08 22:09:46', '2022-03-17 13:33:03');
INSERT INTO `borrowed` VALUES (9, 5, '120-4356-45', 'Pride and Prejudice', '2022-03-10 22:09:53', '2022-03-17 15:26:26');
INSERT INTO `borrowed` VALUES (12, 3, '23-47333-5366', 'The Frog and Toad Collection', '2022-03-10 13:44:28', '2022-03-17 12:37:24');
INSERT INTO `borrowed` VALUES (14, 3, '4154-54722-43', 'A Walk to Remember', '2022-03-12 12:14:59', '2022-03-17 13:15:19');
INSERT INTO `borrowed` VALUES (21, 3, '23-46733-2343', ' Beezus and Ramona ', '2022-03-18 15:28:12', '2022-03-17 15:28:20');
INSERT INTO `borrowed` VALUES (20, 3, '3453-475621-53', 'Virgin River', '2022-03-16 12:21:47', '2022-03-16 16:09:33');

-- --------------------------------------------------------

-- 
-- Table structure for table `member`
-- 

CREATE TABLE `member` (
  `no` int(11) NOT NULL auto_increment,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `firstname` varchar(255) NOT NULL,
  `lastname` varchar(255) NOT NULL,
  `type` varchar(255) NOT NULL,
  PRIMARY KEY  (`no`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

-- 
-- Dumping data for table `member`
-- 

INSERT INTO `member` VALUES (1, 'somsri', 'eiei', 'somsri', 'jaidee', 'student');
INSERT INTO `member` VALUES (2, 'somsuay', '1234', 'somsuay', 'ngodngam', 'student');
INSERT INTO `member` VALUES (3, 'smorn', 'smorn', 'smorn', 'sorndee', 'student');
INSERT INTO `member` VALUES (4, 'songsak', '1111', 'songsak', 'ardharn', 'student');
INSERT INTO `member` VALUES (5, 'somboon', '1212121', 'somboon', 'jaicheun', 'student');
INSERT INTO `member` VALUES (6, 'somrak', '1112', 'somrak', 'kamsingha', 'student');
