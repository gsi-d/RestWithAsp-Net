CREATE TABLE IF NOT EXISTS `Book` (
  `Id` bigint(20) NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `Description` varchar(1000) NOT NULL,
  `Author` varchar(100) NOT NULL,
  `Price` double NOT NULL,
  PRIMARY KEY (`Id`)
  )