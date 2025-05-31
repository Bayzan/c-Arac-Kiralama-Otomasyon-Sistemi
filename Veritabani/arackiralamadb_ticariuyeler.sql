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
-- Table structure for table `ticariuyeler`
--

DROP TABLE IF EXISTS `ticariuyeler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ticariuyeler` (
  `id` int NOT NULL AUTO_INCREMENT,
  `isim` varchar(50) DEFAULT NULL,
  `soyisim` varchar(50) DEFAULT NULL,
  `tel_no` varchar(15) DEFAULT NULL,
  `tc_no` char(11) DEFAULT NULL,
  `e_posta` varchar(100) DEFAULT NULL,
  `ehliyet_sicil_no` varchar(20) DEFAULT NULL,
  `dogum_tarihi` date DEFAULT NULL,
  `sifre` varchar(50) DEFAULT NULL,
  `sirket_adi` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ticariuyeler`
--

LOCK TABLES `ticariuyeler` WRITE;
/*!40000 ALTER TABLE `ticariuyeler` DISABLE KEYS */;
INSERT INTO `ticariuyeler` VALUES (1,'Mehmet','Kara','05001112233','11122334455','mehmet.kara@ornek.com','EHLYT999888','1985-03-10','meh123','Kara Lojistik'),(2,'Ayşe','Çetin','05556667788','55667788990','ayse.cetin@ornek.com','EHLYT112233','1992-07-25','ayse456','Çetin Nakliyat'),(3,'yavuzhan','bayzan','05530231475','45454545454','yavuz@hotmail.com','123456','1990-05-12','12345','JantTrack'),(4,'micheal','jordan','05698741264','52045369854','micheal@gmail.com','6546135','1970-05-05','micheal123','ıron'),(5,'yavuz','bayzan','05320442154','165468466','asd@gmail.com','6546465465','1990-10-10','hello','Jant'),(6,'asd','asdas','05365577421','10024556','sad@','654654','1990-10-10','12345','fabrika'),(7,'burak','zumbul','5555555555','00000000000','burak@example.com','ehl5698','2002-05-23','12345','zumbul aş');
/*!40000 ALTER TABLE `ticariuyeler` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-31 11:51:45
