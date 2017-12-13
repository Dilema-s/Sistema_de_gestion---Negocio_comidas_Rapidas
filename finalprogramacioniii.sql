-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 07-12-2017 a las 18:44:26
-- Versión del servidor: 5.5.24-log
-- Versión de PHP: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `finalprogramacioniii`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `acceso`
--

CREATE TABLE IF NOT EXISTS `acceso` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_persona` int(11) NOT NULL,
  `nombre_usuario` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `baja` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre_usuario` (`nombre_usuario`),
  UNIQUE KEY `nombre_usuario_2` (`nombre_usuario`),
  KEY `id_persona` (`id_persona`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Volcado de datos para la tabla `acceso`
--

INSERT INTO `acceso` (`id`, `id_persona`, `nombre_usuario`, `password`, `baja`) VALUES
(1, 1, 'admin', 'admin', 0),
(5, 6, 'marcelo', 'asdasd', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cargo`
--

CREATE TABLE IF NOT EXISTS `cargo` (
  `id_cargo` int(11) NOT NULL AUTO_INCREMENT,
  `cargo` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`id_cargo`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci AUTO_INCREMENT=11 ;

--
-- Volcado de datos para la tabla `cargo`
--

INSERT INTO `cargo` (`id_cargo`, `cargo`) VALUES
(1, 'Mozo'),
(2, 'Cajero'),
(3, 'Cociner@'),
(4, 'Ayudante de Cociner@'),
(5, 'Limpieza'),
(6, 'Admistrador de Sistema'),
(7, 'Gerente'),
(8, 'Socio'),
(9, 'Dueño'),
(10, 'Pasante');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

CREATE TABLE IF NOT EXISTS `categoria` (
  `id_categoria` int(11) NOT NULL AUTO_INCREMENT,
  `categoria` varchar(40) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`id_categoria`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci AUTO_INCREMENT=11 ;

--
-- Volcado de datos para la tabla `categoria`
--

INSERT INTO `categoria` (`id_categoria`, `categoria`) VALUES
(1, 'Ingrediente'),
(2, 'Otros'),
(3, 'Bebida'),
(4, 'Hamburguesas'),
(5, 'Minutas'),
(6, 'Picada'),
(7, 'Gasesosa'),
(8, 'Cerveza'),
(9, 'Helados'),
(10, 'Ensalada');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `comanda`
--

CREATE TABLE IF NOT EXISTS `comanda` (
  `id_comanda` int(11) NOT NULL AUTO_INCREMENT,
  `puesto` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  `id_persona` int(11) NOT NULL,
  `mesa` int(11) NOT NULL,
  `total` float NOT NULL,
  `estado` int(11) NOT NULL,
  `baja` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_comanda`),
  KEY `id_persona` (`id_persona`),
  KEY `estado` (`estado`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=45 ;

--
-- Volcado de datos para la tabla `comanda`
--

INSERT INTO `comanda` (`id_comanda`, `puesto`, `fecha`, `id_persona`, `mesa`, `total`, `estado`, `baja`) VALUES
(1, 1, '2017-12-04 00:42:06', 1, 2, 0, 1, 0),
(8, 1, '2017-12-03 22:34:14', 3, 3, 0, 1, 0),
(15, 1, '2017-12-03 22:44:01', 1, 3, 0, 1, 0),
(16, 1, '2017-12-03 22:52:12', 1, 2, 0, 1, 0),
(17, 1, '2017-12-03 22:54:01', 1, 2, 0, 1, 0),
(18, 1, '2017-12-03 22:54:40', 1, 2, 0, 1, 0),
(19, 1, '2017-12-03 22:56:02', 1, 3, 0, 1, 0),
(20, 1, '2017-12-03 23:43:40', 1, 2, 0, 1, 0),
(21, 1, '2017-12-03 23:51:31', 1, 1, 0, 1, 0),
(22, 1, '2017-12-04 00:48:15', 1, 2, 0, 1, 0),
(23, 1, '2017-12-04 00:48:34', 1, 3, 0, 1, 0),
(24, 1, '2017-12-04 01:16:23', 1, 2, 0, 1, 0),
(25, 1, '2017-12-04 01:18:15', 1, 2, 0, 1, 0),
(26, 1, '2017-12-04 02:55:40', 1, 2, 0, 1, 0),
(27, 1, '2017-12-04 02:57:33', 1, 2, 0, 2, 1),
(28, 1, '2017-12-04 03:06:02', 1, 1, 9, 2, 1),
(29, 1, '2017-12-04 03:10:11', 3, 1, 48, 2, 1),
(30, 1, '2017-12-04 03:13:00', 4, 2, 74, 2, 1),
(31, 1, '2017-12-04 03:15:16', 5, 1, 860, 2, 1),
(32, 1, '2017-12-04 03:20:44', 1, 3, 0, 1, 0),
(33, 1, '2017-12-04 03:23:59', 1, 1, 0, 1, 0),
(34, 1, '2017-12-04 03:26:52', 1, 2, 0, 1, 0),
(35, 1, '2017-12-04 04:03:58', 1, 2, 0, 1, 0),
(36, 1, '2017-12-04 04:06:03', 1, 2, 0, 1, 0),
(37, 1, '2017-12-04 04:10:58', 1, 2, 0, 1, 0),
(38, 1, '2017-12-04 04:12:39', 1, 1, 0, 2, 1),
(39, 1, '2017-12-04 14:37:20', 1, 2, 0, 3, 1),
(40, 1, '2017-12-04 14:39:11', 1, 1, 0, 1, 0),
(41, 1, '2017-12-04 15:03:36', 1, 1, 0, 1, 0),
(42, 1, '2017-12-04 15:06:09', 1, 4, 0, 1, 0),
(43, 1, '2017-12-05 16:31:51', 6, 2, 521, 2, 1),
(44, 1, '2017-12-05 17:03:07', 1, 4, 0, 1, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `comprobante_compra`
--

CREATE TABLE IF NOT EXISTS `comprobante_compra` (
  `id_comprobante_compra` int(11) NOT NULL AUTO_INCREMENT,
  `numero_comp` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `id_proveedor` int(11) DEFAULT NULL,
  `baja` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_comprobante_compra`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Volcado de datos para la tabla `comprobante_compra`
--

INSERT INTO `comprobante_compra` (`id_comprobante_compra`, `numero_comp`, `fecha`, `id_proveedor`, `baja`) VALUES
(1, 12123, '2017-12-01', 0, 0),
(2, 123123, '2017-12-01', 0, 0),
(3, 123123, '2017-12-01', 1, 0),
(4, 123123, '2017-12-01', 1, 0),
(5, 123123, '2017-12-01', 1, 0),
(6, 123123, '2017-12-01', 1, 0),
(7, 123123, '2017-12-01', 1, 0),
(8, 123123, '2017-12-01', 1, 0),
(9, 111123, '2017-12-01', 1, 0),
(10, 11111, '2017-12-01', 1, 0),
(11, 123123, '2017-12-07', 1, 0),
(12, 0, '2017-12-07', 2, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_comanda`
--

CREATE TABLE IF NOT EXISTS `detalle_comanda` (
  `id_detalle_comanda` int(11) NOT NULL AUTO_INCREMENT,
  `id_comanda` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `cantidad` float NOT NULL,
  `precio_venta` float NOT NULL,
  `precio_costo` float NOT NULL,
  `total` float NOT NULL,
  `baja` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_detalle_comanda`),
  KEY `id_comanda` (`id_comanda`),
  KEY `id_producto` (`id_producto`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=30 ;

--
-- Volcado de datos para la tabla `detalle_comanda`
--

INSERT INTO `detalle_comanda` (`id_detalle_comanda`, `id_comanda`, `id_producto`, `nombre`, `cantidad`, `precio_venta`, `precio_costo`, `total`, `baja`) VALUES
(1, 28, 30, 'Bizcocho', 2, 4.5, 0, 9, 0),
(2, 29, 1, 'Papas fritas', 2, 15, 30, 30, 0),
(3, 29, 30, 'Bizcocho', 4, 4.5, 0, 18, 0),
(4, 30, 2, 'Fanta', 2, 22, 25, 44, 0),
(5, 30, 84, 'Cafe español', 2, 15, 0, 30, 0),
(6, 31, 24, 'Lechuga', 3, 215, 1545, 645, 0),
(7, 31, 24, 'Lechuga', 1, 215, 1545, 215, 0),
(8, 31, 28, 'Jamón Cocido', 1, 0, 0, 0, 0),
(9, 32, 26, 'Medialuna', 2, 0, 0, 0, 0),
(10, 32, 69, 'Medialuna', 1, 0, 0, 0, 0),
(11, 32, 69, 'Medialuna', 2, 0, 0, 0, 0),
(12, 32, 69, 'Mac-Combo', 1, 99.99, 0, 100, 0),
(13, 33, 84, 'Cafe español', 2, 15, 0, 30, 0),
(14, 33, 26, 'Medialuna', 4, 0, 0, 0, 0),
(15, 33, 27, 'Tée', 1, 5, 0, 5, 0),
(16, 33, 100, 'Producto 100', 2, 100.25, 70, 200, 0),
(17, 34, 100, 'Producto 100', 2, 100.25, 70, 200, 0),
(18, 34, 100, 'Producto 100', 3, 100.25, 70, 301, 0),
(19, 35, 84, 'Cafe español', 2, 15, 0, 30, 0),
(20, 35, 84, 'Cafe español', 1, 15, 0, 15, 0),
(21, 36, 85, 'dfdfdf', 1, 0, 0, 0, 0),
(22, 37, 1, 'Papas fritas', 1, 15, 30, 15, 0),
(23, 37, 24, 'Lechuga', 2, 215, 1545, 430, 0),
(24, 42, 26, 'Medialuna', 2, 0, 0, 0, 0),
(25, 42, 25, 'Tomate', 1, 0, 0, 0, 0),
(26, 43, 24, 'Lechuga', 2, 215, 1545, 430, 0),
(27, 43, 73, 'Cafe Irlandes', 2, 45.5, 0, 91, 0),
(28, 44, 84, 'Cafe español', 1, 15, 0, 15, 0),
(29, 44, 150, 'Pan arabe relleno', 3, 30, 20, 90, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_comprobante`
--

CREATE TABLE IF NOT EXISTS `detalle_comprobante` (
  `id_detalle_comprobante` int(11) NOT NULL AUTO_INCREMENT,
  `id_producto` int(11) NOT NULL,
  `precio` float NOT NULL,
  `cantidad` float NOT NULL,
  `id_comprobante_compra` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_comprobante`),
  KEY `id_producto` (`id_producto`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Volcado de datos para la tabla `detalle_comprobante`
--

INSERT INTO `detalle_comprobante` (`id_detalle_comprobante`, `id_producto`, `precio`, `cantidad`, `id_comprobante_compra`) VALUES
(1, 2, 123, 10, 0),
(2, 2, 123, 123, 5),
(3, 5, 123, 123, 6),
(4, 5, 123, 123, 7),
(5, 2, 123, 123, 8),
(6, 5, 123, 123, 9),
(7, 25, 10, 35, 9),
(8, 24, 100, 1, 9),
(9, 25, 65, 5, 9),
(10, 2, 123, 123, 10),
(11, 1, 123, 100, 11),
(12, 2, 123, 100, 12);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_receta`
--

CREATE TABLE IF NOT EXISTS `detalle_receta` (
  `id_detalle_receta` int(11) NOT NULL AUTO_INCREMENT,
  `id_receta` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cantidad` float NOT NULL,
  `unidad` int(11) NOT NULL,
  `baja` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_detalle_receta`),
  UNIQUE KEY `unique_index` (`id_producto`,`id_receta`),
  KEY `unidad` (`unidad`),
  KEY `id_receta` (`id_receta`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=125 ;

--
-- Volcado de datos para la tabla `detalle_receta`
--

INSERT INTO `detalle_receta` (`id_detalle_receta`, `id_receta`, `id_producto`, `cantidad`, `unidad`, `baja`) VALUES
(11, 1, 28, 300, 1, 1),
(12, 1, 25, 1, 3, 1),
(15, 1, 5, 45, 2, 0),
(16, 1, 12, 50, 3, 1),
(17, 3, 24, 4, 1, 0),
(18, 4, 29, 45, 2, 0),
(20, 5, 12, 4, 2, 0),
(21, 5, 5, 9, 1, 0),
(22, 5, 24, 2, 3, 0),
(23, 5, 25, 2, 3, 0),
(24, 6, 24, 200, 1, 0),
(25, 7, 25, 45, 2, 0),
(27, 8, 24, 3, 2, 0),
(28, 9, 28, 3, 2, 0),
(30, 10, 28, 33, 2, 0),
(31, 10, 5, 3, 2, 0),
(32, 11, 12, 300, 1, 1),
(33, 11, 5, 35, 1, 1),
(34, 12, 28, 5, 2, 0),
(36, 12, 12, 4, 2, 0),
(37, 12, 29, 2, 3, 0),
(38, 16, 12, 7, 2, 0),
(39, 16, 88, 3, 2, 0),
(40, 17, 24, 4, 1, 0),
(41, 18, 28, 1, 3, 0),
(42, 18, 12, 1, 3, 0),
(44, 19, 24, 5, 2, 0),
(45, 19, 12, 5, 2, 0),
(47, 20, 88, 5, 2, 0),
(49, 21, 88, 5, 2, 1),
(51, 21, 12, 2, 2, 1),
(52, 22, 88, 5, 2, 0),
(53, 22, 24, 5, 2, 0),
(56, 23, 88, 4, 2, 1),
(58, 24, 88, 4, 2, 1),
(60, 25, 28, 5, 2, 0),
(61, 25, 12, 3, 2, 0),
(62, 26, 12, 29, 2, 1),
(63, 26, 5, 45, 2, 1),
(64, 27, 12, 5, 2, 0),
(65, 28, 12, 34, 2, 1),
(67, 28, 29, 2, 3, 1),
(68, 28, 24, 3, 1, 1),
(69, 29, 88, 3, 2, 1),
(70, 29, 28, 3, 2, 1),
(71, 30, 12, 2, 2, 0),
(72, 31, 12, 4, 2, 0),
(73, 33, 12, 3, 2, 0),
(74, 36, 88, 3, 2, 1),
(75, 36, 28, 4, 2, 1),
(76, 37, 12, 3, 2, 0),
(77, 37, 28, 5, 2, 0),
(78, 38, 24, 45, 2, 0),
(79, 38, 5, 34, 2, 0),
(80, 40, 24, 99, 2, 0),
(81, 41, 12, 45, 2, 0),
(82, 44, 12, 33, 2, 1),
(83, 44, 5, 44, 2, 1),
(84, 45, 5, 33, 2, 1),
(85, 45, 12, 3, 3, 1),
(86, 46, 88, 3, 3, 1),
(87, 46, 28, 3, 3, 1),
(88, 1, 24, 40, 1, 0),
(95, 1, 29, 2, 3, 1),
(110, 1, 88, 4, 2, 0),
(122, 47, 88, 33, 2, 0),
(123, 47, 28, 34, 1, 0),
(124, 48, 12, 3, 1, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empresa`
--

CREATE TABLE IF NOT EXISTS `empresa` (
  `id_empresa` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `cuit` varchar(13) NOT NULL,
  `tipo_responsabilidad` varchar(50) NOT NULL,
  `ciudad` varchar(50) NOT NULL,
  `provincia` varchar(50) NOT NULL,
  `direccion` varchar(50) NOT NULL,
  `mail` varchar(50) NOT NULL,
  `web` varchar(50) NOT NULL,
  `cp` varchar(10) NOT NULL,
  `fecha_inicio_act` date NOT NULL,
  PRIMARY KEY (`id_empresa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadocomanda`
--

CREATE TABLE IF NOT EXISTS `estadocomanda` (
  `id_estadoComanda` int(11) NOT NULL AUTO_INCREMENT,
  `estado` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`id_estadoComanda`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `estadocomanda`
--

INSERT INTO `estadocomanda` (`id_estadoComanda`, `estado`) VALUES
(1, 'Abierta'),
(2, 'Cerrada'),
(3, 'Eliminada');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mozo`
--

CREATE TABLE IF NOT EXISTS `mozo` (
  `id_mozo` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `calle` varchar(50) NOT NULL,
  `nro` int(11) NOT NULL,
  `dni` varchar(20) NOT NULL,
  `telefono` varchar(20) NOT NULL,
  `activo` tinyint(4) NOT NULL,
  PRIMARY KEY (`id_mozo`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Volcado de datos para la tabla `mozo`
--

INSERT INTO `mozo` (`id_mozo`, `nombre`, `apellido`, `calle`, `nro`, `dni`, `telefono`, `activo`) VALUES
(1, 'Sergio', 'Cabral', 'Alem', 539, '', '3492607853', 0),
(2, 'Sergio', 'Cabral', 'Alem', 539, '', '3492607853', 0),
(3, 'Sergio', 'Cabral', 'Alem', 539, '', '3492607853', 0),
(4, 'Checho', 'Vogt', 'Alem', 539, '32503328', '3492555555', 1),
(5, 'José', 'Imhoff', 'Alberdi', 456, '32000000', '3492222222', 0),
(6, 'Alejandro', 'Tassoni', 'Alberdi', 456, '32000000', '3492333333', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `persona`
--

CREATE TABLE IF NOT EXISTS `persona` (
  `id_persona` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `dni` int(9) NOT NULL,
  `cargo` int(11) NOT NULL,
  `calle` varchar(50) NOT NULL,
  `altura` varchar(20) DEFAULT NULL,
  `telefono` varchar(20) NOT NULL,
  `fecha_ingreso` date NOT NULL,
  `baja` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_persona`),
  KEY `cargo` (`cargo`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Volcado de datos para la tabla `persona`
--

INSERT INTO `persona` (`id_persona`, `nombre`, `apellido`, `dni`, `cargo`, `calle`, `altura`, `telefono`, `fecha_ingreso`, `baja`) VALUES
(1, 'Matias', 'Ferrero', 31566730, 3, 'españa', '58', '34564321', '2017-12-12', 0),
(3, 'Sergio', 'Vogt', 32503328, 1, 'Alem', '539', '3492333333', '2017-12-07', 0),
(4, 'Monica', 'Galindo', 30235328, 1, 'Menchaca', NULL, '31354987', '2017-12-07', 0),
(5, 'Armando', 'Paredes', 16607951, 7, 'Bolivar', NULL, '34925522', '2017-12-07', 0),
(6, 'Marcelo', 'Perez', 40000000, 1, 'San Martin', NULL, '3492323232', '2017-12-07', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE IF NOT EXISTS `producto` (
  `id_producto` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `descripcion` varchar(100) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT 'Sin descripción',
  `marca` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_spanish_ci DEFAULT 'Sin marca',
  `categoria` int(11) NOT NULL,
  `stock` int(11) DEFAULT '0',
  `stock_minimo` int(11) DEFAULT '0',
  `precio_venta` float DEFAULT '0',
  `precio_costo` float DEFAULT '0',
  `lista_precio` tinyint(1) NOT NULL,
  `baja` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_producto`),
  KEY `categoria` (`categoria`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=151 ;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`id_producto`, `nombre`, `descripcion`, `marca`, `categoria`, `stock`, `stock_minimo`, `precio_venta`, `precio_costo`, `lista_precio`, `baja`) VALUES
(1, 'Papas fritas', 'Papas cortadas en julianas', 'Sin marca', 5, 100, 0, 15, 123, 1, 0),
(2, 'Fanta', 'Gaseosa de Naranja', 'Fanta', 3, 115, 2, 22, 123, 1, 0),
(4, 'Helado de chocolate', '', 'Arcor', 9, 50, 0, 0, 15, 1, 1),
(5, 'Mostaza', '', 'Savora', 1, 0, 0, 0, 0, 0, 0),
(12, 'Mayonesa', '1 kg', 'Cada día', 1, 0, 0, 0, 0, 0, 0),
(21, 'Cafe', 'Sin descripción', 'Sin marca', 3, 0, 0, 0, 0, 1, 1),
(24, 'Lechuga', 'Crespa, Fresca, grande', 'Pupi', 1, 0, 0, 215, 1545, 1, 0),
(25, 'Tomate', 'Perita', 'Sin marca', 1, 0, 0, 0, 0, 0, 0),
(26, 'Medialuna', 'Tu panadería', 'Sin marca', 2, 0, 0, 0, 0, 1, 0),
(27, 'Tée', 'La Virginia', 'Sin marca', 1, 0, 0, 5, 0, 1, 0),
(28, 'Jamón Cocido', 'Sin marca', 'Sin marca', 1, 0, 0, 0, 0, 0, 0),
(29, 'Queso en barra', 'Sin descripción', 'Ramolac', 1, 0, 0, 0, 0, 0, 0),
(30, 'Bizcocho', 'Sin descripción', 'Tu panadería', 2, 0, 0, 4.5, 0, 1, 0),
(68, 'KETCHUP', '', '', 3, 0, 0, 0, 0, 1, 0),
(69, 'Mac-Combo', 'Hamburguesa del día', 'Sin marca', 4, 0, 0, 99.99, 0, 1, 0),
(70, 'Licuado', 'Sin descripción', 'Sin marca', 3, 0, 0, 50, 0, 1, 1),
(71, 'helado', 'Sin descripción', 'Sin marca', 9, 0, 0, 20, 0, 1, 1),
(72, 'Mac-Combo', 'Hamburguesa', 'Sin marca', 4, 0, 0, 98.99, 0, 1, 1),
(73, 'Cafe Irlandes', 'Sin descripción', 'Sin marca', 2, 0, 0, 45.5, 0, 1, 0),
(74, 'fgfgf', 'Sin descripción', 'Sin marca', 2, 0, 0, 45, 0, 1, 1),
(75, 'dfdf', 'Sin descripción', 'Sin marca', 10, 0, 0, 34, 0, 1, 1),
(76, 'Sin nombre', 'Sin descripción', 'Sin marca', 10, 0, 0, 33, 0, 1, 0),
(77, 'Cafe Ataque', 'Sin descripción', 'Sin marca', 2, 0, 0, 23, 0, 1, 0),
(78, 'Canela', 'Sin descripción', 'La morenita', 2, 0, 0, 12, 0, 1, 0),
(79, 'whisky', 'Sin Descripción', 'Jonnie Walker', 3, 0, 0, 1200, 0, 1, 0),
(80, 'Cafe Irlandes', 'Sin Descripción', 'Sin marca', 1, 0, 0, 40, 0, 1, 0),
(81, 'fgfgf', 'Sin descripción', 'Sin marca', 2, 0, 0, 0, 0, 1, 0),
(82, 'xcx', 'Sin descripción', 'Sin marca', 2, 0, 0, 0, 0, 1, 1),
(83, 'dsd', 'ttttt', 'Sin marca', 2, 0, 0, 123, 0, 1, 0),
(84, 'Cafe español', 'Sin descripción', 'Sin marca', 2, 0, 0, 15, 0, 1, 0),
(85, 'dfdfdf', 'Sin descripción', 'Sin marca', 1, 0, 0, 0, 0, 1, 0),
(86, 'hhhhh', 'Sin descripción', 'Sin marca', 2, 0, 0, 0, 0, 1, 0),
(87, 'Los piojos', 'Sin descripción', 'Sin marca', 2, 0, 0, 0, 0, 1, 0),
(88, 'ererer', 'Sin descripción', 'Sin marca', 1, 0, 0, 0, 0, 0, 0),
(89, 'Sin nombre', 'Sin descripción', 'Sin marca', 2, 0, 0, 0, 0, 1, 0),
(90, 'Caquita', 'Sin descripción', 'Sin marca', 7, 0, 0, 1, 0, 1, 0),
(91, 'dfdf', 'Sin descripción', 'Sin marca', 2, 0, 0, 2, 0, 1, 0),
(92, 'cafe con leche', 'Sin descripción', 'Sin marca', 2, 0, 0, 15, 0, 1, 0),
(93, 'cafe con chocolate', 'Sin descripción', 'Sin marca', 3, 0, 0, 23, 0, 1, 0),
(94, 'dfdfd', 'Sin descripción', 'Sin marca', 2, 0, 0, 3, 0, 1, 0),
(95, 'fdf', 'Sin descripción', 'Sin marca', 2, 0, 0, 4, 0, 1, 0),
(96, 'ffff', 'Sin descripción', 'Sin marca', 2, 0, 0, 4, 0, 1, 1),
(97, 'ddd', 'Sin descripción', 'Sin marca', 2, 0, 0, 1, 0, 1, 0),
(98, 'dddd', 'Sin Descripción', 'Sin marca', 2, 0, 0, 1, 0, 1, 0),
(99, 'cc3', 'Sin descripción', 'Sin marca', 2, 0, 0, 2, 0, 1, 0),
(100, 'Producto 100', 'Plato de mar', 'Sin marca', 2, 0, 0, 100.25, 70, 1, 0),
(101, 'dfdfd', 'Sin descripción', 'Sin marca', 2, 0, 0, 5, 0, 1, 0),
(102, 'Mac Combo', 'Hamburguesas del día', 'Sin marca', 4, 0, 0, 99.98, 0, 1, 0),
(103, 'hghgh', 'Sin descripción', 'Sin marca', 7, 0, 0, 23, 0, 1, 0),
(104, 'rrrr', 'Sin descripción', 'Sin marca', 2, 0, 0, 1, 0, 1, 0),
(105, 'hhhh', 'Sin descripción', 'Sin marca', 2, 0, 0, 2, 0, 1, 0),
(106, 'dfdfd', 'Sin descripción', 'Sin marca', 2, 0, 0, 1, 0, 1, 0),
(107, 'fgfg', 'Sin descripción', 'Sin marca', 2, 0, 0, 4, 0, 1, 0),
(108, 'fafa', 'Sin descripción', 'Sin marca', 2, 0, 0, 73, 0, 1, 0),
(109, 'fafa', 'Sin descripción', 'Sin marca', 2, 0, 0, 43, 0, 1, 0),
(110, 'sdsd', 'Sin Descripción', 'Sin marca', 7, 0, 0, 3, 0, 1, 0),
(111, 'xxxx', 'Sin descripción', 'Sin marca', 2, 0, 0, 69, 0, 1, 1),
(112, 'ddd', 'Sin descripción', 'Sin marca', 2, 0, 0, 23, 0, 1, 0),
(113, 'ccc', 'Sin descripción', 'Sin marca', 2, 0, 0, 1, 0, 1, 0),
(114, 'ccc', 'Sin Descripción', 'Sin marca', 2, 0, 0, 2, 0, 1, 0),
(115, 'fgfg', 'Sin descripción', 'Sin marca', 2, 0, 0, 1, 0, 1, 0),
(116, 'xxxx', 'Sin descripción', 'Sin marca', 2, 0, 0, 4, 0, 1, 1),
(117, 'ffff', 'Sin descripción', 'Sin marca', 2, 0, 0, 1, 0, 1, 1),
(118, 'dfd', 'Sin descripción', 'Sin marca', 2, 0, 0, 3, 0, 1, 0),
(119, 'dfdf', 'Sin Descripción', 'Sin marca', 2, 0, 0, 34, 0, 1, 0),
(120, 'fdfd', 'Sin descripción', 'Sin marca', 2, 0, 0, 4, 0, 1, 0),
(121, 'dfdf', 'Sin Descripción', 'Sin marca', 2, 0, 0, 3, 0, 1, 0),
(122, 'dfdf', 'Sin descripción', 'Sin marca', 2, 0, 0, 3, 0, 1, 0),
(123, 'dfdf', 'Sin descripción', 'Sin marca', 2, 0, 0, 3, 0, 1, 0),
(124, 'sdsd', 'Sin descripción', 'Sin marca', 2, 0, 0, 4, 0, 1, 0),
(125, 'dfdf', 'Sin Descripción', 'Sin marca', 2, 0, 0, 4, 0, 1, 0),
(126, 'sdsd', 'Sin descripción', 'Sin marca', 2, 0, 0, 3, 0, 1, 0),
(127, 'dsds', 'Sin Descripción', 'Sin marca', 2, 0, 0, 3, 0, 1, 0),
(128, 'dfdf', 'Sin descripción', 'Sin marca', 2, 0, 0, 4, 0, 1, 0),
(129, 'sdsd', 'Sin descripción', 'Sin marca', 2, 0, 0, 333, 0, 1, 0),
(130, 'dsds', 'Sin descripción', 'Sin marca', 8, 0, 0, 1, 0, 1, 0),
(131, 'fff', 'Sin descripción', 'Sin marca', 2, 0, 0, 2, 0, 1, 0),
(132, '334', 'Sin descripción', 'Sin marca', 2, 0, 0, 3, 0, 1, 0),
(133, 'sdsd', 'Sin descripción', 'Sin marca', 2, 0, 0, 3, 0, 1, 0),
(134, 'Prueba', 'Sin descripción', 'Sin marca', 10, 0, 0, 15, 0, 1, 0),
(135, 'prueba', 'Sin descripción', 'Sin marca', 2, 0, 0, 3, 0, 1, 0),
(136, 'prueba 3', 'Sin descripción', 'Sin marca', 10, 0, 0, 3, 0, 1, 0),
(137, 'Prueba 4', 'Sin descripción', 'Sin marca', 7, 0, 0, 1, 0, 1, 0),
(138, 'prueba 4', 'Sin descripción', 'Sin marca', 6, 0, 0, 3, 0, 1, 0),
(139, 'hhhh', 'Sin descripción', 'Sin marca', 2, 0, 0, 3, 0, 1, 0),
(140, 'ahora si', 'Sin descripción', 'Sin marca', 2, 0, 0, 11, 0, 1, 0),
(141, 'Empanadas', 'Sin descripción', 'Sin marca', 5, 0, 0, 10, 0, 1, 0),
(142, 'gfg', 'Sin descripción', 'Sin marca', 2, 0, 0, 2, 0, 1, 0),
(143, 'fgfg', 'Sin descripción', 'Sin marca', 2, 0, 0, 3, 0, 1, 0),
(144, 'fgfg', 'Sin Descripción', 'Sin marca', 2, 0, 0, 4, 0, 1, 0),
(145, 'dfd', 'Sin descripción', 'Sin marca', 2, 0, 0, 3, 0, 1, 0),
(146, 'pizza', 'Sin descripción', 'Sin marca', 2, 0, 0, 150, 0, 1, 0),
(147, 'Picada de milanesa', 'Sin descripción', 'Sin marca', 2, 0, 0, 100, 0, 1, 0),
(148, 'FFDFD', 'Sin descripción', 'Sin marca', 2, 0, 0, 2, 0, 1, 0),
(149, 'Amargo sin alcohol', 'Pomelo Rosado', 'Terma', 3, 0, 0, 20, 12, 1, 0),
(150, 'Pan arabe relleno', 'Pan relleno de jamón y queso', 'Sin marca', 5, 0, 0, 30, 20, 1, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE IF NOT EXISTS `proveedor` (
  `id_proveedor` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `baja` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_proveedor`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`id_proveedor`, `nombre`, `baja`) VALUES
(1, 'Suc. de Alfredo Williner S.A.', 0),
(2, 'Cormoran S.A.', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `receta`
--

CREATE TABLE IF NOT EXISTS `receta` (
  `id_receta` int(11) NOT NULL AUTO_INCREMENT,
  `id_producto` int(11) NOT NULL,
  `precio_venta` float DEFAULT '0',
  `nombre` varchar(50) DEFAULT 'Mi Receta',
  `fecha` date NOT NULL,
  `baja` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_receta`,`id_producto`),
  UNIQUE KEY `id_receta` (`id_receta`),
  KEY `id_producto` (`id_producto`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=49 ;

--
-- Volcado de datos para la tabla `receta`
--

INSERT INTO `receta` (`id_receta`, `id_producto`, `precio_venta`, `nombre`, `fecha`, `baja`) VALUES
(1, 5, 0, 'Mi Receta', '2017-10-10', 1),
(2, 73, 0, NULL, '2017-10-24', 0),
(3, 74, 0, NULL, '2017-10-25', 0),
(4, 75, 0, NULL, '2017-10-25', 0),
(5, 76, 0, NULL, '2017-10-25', 1),
(6, 77, 0, 'Ataque 77', '2017-10-25', 1),
(7, 80, 0, NULL, '2017-10-25', 0),
(8, 81, 0, NULL, '2017-10-25', 0),
(9, 82, 0, NULL, '2017-10-25', 0),
(10, 83, 0, NULL, '2017-10-25', 0),
(11, 84, 0, '', '2017-10-25', 1),
(12, 85, 0, 'LA Receta', '2017-10-25', 1),
(13, 86, 0, '', '2017-10-25', 1),
(14, 87, 0, '', '2017-10-25', 1),
(15, 89, 0, '', '2017-10-25', 1),
(16, 90, 0, 'yuyu', '2017-10-25', 1),
(17, 91, 0, 'tt', '2017-10-25', 1),
(18, 92, 0, '', '2017-10-25', 1),
(19, 93, 0, 'tyty', '2017-10-25', 1),
(20, 94, 0, 'ttt', '2017-10-25', 0),
(21, 95, 0, '444', '2017-10-25', 1),
(22, 96, 0, 'hhh', '2017-10-25', 0),
(23, 98, 0, '', '2017-10-25', 1),
(24, 99, 0, 'fff', '2017-10-25', 1),
(25, 100, 0, 'Producto 100', '2017-10-25', 0),
(26, 100, 0, 'Producto100 v 2', '2017-10-25', 1),
(27, 101, 0, 'Mi receta', '2017-10-25', 0),
(28, 102, 0, 'Mi receta', '2017-10-26', 1),
(29, 103, 0, NULL, '2017-10-26', 1),
(30, 104, 0, 'Mi receta', '2017-10-26', 1),
(31, 104, 0, 'Mi receta', '2017-10-26', 0),
(32, 105, 0, NULL, '2017-10-26', 0),
(33, 107, 0, 'Mi receta', '2017-10-26', 1),
(34, 134, 0, 'Mi receta', '2017-10-27', 0),
(35, 135, 0, 'Mi receta', '2017-10-27', 0),
(36, 136, 0, 'Mi receta', '2017-10-27', 1),
(37, 137, 0, 'Mi receta', '2017-10-27', 0),
(38, 138, 0, 'Mi receta', '2017-10-27', 1),
(39, 138, 0, 'Mi receta', '2017-10-27', 0),
(40, 138, 0, 'Mi receta', '2017-10-27', 0),
(41, 139, 0, 'Mi receta', '2017-10-27', 0),
(42, 140, 0, 'Mi receta', '2017-10-27', 1),
(43, 140, 0, 'Mi receta', '2017-10-27', 0),
(44, 146, 0, 'Mi receta', '2017-10-29', 1),
(45, 147, 0, 'Mi receta', '2017-10-29', 0),
(46, 147, 0, 'Mi receta', '2017-10-29', 1),
(47, 84, 0, 'Mi receta', '2017-12-01', 0),
(48, 84, 0, 'Mi receta 2', '2017-12-01', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `unidad`
--

CREATE TABLE IF NOT EXISTS `unidad` (
  `id_unidad` int(11) NOT NULL AUTO_INCREMENT,
  `unidad` varchar(40) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`id_unidad`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `unidad`
--

INSERT INTO `unidad` (`id_unidad`, `unidad`) VALUES
(1, 'Gramos'),
(2, 'Cm3'),
(3, 'Unidad');

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `acceso`
--
ALTER TABLE `acceso`
  ADD CONSTRAINT `acceso_ibfk_1` FOREIGN KEY (`id_persona`) REFERENCES `persona` (`id_persona`);

--
-- Filtros para la tabla `comanda`
--
ALTER TABLE `comanda`
  ADD CONSTRAINT `comanda_ibfk_1` FOREIGN KEY (`id_persona`) REFERENCES `persona` (`id_persona`),
  ADD CONSTRAINT `comanda_ibfk_2` FOREIGN KEY (`estado`) REFERENCES `estadocomanda` (`id_estadoComanda`);

--
-- Filtros para la tabla `detalle_comanda`
--
ALTER TABLE `detalle_comanda`
  ADD CONSTRAINT `detalle_comanda_ibfk_1` FOREIGN KEY (`id_comanda`) REFERENCES `comanda` (`id_comanda`),
  ADD CONSTRAINT `detalle_comanda_ibfk_2` FOREIGN KEY (`id_producto`) REFERENCES `producto` (`id_producto`);

--
-- Filtros para la tabla `detalle_comprobante`
--
ALTER TABLE `detalle_comprobante`
  ADD CONSTRAINT `detalle_comprobante_ibfk_1` FOREIGN KEY (`id_producto`) REFERENCES `producto` (`id_producto`);

--
-- Filtros para la tabla `detalle_receta`
--
ALTER TABLE `detalle_receta`
  ADD CONSTRAINT `detalle_receta_ibfk_2` FOREIGN KEY (`unidad`) REFERENCES `unidad` (`id_unidad`),
  ADD CONSTRAINT `detalle_receta_ibfk_3` FOREIGN KEY (`id_producto`) REFERENCES `producto` (`id_producto`),
  ADD CONSTRAINT `detalle_receta_ibfk_4` FOREIGN KEY (`id_receta`) REFERENCES `receta` (`id_receta`);

--
-- Filtros para la tabla `persona`
--
ALTER TABLE `persona`
  ADD CONSTRAINT `persona_ibfk_1` FOREIGN KEY (`cargo`) REFERENCES `cargo` (`id_cargo`);

--
-- Filtros para la tabla `producto`
--
ALTER TABLE `producto`
  ADD CONSTRAINT `producto_ibfk_2` FOREIGN KEY (`categoria`) REFERENCES `categoria` (`id_categoria`);

--
-- Filtros para la tabla `receta`
--
ALTER TABLE `receta`
  ADD CONSTRAINT `receta_ibfk_1` FOREIGN KEY (`id_producto`) REFERENCES `producto` (`id_producto`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
