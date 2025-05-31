-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: localhost    Database: arackiralamadb
-- ------------------------------------------------------
-- Server version	8.0.40

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `araclar`
--

DROP TABLE IF EXISTS `araclar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `araclar` (
  `aracID` int NOT NULL AUTO_INCREMENT,
  `marka` varchar(50) DEFAULT NULL,
  `model` varchar(50) DEFAULT NULL,
  `yil` int DEFAULT NULL,
  `sehir` varchar(50) DEFAULT NULL,
  `vites_tipi` varchar(20) DEFAULT NULL,
  `yakit_tipi` varchar(20) DEFAULT NULL,
  `gunluk_ucret` decimal(10,2) DEFAULT NULL,
  `kilometre` int DEFAULT NULL,
  `plaka` varchar(20) DEFAULT NULL,
  `resim_yolu` varchar(500) DEFAULT NULL,
  `bayi` varchar(100) DEFAULT NULL,
  `bayiID` int DEFAULT NULL,
  PRIMARY KEY (`aracID`),
  KEY `fk_bayiID` (`bayiID`),
  CONSTRAINT `fk_bayiID` FOREIGN KEY (`bayiID`) REFERENCES `bayiler` (`id`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `araclar`
--

LOCK TABLES `araclar` WRITE;
/*!40000 ALTER TABLE `araclar` DISABLE KEYS */;
INSERT INTO `araclar` VALUES (1,'Peugeot','208',2022,'İstanbul','Otomatik','Benzin',760.71,147378,'34 AB 001',NULL,'Hertz Araç Kiralama',1),(2,'Honda','Civic',2018,'Ankara','Manuel','Dizel',466.11,119125,'34 AC 002','\"C:UsersyavuzDesktoparabalarhondacivic.jpeg\"','Hertz Araç Kiralama',1),(3,'Renault','Clio',2020,'Ankara','Otomatik','Dizel',747.17,13700,'34 AD 003','\"C:UsersyavuzDesktoparabalar\renaultclio.jpeg\"','Hertz Araç Kiralama',1),(4,'Renault','Clio',2020,'İstanbul','Otomatik','Benzin',515.63,80286,'34 AE 004',NULL,'Hertz Araç Kiralama',1),(5,'Toyota','Corolla',2022,'İzmir','Otomatik','Benzin',675.25,68923,'34 AF 005','\"C:UsersyavuzDesktoparabalar	oyotacoralla.jpeg\"','Hertz Araç Kiralama',1),(6,'Volkswagen','Golf',2019,'Bursa','Manuel','Dizel',549.00,90234,'34 AG 006','\"C:UsersyavuzDesktoparabalarwolkswagengolf.jpeg\"','Hertz Araç Kiralama',1),(7,'Fiat','Egea',2021,'Antalya','Manuel','Benzin',435.50,77456,'34 AH 007','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Hertz Araç Kiralama',1),(8,'Ford','Focus',2020,'İstanbul','Otomatik','Dizel',622.80,112300,'34 AJ 008','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Hertz Araç Kiralama',1),(9,'Opel','Astra',2019,'Ankara','Otomatik','Benzin',598.75,54320,'34 AK 009','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Hertz Araç Kiralama',1),(10,'BMW','3 Serisi',2022,'İzmir','Otomatik','Benzin',1230.00,35211,'34 AL 010','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Hertz Araç Kiralama',1),(11,'Mercedes','A180',2021,'İstanbul','Otomatik','Dizel',1450.00,42750,'34 AM 011','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Avis Oto Kiralama',2),(12,'Audi','A3',2022,'İzmir','Otomatik','Benzin',1399.99,32500,'34 AN 012','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Avis Oto Kiralama',2),(13,'Hyundai','i20',2020,'Bursa','Manuel','Benzin',420.00,80300,'34 AP 013','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Avis Oto Kiralama',2),(14,'Kia','Rio',2021,'Antalya','Manuel','Benzin',410.00,60000,'34 AR 014','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Avis Oto Kiralama',2),(15,'Toyota','Yaris',2022,'İstanbul','Otomatik','Hibrit',720.00,22000,'34 AS 015','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Avis Oto Kiralama',2),(16,'Nissan','Qashqai',2019,'Ankara','Otomatik','Dizel',800.00,95000,'16 AB 016','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Avis Oto Kiralama',2),(17,'Dacia','Duster',2021,'Bursa','Manuel','Dizel',550.00,72000,'16 AC 017','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Avis Oto Kiralama',2),(18,'Peugeot','301',2020,'Antalya','Manuel','Benzin',465.00,69500,'16 AD 018','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Avis Oto Kiralama',2),(19,'Skoda','Octavia',2021,'İzmir','Otomatik','Benzin',780.00,41000,'16 AE 019','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Avis Oto Kiralama',2),(20,'Renault','Megane',2019,'İstanbul','Otomatik','Dizel',690.00,97000,'16 AF 020','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Avis Oto Kiralama',2),(21,'Citroen','C3',2022,'İstanbul','Manuel','Benzin',530.00,21500,'06 AB 021','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Enterprise Rent A Car',3),(22,'Ford','Fiesta',2020,'Ankara','Manuel','Benzin',460.00,61000,'06 AC 022','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Enterprise Rent A Car',3),(23,'Honda','Jazz',2021,'Bursa','Otomatik','Hibrit',675.00,33000,'06 AD 023','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Enterprise Rent A Car',3),(24,'Volkswagen','Passat',2019,'Antalya','Otomatik','Dizel',950.00,88500,'35 AB 024','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Enterprise Rent A Car',3),(25,'BMW','X1',2022,'İzmir','Otomatik','Benzin',1450.00,15000,'35 AC 025','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Enterprise Rent A Car',3),(26,'Mercedes','GLA',2022,'Ankara','Otomatik','Dizel',1550.00,24800,'07 AB 026','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Enterprise Rent A Car',3),(27,'Audi','Q2',2021,'İstanbul','Otomatik','Benzin',1380.00,31000,'07 AC 027','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Enterprise Rent A Car',3),(28,'Fiat','Panda',2020,'Antalya','Manuel','Benzin',410.00,54800,'01 AB 028','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Enterprise Rent A Car',3),(29,'Hyundai','Tucson',2021,'Bursa','Otomatik','Dizel',850.00,58000,'42 AB 029','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Enterprise Rent A Car',3),(30,'Nissan','Micra',2018,'İzmir','Manuel','Benzin',395.00,99000,'38 AB 030','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Enterprise Rent A Car',3),(31,'Opel','Corsa',2022,'Ankara','Otomatik','Benzin',600.00,21000,'27 AB 031','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Enterprise Rent A Car',3),(32,'Dacia','Sandero',2021,'İstanbul','Manuel','Dizel',480.00,68000,'55 AB 032','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Enterprise Rent A Car',3),(33,'Toyota','Auris',2020,'İzmir','Otomatik','Benzin',710.00,77000,'61 AB 033','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Enterprise Rent A Car',3),(34,'Kia','Ceed',2019,'Bursa','Manuel','Benzin',490.00,81200,'26 AB 034','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Enterprise Rent A Car',3),(35,'Citroen','C4',2022,'Ankara','Otomatik','Dizel',775.00,25800,'20 AB 035','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Enterprise Rent A Car',3),(36,'Volkswagen','T-Roc',2022,'Antalya','Otomatik','Benzin',1150.00,32000,'33 AB 036','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Enterprise Rent A Car',3),(37,'Renault','Talisman',2020,'İzmir','Otomatik','Dizel',880.00,56000,'41 AB 037','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Enterprise Rent A Car',3),(38,'Fiat','Linea',2018,'İstanbul','Manuel','Benzin',400.00,104000,'54 AB 038','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Garenta Şube',4),(39,'Ford','Kuga',2021,'Bursa','Otomatik','Dizel',890.00,30500,'09 AB 039','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Garenta Şube',4),(40,'Peugeot','2008',2020,'Ankara','Otomatik','Benzin',770.00,43500,'10 AB 040','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Garenta Şube',4),(41,'Hyundai','Elantra',2021,'Antalya','Otomatik','Benzin',720.00,36000,'31 AB 041','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Garenta Şube',4),(42,'Honda','CR-V',2022,'İzmir','Otomatik','Hibrit',1550.00,18000,'45 AB 042','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Garenta Şube',4),(43,'Audi','A4',2022,'İstanbul','Otomatik','Dizel',1480.00,21000,'67 AB 043','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Garenta Şube',4),(44,'Opel','Insignia',2020,'Bursa','Otomatik','Dizel',970.00,60000,'63 AB 044','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Garenta Şube',4),(45,'Skoda','Superb',2021,'Ankara','Otomatik','Benzin',1020.00,52000,'44 AB 045','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Garenta Şube',4),(46,'BMW','5 Serisi',2022,'İzmir','Otomatik','Benzin',1800.00,17000,'25 AB 046','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Budget Kiralama',5),(47,'Mercedes','C180',2021,'Antalya','Otomatik','Dizel',1600.00,19000,'65 AB 047','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Budget Kiralama',5),(48,'Toyota','Camry',2022,'İstanbul','Otomatik','Hibrit',1650.00,12000,'23 AB 048','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Budget Kiralama',5),(49,'Nissan','Juke',2021,'Ankara','Manuel','Benzin',625.00,47000,'52 AB 049','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Budget Kiralama',5),(50,'Kia','Sportage',2022,'Bursa','Otomatik','Dizel',1150.00,29000,'48 AB 050','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Budget Kiralama',5),(51,'Fiat','500',2021,'Antalya','Manuel','Benzin',490.00,33000,'08 AB 051','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Budget Kiralama',5),(52,'opel','corsa',2023,'bolu','Manuel','Benzin',1500.00,10000,'35NNN35','C:UsersyavuzDesktoparabalarhondacivic.jpeg','Budget Kiralama',5),(53,'bmw','530d',2024,'bursa','Otomatik','Dizel',3000.00,10000,'16BHD78',NULL,NULL,NULL),(54,'bmw','2 serisi',2025,'istanbul','Otomatik','Benzin',1500.00,1000,'34ABC34',NULL,NULL,NULL),(55,'reno','clio',2020,'bursa','Otomatik','Benzin',1000.00,50000,'16BHD788',NULL,NULL,NULL);
/*!40000 ALTER TABLE `araclar` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-31 11:51:46
