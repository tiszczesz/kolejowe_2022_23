-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 27 Mar 2023, 14:56
-- Wersja serwera: 10.4.22-MariaDB
-- Wersja PHP: 7.4.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `3pr_cw2_wycieczki`
--
CREATE DATABASE IF NOT EXISTS `3pr_cw2_wycieczki` DEFAULT CHARACTER SET utf8 COLLATE utf8_polish_ci;
USE `3pr_cw2_wycieczki`;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `trips`
--

DROP TABLE IF EXISTS `trips`;
CREATE TABLE `trips` (
  `id` int(11) NOT NULL,
  `place` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `trips`
--

INSERT INTO `trips` (`id`, `place`, `price`, `date`) VALUES
(1, 'Warszawa', '300.00', '2023-04-24'),
(2, 'Zakopane', '250.00', '2023-05-12'),
(3, 'Londyn', '2500.00', '2023-05-24'),
(4, 'Gdańsk', '350.00', '2023-04-28');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `trips`
--
ALTER TABLE `trips`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `trips`
--
ALTER TABLE `trips`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
