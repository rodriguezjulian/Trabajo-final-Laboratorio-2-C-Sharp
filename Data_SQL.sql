-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 17-07-2023 a las 17:00:29
-- Versión del servidor: 8.0.31
-- Versión de PHP: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_transporte_rodriguez`
--
CREATE DATABASE IF NOT EXISTS `bd_transporte_rodriguez` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `bd_transporte_rodriguez`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE IF NOT EXISTS `clientes` (
  `Nombre` varchar(200) NOT NULL,
  `Contraseña` varchar(200) NOT NULL,
  `Mail` varchar(200) NOT NULL,
  `Estado` tinyint NOT NULL,
  `IdCliente` int NOT NULL AUTO_INCREMENT,
  `DireccionBSAS` varchar(200) NOT NULL,
  `Rubro` varchar(200) NOT NULL,
  PRIMARY KEY (`IdCliente`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`Nombre`, `Contraseña`, `Mail`, `Estado`, `IdCliente`, `DireccionBSAS`, `Rubro`) VALUES
('María García', 'maria456', 'maria.garcia@hotmail.com', 1, 1, 'Calle 25 de Mayo 5678', 'Electrodomésticos'),
('Lucas Martínez', 'lucas789', 'lucas.martinez@hotmail.com', 1, 2, 'Av. Corrientes 2468', 'Electrodosmesticos'),
('Ana Rodríguez', 'ana000', 'ana.rodriguez@gmail.com', 0, 3, 'Calle Florida 4321', 'Ropa'),
('Pedro González', 'pedro111', 'pedro.gonzalez@hotmail.com', 1, 4, 'Calle Reconquista 6789', 'Juguetes'),
('Laura Fernández', 'laura222', 'laura.fernandez@yahoo.com', 1, 5, 'Av. Santa Fe 2468', 'Calzado'),
('Javier Diaz', 'javier333', 'javier.diaz@gmail.com', 1, 6, 'Calle Maipú 3456', 'Hogar'),
('Carla Castro', 'carla444', 'carla.castro@hotmail.com', 1, 7, 'Calle Lavalle 6789', 'Mascotas'),
('Martín Suárez', 'martin555', 'martin.suarez@yahoo.com', 1, 8, 'Av. San Martín 1234', 'Computación'),
('Silvia López', 'silvia666', 'silvia.lopez@gmail.com', 1, 9, 'Calle Esmeralda 5678', 'Computación'),
('Federico Torres', 'federico777', 'federico.torres@hotmail.com', 1, 10, 'Av. Pueyrredón 2468', 'Computación'),
('Valeria Gómez', 'valeria888', 'valeria.gomez@yahoo.com', 1, 11, 'Calle Callao 4321', 'Computación'),
('Pablo Ramírez', 'pablo999', 'pablo.ramirez@gmail.com', 1, 12, 'Av. Córdoba 6789', 'Computación'),
('julian', '2194676429', 'rodriguez@hotmail.com', 0, 13, 'el nuevo gasometro', 'Ropa'),
('Julian', '18801475', 'sasdasdsa@hotmail.com', 1, 14, 'asdasd', 'Muebles');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

DROP TABLE IF EXISTS `empleados`;
CREATE TABLE IF NOT EXISTS `empleados` (
  `IdEmpleado` int NOT NULL AUTO_INCREMENT,
  `Puesto` varchar(100) NOT NULL,
  `Nombre` varchar(200) NOT NULL,
  `Contraseña` varchar(200) NOT NULL,
  `Mail` varchar(200) NOT NULL,
  `Estado` tinyint NOT NULL,
  PRIMARY KEY (`IdEmpleado`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`IdEmpleado`, `Puesto`, `Nombre`, `Contraseña`, `Mail`, `Estado`) VALUES
(1, 'Sistemas', 'María García', 'miClaveSegura', 'maria.garcia@hotmail.com', 1),
(2, 'Administracion', 'Juan Pérez', 'contra123', 'juan.perez@gmail.com', 1),
(3, 'Administracion', 'Carlos Fernández', 'qwerty1234', 'cfernandez@empresa.com', 0),
(4, 'Administracion', 'Sofía Rodríguez', 'contrasena123', 'sofiaro@gmail.com', 1),
(5, 'Cobranzas', 'Pedro González', 'contrasena123', 'sofiaro@gmail.com', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vehiculos`
--

DROP TABLE IF EXISTS `vehiculos`;
CREATE TABLE IF NOT EXISTS `vehiculos` (
  `IdVehiculo` int NOT NULL AUTO_INCREMENT,
  `MarcaVehiculo` varchar(100) NOT NULL,
  `Carga` float NOT NULL,
  `Color` varchar(200) NOT NULL,
  `Patente` varchar(8) NOT NULL,
  `Estado` tinyint NOT NULL,
  PRIMARY KEY (`IdVehiculo`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `vehiculos`
--

INSERT INTO `vehiculos` (`IdVehiculo`, `MarcaVehiculo`, `Carga`, `Color`, `Patente`, `Estado`) VALUES
(1, 'Fiat', 1000, 'Rojo', '123ABC', 0),
(2, 'Scania', 1500, 'Gris', '456FFF', 1),
(3, 'Ford', 2000, 'Negro', '789SDA', 1),
(4, 'Volkswagen', 500, 'Azul', '012AAA', 1),
(5, 'Iveco', 1200, 'Blanco', '344SSS', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `viajes`
--

DROP TABLE IF EXISTS `viajes`;
CREATE TABLE IF NOT EXISTS `viajes` (
  `IdViaje` int NOT NULL AUTO_INCREMENT,
  `NombreCliente` varchar(200) NOT NULL,
  `DireccionSalida` varchar(200) NOT NULL,
  `ProvinciaDestino` varchar(100) NOT NULL,
  `Precio` float NOT NULL,
  `IdVehiculo` int NOT NULL,
  `FechaViaje` date NOT NULL,
  `KilosATransportar` float NOT NULL,
  `IdCliente` int NOT NULL,
  `Estado` tinyint NOT NULL,
  PRIMARY KEY (`IdViaje`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `viajes`
--

INSERT INTO `viajes` (`IdViaje`, `NombreCliente`, `DireccionSalida`, `ProvinciaDestino`, `Precio`, `IdVehiculo`, `FechaViaje`, `KilosATransportar`, `IdCliente`, `Estado`) VALUES
(2, 'María García', 'Calle 25 de Mayo 5678', 'Misiones', 200, 10000, '2021-08-11', 1, 1, 1),
(7, 'Javier Diaz', 'Av. Córdoba 6789', 'Corrientes', 1800, 10500, '2022-05-11', 5, 2, 1),
(6, 'Laura Fernández', 'Av. Santa Fe 2468', 'Santa Fe', 20, 10500, '2023-08-11', 3, 3, 1),
(8, 'Javier Diaz', 'Calle Maipú 3456', 'Santa fe', 24000, 1, '2022-07-11', 100, 6, 1),
(9, 'Javier Diaz', 'Calle Maipú 3456', 'Corrientes', 86000, 2, '2023-07-11', 400, 6, 1),
(10, 'Javier Diaz', 'Calle Maipú 3456', 'Corrientes', 86000, 1, '2023-07-11', 400, 6, 0),
(11, 'Javier Diaz', 'Calle Maipú 3456', 'Santa fe', 14000, 3, '2023-07-11', 50, 6, 1),
(12, 'Javier Diaz', 'Calle Maipú 3456', 'Santa fe', 14000, 4, '2023-07-11', 50, 6, 1),
(13, 'Javier Diaz', 'Calle Maipú 3456', 'Santa fe', 14000, 5, '2023-07-11', 50, 6, 1),
(14, 'Javier Diaz', 'Calle Maipú 3456', 'Santa fe', 124000, 2, '2023-07-15', 600, 6, 0);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
