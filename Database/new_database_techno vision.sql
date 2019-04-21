-- MySQL Script generated by MySQL Workbench
-- Sun Apr 21 09:07:46 2019
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema technovision
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema technovision
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `technovision` DEFAULT CHARACTER SET latin1 ;
USE `technovision` ;

-- -----------------------------------------------------
-- Table `technovision`.`branch`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `technovision`.`branch` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT,
  `BranchName` VARCHAR(20) NOT NULL,
  `MasterPassword` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  UNIQUE INDEX `BranchName_UNIQUE` (`BranchName` ASC) VISIBLE,
  UNIQUE INDEX `MasterPassword_UNIQUE` (`MasterPassword` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 11
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `technovision`.`contactlense`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `technovision`.`contactlense` (
  `Id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `OrderNumber` VARCHAR(8) NOT NULL,
  `OrderDate` DATE NOT NULL,
  `DueDate` DATE NOT NULL,
  `JobType` VARCHAR(45) NOT NULL,
  `TestedBy` VARCHAR(45) NOT NULL,
  `Total` DOUBLE NOT NULL,
  `Discount` DOUBLE NOT NULL,
  `Advance` DOUBLE NOT NULL,
  `Balance` DOUBLE NOT NULL,
  `PaymentMethod` VARCHAR(45) NOT NULL,
  `PaymentPlan` VARCHAR(45) NOT NULL,
  `OrderStatus` VARCHAR(15) NULL DEFAULT NULL,
  `OldRightSph` VARCHAR(10) NOT NULL,
  `OldRightCyl` VARCHAR(10) NOT NULL,
  `OldRightAxis` VARCHAR(10) NOT NULL,
  `OldRightAdd` VARCHAR(10) NOT NULL,
  `OldLeftSph` VARCHAR(10) NOT NULL,
  `OldLeftCyl` VARCHAR(10) NOT NULL,
  `OldLeftAxis` VARCHAR(10) NOT NULL,
  `OldLeftAdd` VARCHAR(10) NOT NULL,
  `PresentRightSph` VARCHAR(10) NOT NULL,
  `PresentRightCyl` VARCHAR(10) NOT NULL,
  `PresentRightAxis` VARCHAR(10) NOT NULL,
  `PresentRightAdd` VARCHAR(10) NOT NULL,
  `PresentLeftSph` VARCHAR(10) NOT NULL,
  `PresentLeftCyl` VARCHAR(10) NOT NULL,
  `PresentLeftAxis` VARCHAR(10) NOT NULL,
  `PresentLeftAdd` VARCHAR(10) NOT NULL,
  `RightBc` VARCHAR(10) NOT NULL,
  `RightPow` VARCHAR(10) NOT NULL,
  `RightDia` VARCHAR(10) NOT NULL,
  `RightDesz` VARCHAR(10) NOT NULL,
  `LeftBc` VARCHAR(10) NOT NULL,
  `LeftPow` VARCHAR(10) NOT NULL,
  `LeftDia` VARCHAR(10) NOT NULL,
  `LeftDesz` VARCHAR(10) NOT NULL,
  `TrailLense` VARCHAR(150) NOT NULL,
  `OverRefract` VARCHAR(45) NOT NULL,
  `KReading` VARCHAR(45) NOT NULL,
  `BlinkTest` VARCHAR(45) NOT NULL,
  `SpecialInstractions` VARCHAR(225) NOT NULL,
  `Remarks` VARCHAR(150) NOT NULL,
  `ReminderDays` INT(11) NOT NULL,
  `Branch` INT(11) NOT NULL,
  `Year` VARCHAR(45) NOT NULL,
  `CustomerId` INT(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `technovision`.`customer`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `technovision`.`customer` (
  `Id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(225) NOT NULL,
  `Address` VARCHAR(225) NOT NULL,
  `Profession` VARCHAR(225) NOT NULL,
  `Age` VARCHAR(225) NOT NULL,
  `Phone` VARCHAR(10) NOT NULL,
  `Email` VARCHAR(50) NOT NULL,
  `Branch` INT(11) NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
AUTO_INCREMENT = 17
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `technovision`.`frames`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `technovision`.`frames` (
  `Id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `FrameName` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
AUTO_INCREMENT = 13
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `technovision`.`logs`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `technovision`.`logs` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT,
  `User` VARCHAR(45) NOT NULL,
  `BranchId` INT(11) NOT NULL,
  `RecordDate` DATE NOT NULL,
  `RecordTime` DATETIME NOT NULL,
  `RecordContent` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `id_UNIQUE` (`Id` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 449
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `technovision`.`receipt`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `technovision`.`receipt` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT,
  `ReceiptNumber` VARCHAR(45) NOT NULL,
  `ReceiptDate` DATE NOT NULL,
  `OrderNumber` VARCHAR(10) NOT NULL,
  `PaymentAmount` DOUBLE NOT NULL,
  `Branch` INT(11) NOT NULL,
  `OrderType` VARCHAR(45) NOT NULL,
  `Year` VARCHAR(45) NOT NULL,
  `CustId` INT(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 27
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `technovision`.`spectacles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `technovision`.`spectacles` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT,
  `OrderNumber` VARCHAR(8) NOT NULL,
  `OrderDate` DATE NOT NULL,
  `DueDate` DATE NOT NULL,
  `OrderStatus` VARCHAR(45) NOT NULL,
  `Total` DOUBLE NOT NULL,
  `Advance` DOUBLE NOT NULL,
  `Discount` DOUBLE NOT NULL,
  `Balance` DOUBLE NOT NULL,
  `TestBy` VARCHAR(45) NOT NULL,
  `EyeWear` DOUBLE NOT NULL,
  `Lense` DOUBLE NOT NULL,
  `PaymentPlan` VARCHAR(45) NOT NULL,
  `PaymentMethod` VARCHAR(45) NOT NULL,
  `DistRightSph` VARCHAR(10) NOT NULL,
  `DistRightCyl` VARCHAR(10) NOT NULL,
  `DistRightAxis` VARCHAR(10) NOT NULL,
  `DistLeftSph` VARCHAR(10) NOT NULL,
  `DistLeftCyl` VARCHAR(10) NOT NULL,
  `DistLeftAxis` VARCHAR(10) NOT NULL,
  `AddRight` VARCHAR(10) NOT NULL,
  `AddLeft` VARCHAR(10) NOT NULL,
  `LenseType` VARCHAR(45) NOT NULL,
  `Frame` VARCHAR(45) NOT NULL,
  `PD` VARCHAR(45) NOT NULL,
  `SegmentHight` VARCHAR(10) NOT NULL,
  `SpecialInstractions` VARCHAR(225) NOT NULL,
  `Remarks` VARCHAR(45) NOT NULL,
  `ReminderDate` INT(11) NOT NULL,
  `Branch` INT(11) NOT NULL,
  `Year` VARCHAR(45) NOT NULL,
  `CustomerId` INT(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 11
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `technovision`.`testers`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `technovision`.`testers` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `technovision`.`users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `technovision`.`users` (
  `Username` VARCHAR(20) NOT NULL,
  `Password` VARCHAR(20) NOT NULL,
  `FullName` VARCHAR(200) NOT NULL,
  `Nic` VARCHAR(12) NOT NULL,
  `ContactNumber` VARCHAR(10) NOT NULL,
  `BranchId` INT(11) NOT NULL,
  `IsActive` TINYINT(4) NOT NULL,
  PRIMARY KEY (`Username`),
  UNIQUE INDEX `Username_UNIQUE` (`Username` ASC) VISIBLE,
  UNIQUE INDEX `Nic_UNIQUE` (`Nic` ASC) VISIBLE,
  UNIQUE INDEX `ContactNumber_UNIQUE` (`ContactNumber` ASC) VISIBLE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

USE `technovision` ;

-- -----------------------------------------------------
-- procedure Backup
-- -----------------------------------------------------

DELIMITER $$
USE `technovision`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Backup`()
BEGIN

SELECT * FROM branch 
INTO OUTFILE 'D:/Backups/branch.csv'
FIELDS TERMINATED BY ','  
LINES TERMINATED BY '\n';

SELECT * FROM contactlense 
INTO OUTFILE 'D:/Backups/contactlense.csv'
FIELDS TERMINATED BY ','  
LINES TERMINATED BY '\n';

SELECT * FROM customer 
INTO OUTFILE 'D:/Backups/customer.csv'
FIELDS TERMINATED BY ','  
LINES TERMINATED BY '\n';

SELECT * FROM frames 
INTO OUTFILE 'D:/Backups/frames.csv'
FIELDS TERMINATED BY ','  
LINES TERMINATED BY '\n';

SELECT * FROM `logs` 
INTO OUTFILE 'D:/Backups/logs.csv'
FIELDS TERMINATED BY ','  
LINES TERMINATED BY '\n';

SELECT * FROM receipt 
INTO OUTFILE 'D:/Backups/receipt.csv'
FIELDS TERMINATED BY ','  
LINES TERMINATED BY '\n';

SELECT * FROM spectacles 
INTO OUTFILE 'D:/Backups/spectacles.csv'
FIELDS TERMINATED BY ','  
LINES TERMINATED BY '\n';

SELECT * FROM testers 
INTO OUTFILE 'D:/Backups/testers.csv'
FIELDS TERMINATED BY ','  
LINES TERMINATED BY '\n';

SELECT * FROM users 
INTO OUTFILE 'D:/Backups/users.csv'
FIELDS TERMINATED BY ','  
LINES TERMINATED BY '\n';


END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure GetMaxReceipt
-- -----------------------------------------------------

DELIMITER $$
USE `technovision`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetMaxReceipt`(
 IN xBranch int,
 IN xYear varchar(15), 
 OUT xReceiptNumber varchar(50))
BEGIN
 SELECT ReceiptNumber INTO xReceiptNumber  FROM receipt WHERE Branch =  xBranch AND Year = xYear AND substring(ReceiptNumber,2)=(SELECT MAX(CAST(SUBSTRING(ReceiptNumber,2) AS SIGNED)) FROM receipt);
END$$

DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
