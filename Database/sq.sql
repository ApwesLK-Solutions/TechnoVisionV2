CREATE TABLE `branch` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `BranchName` varchar(20) NOT NULL,
  `MasterPassword` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  UNIQUE KEY `BranchName_UNIQUE` (`BranchName`),
  UNIQUE KEY `MasterPassword_UNIQUE` (`MasterPassword`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;


CREATE TABLE `contactlense` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `OrderNumber` varchar(8) NOT NULL,
  `JobType` varchar(45) NOT NULL,
  `TestedBy` varchar(45) NOT NULL,
  `OldRightSph` varchar(10) NOT NULL,
  `OldRightCyl` varchar(10) NOT NULL,
  `OldRightAxis` varchar(10) NOT NULL,
  `OldRightAdd` varchar(10) NOT NULL,
  `OldLeftSph` varchar(10) NOT NULL,
  `OldLeftCyl` varchar(10) NOT NULL,
  `OldLeftAxis` varchar(10) NOT NULL,
  `OldLeftAdd` varchar(10) NOT NULL,
  `PresentRightSph` varchar(10) NOT NULL,
  `PresentRightCyl` varchar(10) NOT NULL,
  `PresentRightAxis` varchar(10) NOT NULL,
  `PresentRightAdd` varchar(10) NOT NULL,
  `PresentLeftSph` varchar(10) NOT NULL,
  `PresentLeftCyl` varchar(10) NOT NULL,
  `PresentLeftAxis` varchar(10) NOT NULL,
  `PresentLeftAdd` varchar(10) NOT NULL,
  `RightBc` varchar(10) NOT NULL,
  `RightPow` varchar(10) NOT NULL,
  `RightDia` varchar(10) NOT NULL,
  `RightDesz` varchar(10) NOT NULL,
  `LeftBc` varchar(10) NOT NULL,
  `LeftPow` varchar(10) NOT NULL,
  `LeftDia` varchar(10) NOT NULL,
  `LeftDesz` varchar(10) NOT NULL,
  `TrailLense` varchar(150) NOT NULL,
  `OverRefract` varchar(45) NOT NULL,
  `KReading` varchar(45) NOT NULL,
  `BlinkTest` varchar(45) NOT NULL,
  `SpecialInstractions` varchar(225) NOT NULL,
  `Remarks` varchar(150) NOT NULL,
  `ReminderDays` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `logs` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `User` varchar(45) NOT NULL,
  `BranchId` int(11) NOT NULL,
  `RecordDate` date NOT NULL,
  `RecordTime` datetime NOT NULL,
  `RecordContent` varchar(255) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `id_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

CREATE TABLE `users` (
  `Username` varchar(20) NOT NULL,
  `Password` varchar(20) NOT NULL,
  `FullName` varchar(200) NOT NULL,
  `Nic` varchar(12) NOT NULL,
  `ContactNumber` varchar(10) NOT NULL,
  `BranchId` int(11) NOT NULL,
  `IsActive` tinyint(4) NOT NULL,
  PRIMARY KEY (`Username`),
  UNIQUE KEY `Username_UNIQUE` (`Username`),
  UNIQUE KEY `Nic_UNIQUE` (`Nic`),
  UNIQUE KEY `ContactNumber_UNIQUE` (`ContactNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
