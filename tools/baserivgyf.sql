-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-02-2024 a las 17:26:41
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `baserivgyf`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `imputado`
--

CREATE TABLE `imputado` (
  `Clave_ID` int(11) NOT NULL,
  `NombreDenunciado` varchar(11) NOT NULL,
  `EdadDenunciado` int(11) NOT NULL,
  `DireccionDenunciado` varchar(11) NOT NULL,
  `DniDenunciado` varchar(11) NOT NULL,
  `TelefonoDenunciado` varchar(11) NOT NULL,
  `ProfesionDenunciado` varchar(11) NOT NULL,
  `DestinoDenunciado` varchar(11) NOT NULL,
  `JerarquiaDenunciado` varchar(11) NOT NULL,
  `LegajoDenunciado` varchar(11) NOT NULL,
  `OtroDenunciado` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `imputado`
--

INSERT INTO `imputado` (`Clave_ID`, `NombreDenunciado`, `EdadDenunciado`, `DireccionDenunciado`, `DniDenunciado`, `TelefonoDenunciado`, `ProfesionDenunciado`, `DestinoDenunciado`, `JerarquiaDenunciado`, `LegajoDenunciado`, `OtroDenunciado`) VALUES
(9, 'GGGG', 23, 'GGG', 'GGG', 'G', 'G', 'G', 'G', 'G', 'G'),
(9, 'GGGG', 23, 'GGG', 'GGG', 'G', 'G', 'G', 'G', 'G', 'G'),
(15, 'HHHH', 23, 'Hdff', 'Hgg', 'H', 'Hggg', 'H', 'H', 'H', 'H'),
(16, 'HERRERO GUI', 42, 'E P RAMOS 1', '-', '2236183660 ', 'POLICIA', 'DDI MDP', 'SUBTTE', '-dd', 'NOSE');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `login`
--

CREATE TABLE `login` (
  `usuario` text NOT NULL,
  `contraseña` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `login`
--

INSERT INTO `login` (`usuario`, `contraseña`) VALUES
('COORDMDP', '1992MDP'),
('EQUIPO', 'EQUI21');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ministerio`
--

CREATE TABLE `ministerio` (
  `Clave_Id` int(11) NOT NULL,
  `NombreVictima` varchar(11) NOT NULL,
  `EdadVictima` varchar(11) NOT NULL,
  `DireccionVictima` varchar(11) NOT NULL,
  `DniVictima` varchar(11) NOT NULL,
  `TelefonoVictima` varchar(11) NOT NULL,
  `Observaciones` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `ministerio`
--

INSERT INTO `ministerio` (`Clave_Id`, `NombreVictima`, `EdadVictima`, `DireccionVictima`, `DniVictima`, `TelefonoVictima`, `Observaciones`) VALUES
(1, 'maria', '23', 'fjfjfjfjf', '2324354', '22333', 'ndfklnfpmsñldmfs'),
(1, 'sss', 's', '54545', '125555', 's', 'sss');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paraderos`
--

CREATE TABLE `paraderos` (
  `ID` int(11) NOT NULL,
  `Clave_Id` int(11) NOT NULL,
  `NombreVictima` varchar(11) NOT NULL,
  `EdadVictima` varchar(11) NOT NULL,
  `DireccionVictima` varchar(11) NOT NULL,
  `DniVictima` varchar(11) NOT NULL,
  `TelefonoVictima` varchar(11) NOT NULL,
  `Observaciones` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `paraderos`
--

INSERT INTO `paraderos` (`ID`, `Clave_Id`, `NombreVictima`, `EdadVictima`, `DireccionVictima`, `DniVictima`, `TelefonoVictima`, `Observaciones`) VALUES
(1, 12, '', '', '', '', '', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registro`
--

CREATE TABLE `registro` (
  `Clave_Id` int(11) NOT NULL,
  `Fecha` varchar(10) NOT NULL,
  `Conocimiento` varchar(255) NOT NULL,
  `Caratula` varchar(255) NOT NULL,
  `Antecedentes` varchar(255) NOT NULL,
  `Alojamiento` varchar(255) NOT NULL,
  `Grupo` varchar(255) NOT NULL,
  `Medida` varchar(255) NOT NULL,
  `Cual` varchar(255) NOT NULL,
  `Obsme` varchar(255) NOT NULL,
  `EI` varchar(255) NOT NULL,
  `Quien` varchar(255) NOT NULL,
  `Obsei` varchar(255) NOT NULL,
  `Boton` varchar(255) NOT NULL,
  `Obsbo` varchar(255) NOT NULL,
  `DPG` varchar(255) NOT NULL,
  `Obsdpg` varchar(255) NOT NULL,
  `Minoridad` varchar(255) NOT NULL,
  `Obsmi` varchar(255) NOT NULL,
  `seguimiento` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `registro`
--

INSERT INTO `registro` (`Clave_Id`, `Fecha`, `Conocimiento`, `Caratula`, `Antecedentes`, `Alojamiento`, `Grupo`, `Medida`, `Cual`, `Obsme`, `EI`, `Quien`, `Obsei`, `Boton`, `Obsbo`, `DPG`, `Obsdpg`, `Minoridad`, `Obsmi`, `seguimiento`) VALUES
(9, '23/05/2021', 'sss', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's'),
(10, '25/06/2020', 'DSDSD', 'DDD', 'D', 'D', 'D', 'D', 'DD', 'D', 'D', 'D', 'D', 'D', 'D', 'D', 'D', 'D', 'D', 'D'),
(12, '12/06/2020', 'HHH', 'D', 'H', 'D', 'D', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H'),
(13, '16/07/2020', 'SH', 'S', 'S', 'S', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'DD'),
(14, '23/06/2020', 'DDD4', 'D', 'D', 'D', '4', '4', '4', '4', '4', '4', '4', '4', '4', '4', '4', '4', '4', '4444'),
(15, '07/06/2020', 'DDDJ', 'D', 'DJ', 'D', 'D', 'J', 'J', 'J', 'J', 'Jggg', 'J', 'J', 'J', 'J', 'J', 'J', 'J', 'Fecha 04/05/2021 Se toma conocimiento a raÃ­z de eventual al 991 que el causante Espinoza Santiago Nahuel (15) regresÃ³ por sus propios medios a su domicilio Benito Lynch 5520 presente instrucciÃ³n recepta declaraciÃ³n testimonial a la denunciante y progenitora Espinoza Claudia refiriendo que su hijo se hallaba en buenas condiciones de salud y habÃ­a pernoctado en la casa de un amigo que no aportÃ³ datos. Se entrega nota de cuerpo mÃ©dico, se solicita sin efecto orden de servicio y de paradero informÃ¡tico. Se adelanta telefÃ³nicamente a Ufi en turno. Fdo. Cria Inspectora Ibarra Mariana. â€“SSSDFF'),
(16, '03/05/2021', 'SUP POL DE GÃ‰NERO DIV COORD MAR DEL PLATA 04/05/21 REF DESOBEDIENCIA - AMENAZAS Dte AGUERO FRANCO MICHEL (28) ddo. Eduardo P. Ramos 1680 P.A, tel: 223-4469632 DDO SUBTTE. HERRERO GUILLEMRO MARTIN NOEL (42) mismo dlio. P.B, tel: 2236183660 (pareja), (desc', 'DESOBEDIENCIA - AMENAZAS', '30/04/2021 Inf Ley 12.569 Int. Juzdo Flia nro 2 Dra Lazcano Maria, dte AgÃ¼ero Franco Dda AgÃ¼ero Claudia.', '-', '-', 'NO', 'NO', 'RA EN VIGENCIA', 'SI', 'DR KNUDSEN FERNANDO', '-', '-', '-', '-', '-', '-', '-', 'Dte refiere que en el dia de ayer en horas de la noche regresando a su dlio. nota que no tenÃ­a suministro elÃ©ctrico ni agua, al observar detalladamente constata que habÃ­an cortado los cables de electricidad. Que en ese momento sale de la vivienda su cuÃ±ado HERRERO GUILLEMRO MARTIN NOEL, quien mientras se retiraba manifiesta amenazas de muerte dando a entender que eran para su persona. Deja constancia que residen en misma edificaciÃ³n con diferente acceso. Posee RestricciÃ³n de Acercamiento en vigencia. Not. ley. Vict. SituaciÃ³n AGAI dispone adelanto del parte escrito vÃ­a mail.\n\n03/05: KNUDESE LLAMO\nDD\n5656FFFDD\nHJHJ');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sucesos`
--

CREATE TABLE `sucesos` (
  `ID` int(11) NOT NULL,
  `Clave_Id` int(11) DEFAULT NULL,
  `NombreVictima` varchar(11) NOT NULL,
  `EdadVictima` varchar(11) NOT NULL,
  `DireccionVictima` varchar(11) NOT NULL,
  `DniVictima` varchar(11) NOT NULL,
  `TelefonoVictima` varchar(11) NOT NULL,
  `Observaciones` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `sucesos`
--

INSERT INTO `sucesos` (`ID`, `Clave_Id`, `NombreVictima`, `EdadVictima`, `DireccionVictima`, `DniVictima`, `TelefonoVictima`, `Observaciones`) VALUES
(1, 2, '', '', '', '', '', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tobillera`
--

CREATE TABLE `tobillera` (
  `Clave_Id` int(11) NOT NULL,
  `Instalada` varchar(11) NOT NULL,
  `NombreVictima` varchar(11) NOT NULL,
  `EdadVictima` varchar(11) NOT NULL,
  `DireccionVictima` varchar(11) NOT NULL,
  `DniVictima` varchar(11) NOT NULL,
  `TelefonoVictima` varchar(11) NOT NULL,
  `NombreDenunciado` varchar(11) NOT NULL,
  `EdadDenunciando` varchar(11) NOT NULL,
  `DireccionDenunciado` varchar(11) NOT NULL,
  `DniDenunciado` varchar(11) NOT NULL,
  `TelefonoDenunciado` varchar(11) NOT NULL,
  `Observaciones` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `tobillera`
--

INSERT INTO `tobillera` (`Clave_Id`, `Instalada`, `NombreVictima`, `EdadVictima`, `DireccionVictima`, `DniVictima`, `TelefonoVictima`, `NombreDenunciado`, `EdadDenunciando`, `DireccionDenunciado`, `DniDenunciado`, `TelefonoDenunciado`, `Observaciones`) VALUES
(1, 'si', 'maria', '23', 'falucho', '23232323', '2235997974', 'pablo', '26', 'garay', '12121212', '334989897', 'Dte refiere que momentos en que la dicente se encontraba recostada, dado que sufre de lumbalgia, comenzó a discutir con VICTOR verbalmente, tornándose su pareja agresiva, tomándola del cabello y sacándola a la rastra de la cama para luego propinarle dos patadas en las piernas. Seguidamente la empuja hasta la puerta de entrada de la vivienda. Es su deseo hacer constar que Victor Hugo tiene problemas de adicción con el alcohol y estupefacientes; refiere que este sujeto posee en su vivienda un arma de fuego . No existen precedentes. Esta división continuará con el seguimiento por parte de la Ofl Inspectora (cdo) Nuñez Virginia. Fdo. Cria. Inspectora Ibarra Mariana.. –');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `victima`
--

CREATE TABLE `victima` (
  `Clave_ID` int(11) NOT NULL,
  `NombreVictima` text NOT NULL,
  `EdadVictima` int(11) NOT NULL,
  `DireccionVictima` varchar(11) NOT NULL,
  `DniVictima` varchar(11) NOT NULL,
  `TelefonoVictima` varchar(11) NOT NULL,
  `ProfesionVictima` varchar(11) NOT NULL,
  `DestinoVictima` varchar(11) NOT NULL,
  `JerarquiaVictima` varchar(11) NOT NULL,
  `LegajoVictima` varchar(11) NOT NULL,
  `OtroVictima` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `victima`
--

INSERT INTO `victima` (`Clave_ID`, `NombreVictima`, `EdadVictima`, `DireccionVictima`, `DniVictima`, `TelefonoVictima`, `ProfesionVictima`, `DestinoVictima`, `JerarquiaVictima`, `LegajoVictima`, `OtroVictima`) VALUES
(15, '0', 23, '0', '0', '0', '0', '0', 'ggggggg', '0', '0'),
(16, 'AGUERO FRANCO MICHEL', 28, 'ED P RAMOS ', '-', '223-4469632', '-', '-', 'ddd', '-', 'NOSE');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `imputado`
--
ALTER TABLE `imputado`
  ADD KEY `Clave_ID` (`Clave_ID`);

--
-- Indices de la tabla `registro`
--
ALTER TABLE `registro`
  ADD PRIMARY KEY (`Clave_Id`);

--
-- Indices de la tabla `victima`
--
ALTER TABLE `victima`
  ADD KEY `Clave_ID` (`Clave_ID`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `registro`
--
ALTER TABLE `registro`
  MODIFY `Clave_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
