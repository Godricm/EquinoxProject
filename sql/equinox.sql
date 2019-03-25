/*
Navicat MySQL Data Transfer

Source Server         : 127.0.0.1
Source Server Version : 50719
Source Host           : 127.0.0.1:3306
Source Database       : equinox

Target Server Type    : MYSQL
Target Server Version : 50719
File Encoding         : 65001

Date: 2019-03-25 22:10:49
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for aspnetroleclaims
-- ----------------------------
DROP TABLE IF EXISTS `aspnetroleclaims`;
CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ClaimType` longtext COLLATE utf8_unicode_ci,
  `ClaimValue` longtext COLLATE utf8_unicode_ci,
  `RoleId` varchar(450) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of aspnetroleclaims
-- ----------------------------

-- ----------------------------
-- Table structure for aspnetroles
-- ----------------------------
DROP TABLE IF EXISTS `aspnetroles`;
CREATE TABLE `aspnetroles` (
  `Id` varchar(450) COLLATE utf8_unicode_ci NOT NULL,
  `ConcurrencyStamp` longtext COLLATE utf8_unicode_ci,
  `Name` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NormalizedName` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of aspnetroles
-- ----------------------------

-- ----------------------------
-- Table structure for aspnetuserclaims
-- ----------------------------
DROP TABLE IF EXISTS `aspnetuserclaims`;
CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ClaimType` longtext COLLATE utf8_unicode_ci,
  `ClaimValue` longtext COLLATE utf8_unicode_ci,
  `UserId` varchar(450) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of aspnetuserclaims
-- ----------------------------

-- ----------------------------
-- Table structure for aspnetuserlogins
-- ----------------------------
DROP TABLE IF EXISTS `aspnetuserlogins`;
CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(450) COLLATE utf8_unicode_ci NOT NULL,
  `ProviderKey` varchar(450) COLLATE utf8_unicode_ci NOT NULL,
  `ProviderDisplayName` longtext COLLATE utf8_unicode_ci,
  `UserId` varchar(450) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of aspnetuserlogins
-- ----------------------------

-- ----------------------------
-- Table structure for aspnetuserroles
-- ----------------------------
DROP TABLE IF EXISTS `aspnetuserroles`;
CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(450) COLLATE utf8_unicode_ci NOT NULL,
  `RoleId` varchar(450) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of aspnetuserroles
-- ----------------------------

-- ----------------------------
-- Table structure for aspnetusers
-- ----------------------------
DROP TABLE IF EXISTS `aspnetusers`;
CREATE TABLE `aspnetusers` (
  `Id` varchar(450) COLLATE utf8_unicode_ci NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `ConcurrencyStamp` longtext COLLATE utf8_unicode_ci,
  `Email` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `EmailConfirmed` bit(1) NOT NULL,
  `LockoutEnabled` bit(1) NOT NULL,
  `LockoutEnd` datetime DEFAULT NULL,
  `NormalizedEmail` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NormalizedUserName` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `PasswordHash` longtext COLLATE utf8_unicode_ci,
  `PhoneNumber` longtext COLLATE utf8_unicode_ci,
  `PhoneNumberConfirmed` bit(1) NOT NULL,
  `SecurityStamp` longtext COLLATE utf8_unicode_ci,
  `TwoFactorEnabled` bit(1) NOT NULL,
  `UserName` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of aspnetusers
-- ----------------------------

-- ----------------------------
-- Table structure for customers
-- ----------------------------
DROP TABLE IF EXISTS `customers`;
CREATE TABLE `customers` (
  `Id` char(36) COLLATE utf8_unicode_ci NOT NULL,
  `BirthDate` datetime NOT NULL,
  `Email` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `Name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of customers
-- ----------------------------

-- ----------------------------
-- Table structure for storedevent
-- ----------------------------
DROP TABLE IF EXISTS `storedevent`;
CREATE TABLE `storedevent` (
  `Id` char(36) COLLATE utf8_unicode_ci NOT NULL,
  `AggregateId` char(36) COLLATE utf8_unicode_ci NOT NULL,
  `Data` longtext COLLATE utf8_unicode_ci,
  `Action` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CreationDate` datetime NOT NULL,
  `User` longtext COLLATE utf8_unicode_ci,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of storedevent
-- ----------------------------

-- ----------------------------
-- Table structure for __efmigrationshistory
-- ----------------------------
DROP TABLE IF EXISTS `__efmigrationshistory`;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) COLLATE utf8_unicode_ci NOT NULL,
  `ProductVersion` varchar(32) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of __efmigrationshistory
-- ----------------------------
