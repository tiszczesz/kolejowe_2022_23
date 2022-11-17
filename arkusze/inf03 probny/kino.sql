-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 09 Sie 2022, 11:29
-- Wersja serwera: 10.4.6-MariaDB
-- Wersja PHP: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `kino`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `kasjerzy`
--

CREATE TABLE `kasjerzy` (
  `Id` int(11) NOT NULL,
  `Nazwisko` varchar(30) COLLATE utf8_polish_ci NOT NULL,
  `Imie` varchar(30) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `kasjerzy`
--

INSERT INTO `kasjerzy` (`Id`, `Nazwisko`, `Imie`) VALUES
(1, 'Bednarski', 'Jan'),
(2, 'Zawiła', 'Katarzyna'),
(3, 'Gąska', 'Jakub'),
(4, 'Śnieżek', 'Radosław'),
(5, 'Smycz', 'Mariola');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rezerwacje`
--

CREATE TABLE `rezerwacje` (
  `ID` int(11) NOT NULL,
  `Data` date NOT NULL,
  `Godzina` time NOT NULL,
  `Miejsce` int(11) NOT NULL,
  `Rzad` int(11) NOT NULL,
  `Id_kasjera` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `rezerwacje`
--

INSERT INTO `rezerwacje` (`ID`, `Data`, `Godzina`, `Miejsce`, `Rzad`, `Id_kasjera`) VALUES
(1, '2022-08-08', '15:00:00', 5, 4, 1),
(2, '2022-08-08', '15:00:00', 10, 8, 1),
(3, '2022-08-08', '15:00:00', 10, 7, 1),
(4, '2022-08-08', '15:00:00', 10, 9, 1),
(5, '2022-08-08', '15:00:00', 12, 3, 1),
(6, '2022-08-08', '15:00:00', 15, 1, 1),
(7, '2022-08-08', '15:00:00', 15, 2, 1),
(8, '2022-08-08', '15:00:00', 15, 3, 1),
(9, '2022-08-08', '15:00:00', 15, 4, 1),
(10, '2022-08-08', '15:00:00', 15, 5, 1),
(11, '2022-08-08', '15:00:00', 19, 6, 1),
(12, '2022-08-08', '15:00:00', 19, 7, 1),
(13, '2022-08-08', '15:00:00', 19, 8, 1),
(14, '2022-08-08', '15:00:00', 19, 9, 1),
(15, '2022-08-08', '15:00:00', 19, 10, 1),
(16, '2022-08-08', '15:00:00', 19, 11, 1),
(17, '2022-08-08', '15:00:00', 19, 12, 1),
(18, '2022-08-08', '15:00:00', 19, 13, 1),
(19, '2022-08-08', '15:00:00', 19, 14, 1),
(20, '2022-08-08', '15:00:00', 19, 15, 1),
(21, '2022-08-08', '15:00:00', 20, 8, 1),
(22, '2022-08-08', '15:00:00', 20, 9, 1),
(23, '2022-08-08', '15:00:00', 20, 10, 1),
(24, '2022-08-08', '15:00:00', 20, 11, 1),
(25, '2022-08-08', '19:00:00', 2, 12, 2),
(26, '2022-08-08', '19:00:00', 2, 13, 3),
(27, '2022-08-08', '19:00:00', 5, 6, 1),
(28, '2022-08-08', '19:00:00', 10, 11, 2),
(29, '2022-08-08', '19:00:00', 13, 10, 1),
(30, '2022-08-08', '19:00:00', 3, 12, 2),
(31, '2022-08-08', '19:00:00', 6, 14, 3),
(32, '2022-08-08', '19:00:00', 7, 14, 1),
(33, '2022-08-08', '19:00:00', 12, 10, 2),
(34, '2022-08-08', '19:00:00', 17, 9, 1),
(35, '2022-08-09', '18:00:00', 9, 1, 4),
(36, '2022-08-09', '18:00:00', 9, 2, 4),
(37, '2022-08-09', '18:00:00', 9, 3, 4),
(38, '2022-08-09', '18:00:00', 9, 4, 4),
(39, '2022-08-09', '18:00:00', 9, 5, 4),
(40, '2022-08-09', '18:00:00', 9, 6, 4),
(41, '2022-08-08', '15:00:00', 6, 1, 4),
(42, '2022-08-09', '18:00:00', 9, 8, 4),
(43, '2022-08-09', '18:00:00', 9, 9, 4),
(44, '2022-08-09', '18:00:00', 9, 10, 4),
(45, '2022-08-09', '18:00:00', 9, 11, 4),
(46, '2022-08-09', '18:00:00', 9, 12, 4),
(47, '2022-08-09', '18:00:00', 9, 13, 4),
(48, '2022-08-09', '18:00:00', 9, 14, 4),
(49, '2022-08-09', '18:00:00', 9, 15, 4),
(50, '2022-08-09', '18:00:00', 20, 7, 3),
(51, '2022-08-09', '20:00:00', 5, 8, 2),
(52, '2022-08-09', '18:00:00', 19, 7, 3),
(53, '2022-08-09', '18:00:00', 18, 7, 3),
(54, '2022-08-09', '18:00:00', 17, 7, 3),
(55, '2022-08-09', '20:00:00', 5, 9, 2),
(56, '2022-08-09', '20:00:00', 5, 10, 2),
(57, '2022-08-09', '18:00:00', 16, 7, 3),
(58, '2022-08-09', '18:00:00', 15, 7, 3),
(59, '2022-08-09', '20:00:00', 9, 10, 5),
(60, '2022-08-09', '20:00:00', 9, 11, 5),
(61, '2022-08-09', '18:00:00', 14, 7, 3),
(62, '2022-08-09', '18:00:00', 13, 7, 3),
(63, '2022-08-09', '20:00:00', 20, 8, 5),
(64, '2022-08-09', '18:00:00', 12, 7, 3),
(65, '2022-08-09', '18:00:00', 11, 7, 3),
(66, '2022-08-09', '18:00:00', 10, 7, 3),
(67, '2022-08-09', '18:00:00', 9, 7, 3),
(68, '2022-08-09', '18:00:00', 8, 7, 3),
(69, '2022-08-09', '18:00:00', 7, 7, 3),
(70, '2022-08-09', '18:00:00', 6, 7, 3),
(71, '2022-08-09', '18:00:00', 5, 7, 3),
(72, '2022-08-09', '20:00:00', 20, 12, 5),
(73, '2022-08-09', '20:00:00', 9, 13, 5),
(74, '2022-08-09', '18:00:00', 4, 7, 3),
(75, '2022-08-09', '18:00:00', 3, 7, 3),
(76, '2022-08-09', '18:00:00', 2, 7, 3),
(77, '2022-08-09', '18:00:00', 1, 7, 3),
(78, '2022-08-08', '15:00:00', 8, 8, 5),
(79, '2022-08-08', '15:00:00', 9, 8, 5),
(80, '2022-08-08', '15:00:00', 7, 8, 5);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `kasjerzy`
--
ALTER TABLE `kasjerzy`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Id` (`Id`);

--
-- Indeksy dla tabeli `rezerwacje`
--
ALTER TABLE `rezerwacje`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Id_kasjera` (`Id_kasjera`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `kasjerzy`
--
ALTER TABLE `kasjerzy`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT dla tabeli `rezerwacje`
--
ALTER TABLE `rezerwacje`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=81;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `rezerwacje`
--
ALTER TABLE `rezerwacje`
  ADD CONSTRAINT `rezerwacje_ibfk_1` FOREIGN KEY (`Id_kasjera`) REFERENCES `kasjerzy` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
