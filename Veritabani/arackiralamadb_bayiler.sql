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
-- Table structure for table `bayiler`
--

DROP TABLE IF EXISTS `bayiler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bayiler` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `website` varchar(100) DEFAULT NULL,
  `lat` decimal(9,6) DEFAULT NULL,
  `lon` decimal(9,6) DEFAULT NULL,
  `resim_yolu` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bayiler`
--

LOCK TABLES `bayiler` WRITE;
/*!40000 ALTER TABLE `bayiler` DISABLE KEYS */;
INSERT INTO `bayiler` VALUES (1,'Hertz Araç Kiralama','0535 173 4667','Ataevler Mah. 123. Sk. No:5, Bursa','https://HertzArac.com',40.236200,28.874300,'C:\\Users\\yavuz\\Desktop\\arabalar\\bayi.jpg'),(2,'Avis Oto Kiralama','0532 111 2233','Nilüfer Mah. 45. Sk. No:12, Bursa','https://avis.com.tr',40.208400,28.951700,'C:\\Users\\yavuz\\Desktop\\arabalar\\bayi.jpg'),(3,'Enterprise Rent A Car','0533 987 6543','Osmangazi Mah. 9. Sk. No:3, Bursa','https://enterprise.com.tr',40.195500,29.060000,'C:\\Users\\yavuz\\Desktop\\arabalar\\bayi.jpg'),(4,'Garenta Şube','0544 456 7890','Yıldırım Mah. 78. Sk. No:7, Bursa','https://garenta.com.tr',40.210000,29.010000,'C:\\Users\\yavuz\\Desktop\\arabalar\\bayi.jpg'),(5,'Budget Kiralama','0555 123 7890','Görükle Mah. 12. Sk. No:8, Bursa','https://budget.com.tr',40.245000,28.880000,'C:\\Users\\yavuz\\Desktop\\arabalar\\bayi.jpg');
/*!40000 ALTER TABLE `bayiler` ENABLE KEYS */;
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
