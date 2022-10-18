-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 18 Paź 2022, 08:46
-- Wersja serwera: 10.4.19-MariaDB
-- Wersja PHP: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `moja1`
--
CREATE DATABASE IF NOT EXISTS `moja1` DEFAULT CHARACTER SET utf8 COLLATE utf8_polish_ci;
USE `moja1`;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `books`
--

CREATE TABLE `books` (
  `id` int(11) NOT NULL,
  `title` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `pages` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `books`
--

INSERT INTO `books` (`id`, `title`, `price`, `pages`) VALUES
(1, 'abc sql', '34.90', 500),
(2, 'inna 2', '123.00', 12),
(3, 'robakil', '78.90', 220),
(4, 'inna 3', '123.00', 12);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `inna`
--

CREATE TABLE `inna` (
  `id` int(11) DEFAULT NULL,
  `name` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `value` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `inna`
--

INSERT INTO `inna` (`id`, `name`, `value`) VALUES
(NULL, 'fff', 34),
(NULL, 'gg', 45),
(NULL, 'tt', 167),
(NULL, 'uu', 89);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `books`
--
ALTER TABLE `books`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
