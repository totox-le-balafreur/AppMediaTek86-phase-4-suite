-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 30 mai 2025 à 13:08
-- Version du serveur : 8.3.0
-- Version de PHP : 8.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(2, '2025-05-02 00:00:00', '2025-05-03 00:00:00', 4),
(3, '2025-01-15 08:30:00', '2025-01-20 17:00:00', 4),
(4, '2025-01-22 09:00:00', '2025-01-23 12:00:00', 2),
(5, '2025-02-01 08:00:00', '2025-02-03 17:00:00', 1),
(6, '2025-02-05 08:00:00', '2025-02-10 17:00:00', 3),
(7, '2025-02-12 09:00:00', '2025-02-15 17:00:00', 2),
(8, '2025-02-20 08:00:00', '2025-02-22 17:00:00', 4),
(9, '2025-03-01 08:00:00', '2025-03-03 17:00:00', 1),
(10, '2025-03-10 09:00:00', '2025-03-12 17:00:00', 3),
(2, '2025-03-18 09:00:00', '2025-03-20 17:00:00', 2),
(3, '2025-03-22 08:00:00', '2025-03-25 17:00:00', 1),
(4, '2025-03-28 08:30:00', '2025-03-30 17:00:00', 3),
(5, '2025-04-02 09:00:00', '2025-04-05 17:00:00', 2),
(6, '2025-04-07 08:00:00', NULL, 4),
(7, '2025-04-10 09:00:00', '2025-04-12 17:00:00', 1),
(8, '2025-04-15 08:00:00', '2025-04-18 17:00:00', 3),
(9, '2025-04-20 08:30:00', '2025-04-22 17:00:00', 2),
(10, '2025-04-25 09:00:00', '2025-04-28 17:00:00', 1),
(15, '2025-05-29 00:00:00', '2025-05-30 00:00:00', 1),
(2, '2025-05-10 00:00:00', '2025-05-21 00:00:00', 4),
(3, '2025-05-10 08:00:00', '2025-05-12 17:00:00', 2),
(4, '2025-05-15 08:30:00', '2025-05-17 17:00:00', 1),
(5, '2025-05-20 09:00:00', '2025-05-22 17:00:00', 3),
(6, '2025-05-25 08:00:00', '2025-05-27 17:00:00', 2),
(7, '2025-06-01 09:00:00', NULL, 4),
(8, '2025-06-05 08:00:00', '2025-06-07 17:00:00', 1),
(9, '2025-06-10 08:30:00', '2025-06-12 17:00:00', 3),
(10, '2025-06-15 09:00:00', '2025-06-18 17:00:00', 2),
(2, '2025-06-25 09:00:00', '2025-06-27 17:00:00', 3),
(3, '2025-07-01 08:00:00', NULL, 4),
(4, '2025-07-05 08:30:00', '2025-07-07 17:00:00', 2),
(5, '2025-07-10 09:00:00', '2025-07-12 17:00:00', 1),
(6, '2025-07-15 08:00:00', '2025-07-18 17:00:00', 3),
(7, '2025-07-20 09:00:00', '2025-07-22 17:00:00', 2),
(8, '2025-07-25 08:00:00', '2025-07-27 17:00:00', 4),
(9, '2025-07-30 08:30:00', NULL, 1),
(10, '2025-08-04 09:00:00', '2025-08-06 17:00:00', 3),
(2, '2025-08-14 09:00:00', '2025-08-16 17:00:00', 4),
(3, '2025-08-19 08:00:00', '2025-08-21 17:00:00', 1),
(4, '2025-08-24 08:30:00', NULL, 3),
(5, '2025-08-29 09:00:00', '2025-08-31 17:00:00', 2),
(6, '2025-09-03 08:00:00', '2025-09-06 17:00:00', 1),
(7, '2025-09-08 09:00:00', '2025-09-10 17:00:00', 4),
(8, '2025-09-13 08:00:00', '2025-09-15 17:00:00', 3),
(9, '2025-09-18 08:30:00', '2025-09-20 17:00:00', 2),
(10, '2025-09-23 09:00:00', NULL, 1),
(12, '2025-05-17 00:00:00', '2025-05-28 00:00:00', 4);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `mail` varchar(128) DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(11, 'Durand', 'Alice', '0611223344', 'alice.durand@example.com', 1),
(2, 'Martin', 'Jean', '0677889900', 'jean.martin@example.com', 2),
(12, 'Bernard', 'Lucie', '0655443322', 'lucie.bernard@example.com', 1),
(4, 'Petit', 'Marc', '0612345678', 'marc.petit@example.com', 3),
(5, 'Robert', 'Nadia', '0699887766', 'nadia.robert@example.com', 2),
(6, 'Lemoine', 'Julien', '0700112233', 'julien.lemoine@example.com', 3),
(7, 'Faure', 'Sophie', '0622334455', 'sophie.faure@example.com', 1),
(8, 'Lopez', 'Carlos', '0688776655', 'carlos.lopez@example.com', 3),
(9, 'Nguyen', 'Mai', '0633445566', 'mai.nguyen@example.com', 2),
(10, 'Dupuis', 'Clara', '0699776655', 'clara.dupuis@example.com', 3),
(16, 'tho', 'Dia', '0655664477', 'tho.dia@test.fr', 3);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) NOT NULL,
  `pwd` varchar(64) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('ton_login', 'ef8cb0bfdc6161492adee3b8111a17730a827bc042aebdba252308f0100434fb');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
