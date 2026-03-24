-- MySQL dump 10.13  Distrib 8.0.45, for Linux (aarch64)
--
-- Host: 192.168.64.1    Database: escolar
-- ------------------------------------------------------
-- Server version	8.0.45

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Alumnos`
--

DROP TABLE IF EXISTS `Alumnos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Alumnos` (
  `idAlumno` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) DEFAULT NULL,
  `SegundoNombre` varchar(100) DEFAULT NULL,
  `ApellidoPat` varchar(100) DEFAULT NULL,
  `ApellidoMat` varchar(100) DEFAULT NULL,
  `NumeroControl` varchar(100) DEFAULT NULL,
  `Semestre` varchar(100) DEFAULT NULL,
  `Carrera` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idAlumno`)
) ENGINE=InnoDB AUTO_INCREMENT=24130935 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Alumnos`
--

LOCK TABLES `Alumnos` WRITE;
/*!40000 ALTER TABLE `Alumnos` DISABLE KEYS */;
INSERT INTO `Alumnos` VALUES (24130905,'José','Luis','Sánchez','Castro','24010005','7','Mecatrónica'),(24130906,'Sofía','Fernanda','Ramírez','Torres','24010006','4','Sistemas'),(24130907,'Diego','Alberto','Flores','Morales','24010007','6','Industrial'),(24130908,'Elena','Beatriz','Vázquez','Ortiz','24010008','8','Civil'),(24130909,'Ricardo','Jose','Jiménez','Silva','24010009','1','Arquitectura'),(24130910,'Lucía','Fernanda','Moreno','Méndez','24010010','3','Mecatrónica'),(24130911,'Gabriel','Antonio','Rojas','Guzmán','24010011','5','Sistemas'),(24130912,'Valeria','Nubia','Núñez','Pardo','24010012','2','Industrial'),(24130913,'Manuel','Eduardo','Lara','Solís','24010013','7','Civil'),(24130914,'Carmen','Alicia','Ortega','Luna','24010014','4','Arquitectura'),(24130915,'Roberto','Javier','Herrera','Ríos','24010015','6','Mecatrónica'),(24130916,'Juan','Carlos','Pérez','García','24010001','1','Sistemas'),(24130917,'María','Elena','Rodríguez','López','24010002','3','Industrial'),(24130918,'Luis','Fernando','Gómez','Hernández','24010003','5','Civil'),(24130919,'Ana','Paula','Martínez','Ruiz','24010004','2','Arquitectura'),(24130920,'José','Luis','Sánchez','Castro','24010005','7','Mecatrónica'),(24130921,'Sofía','Fernanda','Ramírez','Torres','24010006','4','Sistemas'),(24130922,'Diego','Alberto','Flores','Morales','24010007','6','Industrial'),(24130923,'Elena','Beatriz','Vázquez','Ortiz','24010008','8','Civil'),(24130924,'Ricardo','Jose','Jiménez','Silva','24010009','1','Arquitectura'),(24130925,'Lucía','Fernanda','Moreno','Méndez','24010010','3','Mecatrónica'),(24130926,'Gabriel','Antonio','Rojas','Guzmán','24010011','5','Sistemas'),(24130927,'Valeria','Nubia','Núñez','Pardo','24010012','2','Industrial'),(24130928,'Manuel','Eduardo','Lara','Solís','24010013','7','Civil'),(24130929,'Carmen','Alicia','Ortega','Luna','24010014','4','Arquitectura'),(24130930,'Roberto','Javier','Herrera','Ríos','24010015','6','Mecatrónica'),(24130931,'dand','fasf','fafs','efaef','12','4','sdsd'),(24130932,'Da','nsd','nds','ndfs','2311','4','sis'),(24130934,'434','drt','rter','tttt','3423132','5','tre');
/*!40000 ALTER TABLE `Alumnos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Materias`
--

DROP TABLE IF EXISTS `Materias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Materias` (
  `idMateria` int NOT NULL AUTO_INCREMENT,
  `Materia` varchar(100) DEFAULT NULL,
  `CVE` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idMateria`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Materias`
--

LOCK TABLES `Materias` WRITE;
/*!40000 ALTER TABLE `Materias` DISABLE KEYS */;
INSERT INTO `Materias` VALUES (5,'rer','32e');
/*!40000 ALTER TABLE `Materias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Profesores`
--

DROP TABLE IF EXISTS `Profesores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Profesores` (
  `idProfesores` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) DEFAULT NULL,
  `CVE` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idProfesores`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Profesores`
--

LOCK TABLES `Profesores` WRITE;
/*!40000 ALTER TABLE `Profesores` DISABLE KEYS */;
INSERT INTO `Profesores` VALUES (3,'daniel peralta','122'),(5,'Pedro casa sola','4432'),(6,'dsd','ewe');
/*!40000 ALTER TABLE `Profesores` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-03-23 21:30:03
