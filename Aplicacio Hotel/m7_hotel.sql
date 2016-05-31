-- phpMyAdmin SQL Dump
-- version 3.4.10.1deb1
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 21-04-2015 a las 19:48:26
-- Versión del servidor: 5.5.32
-- Versión de PHP: 5.3.10-1ubuntu3.16

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `m7_hotel`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clients`
--

CREATE TABLE IF NOT EXISTS `clients` (
  `dni` char(9) NOT NULL,
  `nom` varchar(20) DEFAULT NULL,
  `cognoms` varchar(50) DEFAULT NULL,
  `telefon` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`dni`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `clients`
--

INSERT INTO `clients` (`dni`, `nom`, `cognoms`, `telefon`) VALUES
('A43752452', 'Maria', 'Guardia Garcia', '973343434'),
('B62356725', 'Miriam', 'Diaz Ruiz', '665172819'),
('C45729525', 'Alex', 'Gené Garcia', '635716299'),
('F35622816', 'Mònica', 'Jimenez Ramirez', '973222525'),
('G23761819', 'David', 'Cortés Brufau', '973222525'),
('G62778091', 'Josep', 'Jimenez Ramirez', '973222525'),
('H62771902', 'Miquel', 'Rafel Berge', '973222525'),
('I42719201', 'Marcela', 'Uribe Zapata', '973222525'),
('J72881920', 'Anna', 'Garcia Spencer', '973222525'),
('K62773918', 'Francesc', 'Rodes Martinez', '973222525'),
('L26810276', 'Jordi', 'Ruiz Torres', '973222525'),
('M25335715', 'Joan', 'Diaz Rodriguez', '667222525'),
('S43737878', 'Albert', 'Sanchez Llibre', '973278191'),
('S45718920', 'Noelia', 'Fernandez Diaz', '976271782'),
('T67162910', 'Sebastià', 'Torres Samitier', '973222525'),
('V53662817', 'Susana', 'Aguila Catala', '973222525');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `habitacions`
--

CREATE TABLE IF NOT EXISTS `habitacions` (
  `num_hab` int(11) NOT NULL,
  `llits` int(11) NOT NULL,
  `nevera` bit(1) DEFAULT NULL,
  `bany` bit(1) DEFAULT NULL,
  `tv` bit(1) DEFAULT NULL,
  `m2` int(11) DEFAULT NULL,
  PRIMARY KEY (`num_hab`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `habitacions`
--

INSERT INTO `habitacions` (`num_hab`, `llits`, `nevera`, `bany`, `tv`, `m2`) VALUES
(101, 1, b'1', b'0', b'1', 5),
(102, 1, b'1', b'0', b'1', 5),
(103, 1, b'1', b'0', b'1', 5),
(104, 2, b'1', b'0', b'1', 7),
(105, 2, b'1', b'0', b'1', 7),
(106, 2, b'1', b'0', b'1', 7),
(107, 2, b'1', b'0', b'1', 7),
(108, 2, b'1', b'0', b'1', 7),
(109, 1, b'1', b'0', b'1', 6),
(110, 1, b'1', b'0', b'1', 5),
(111, 2, b'1', b'0', b'1', 7),
(112, 2, b'1', b'0', b'1', 7),
(201, 1, b'1', b'0', b'1', 5),
(202, 1, b'1', b'0', b'1', 5),
(203, 1, b'1', b'0', b'1', 5),
(204, 2, b'1', b'0', b'1', 7),
(205, 2, b'1', b'0', b'1', 7),
(206, 2, b'1', b'0', b'1', 7),
(207, 2, b'1', b'0', b'1', 7),
(208, 2, b'1', b'0', b'1', 7),
(209, 1, b'1', b'0', b'1', 6),
(210, 1, b'1', b'0', b'1', 5),
(211, 2, b'1', b'0', b'1', 7),
(212, 2, b'1', b'0', b'1', 7),
(301, 1, b'1', b'0', b'1', 5),
(302, 1, b'1', b'0', b'1', 5),
(303, 1, b'1', b'0', b'1', 5),
(304, 2, b'1', b'0', b'1', 7),
(305, 2, b'1', b'0', b'1', 7),
(306, 2, b'1', b'0', b'1', 7),
(307, 2, b'1', b'0', b'1', 7),
(308, 2, b'1', b'0', b'1', 7),
(309, 1, b'1', b'0', b'1', 6),
(310, 1, b'1', b'0', b'1', 5),
(311, 2, b'1', b'0', b'1', 7),
(312, 2, b'1', b'0', b'1', 7);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reserves`
--

CREATE TABLE IF NOT EXISTS `reserves` (
  `num_hab` int(11) DEFAULT NULL,
  `dni` char(9) DEFAULT NULL,
  `data_ent` date DEFAULT NULL,
  `data_sort` date DEFAULT NULL,
  `neteja` tinyint(1) NOT NULL,
  KEY `num_hab` (`num_hab`),
  KEY `dni` (`dni`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `reserves`
--

INSERT INTO `reserves` (`num_hab`, `dni`, `data_ent`, `data_sort`, `neteja`) VALUES
(101, 'G62778091', '2015-04-23', '2015-04-30', 0),
(103, 'A43752452', '2015-05-01', '2015-05-03', 0),
(108, 'S43737878', '2015-04-25', '2015-04-26', 0),
(111, 'B62356725', '2015-05-03', '2015-05-06', 0),
(202, 'C45729525', '2015-04-20', '2015-04-24', 0),
(205, 'M25335715', '2015-04-19', '2015-05-30', 0),
(210, 'S45718920', '2015-04-23', '2015-05-08', 0),
(303, 'F35622816', '2015-04-27', '2015-05-02', 0),
(304, 'J72881920', '2015-04-22', '2015-04-27', 0),
(309, 'K62773918', '2015-05-01', '2015-05-10', 0),
(312, 'V53662817', '2015-04-20', '2015-04-28', 0);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `reserves`
--
ALTER TABLE `reserves`
  ADD CONSTRAINT `reserves_ibfk_1` FOREIGN KEY (`num_hab`) REFERENCES `habitacions` (`num_hab`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `reserves_ibfk_2` FOREIGN KEY (`dni`) REFERENCES `clients` (`dni`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
