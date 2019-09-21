-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  Dim 05 mai 2019 à 16:27
-- Version du serveur :  5.7.24
-- Version de PHP :  7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `bddproprietaire`
--

-- --------------------------------------------------------

--
-- Structure de la table `bien_immobilier`
--

DROP TABLE IF EXISTS `bien_immobilier`;
CREATE TABLE IF NOT EXISTS `bien_immobilier` (
  `code` bigint(4) NOT NULL AUTO_INCREMENT,
  `nom` varchar(64) NOT NULL,
  `adresse` varchar(128) NOT NULL,
  `codeProprietaire` bigint(4) DEFAULT NULL,
  PRIMARY KEY (`code`),
  KEY `fk_bien_immobilier_personne` (`codeProprietaire`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `bien_immobilier`
--

INSERT INTO `bien_immobilier` (`code`, `nom`, `adresse`, `codeProprietaire`) VALUES
(1, 'Le Lac de Savenay', '3 rue des Potiers', 0),
(2, 'L\'hôtel', 'rue du A', 3),
(4, 'Le Jardin Des Plantes', 'Nantes', 10);

-- --------------------------------------------------------

--
-- Structure de la table `personne`
--

DROP TABLE IF EXISTS `personne`;
CREATE TABLE IF NOT EXISTS `personne` (
  `pers_id` bigint(4) NOT NULL AUTO_INCREMENT,
  `adresse` varchar(128) NOT NULL,
  `telephone` bigint(10) NOT NULL,
  PRIMARY KEY (`pers_id`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `personne`
--

INSERT INTO `personne` (`pers_id`, `adresse`, `telephone`) VALUES
(8, '56 boulevard de Fallon', 698541203),
(3, '35 rue de Bretagne - Nantes', 789456210),
(10, '598 lieu dit, Patos', 987451232),
(9, 'Inconnue', 125431678),
(11, '9 rue de Paris ', 897451976);

-- --------------------------------------------------------

--
-- Structure de la table `personne_morale`
--

DROP TABLE IF EXISTS `personne_morale`;
CREATE TABLE IF NOT EXISTS `personne_morale` (
  `pers_id` bigint(4) NOT NULL,
  `raison_sociale` varchar(64) NOT NULL,
  `forme_juridique` varchar(64) NOT NULL,
  PRIMARY KEY (`pers_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `personne_morale`
--

INSERT INTO `personne_morale` (`pers_id`, `raison_sociale`, `forme_juridique`) VALUES
(9, 'SNC', 'Entreprise'),
(11, 'Restaurants du Coeur', 'Association');

-- --------------------------------------------------------

--
-- Structure de la table `personne_physique`
--

DROP TABLE IF EXISTS `personne_physique`;
CREATE TABLE IF NOT EXISTS `personne_physique` (
  `pers_id` bigint(4) NOT NULL,
  `nom` varchar(64) NOT NULL,
  `prenom` varchar(64) NOT NULL,
  PRIMARY KEY (`pers_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `personne_physique`
--

INSERT INTO `personne_physique` (`pers_id`, `nom`, `prenom`) VALUES
(3, 'Yves', 'Jean'),
(8, 'Marlotes', 'Nathanaël'),
(10, 'Luigina', 'Mario');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
