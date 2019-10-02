SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;


CREATE TABLE `foglalas` (
  `id` int(11) UNSIGNED NOT NULL,
  `felnottek_szama` int(11) NOT NULL,
  `gyerekek_szama` int(11) DEFAULT NULL,
  `fizetett` int(11) UNSIGNED DEFAULT NULL,
  `lemondott` tinyint(4) DEFAULT NULL,
  `erkezes_ido` date NOT NULL,
  `tavozas_ido` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

INSERT INTO `foglalas` (`id`, `felnottek_szama`, `gyerekek_szama`, `fizetett`, `lemondott`, `erkezes_ido`, `tavozas_ido`) VALUES
(9, 1, 1, 37500, 0, '2019-07-10', '2019-07-13'),
(11, 2, 0, 50000, 0, '2019-02-13', '2019-02-17'),
(13, 2, 0, 62500, 1, '2018-11-02', '2018-11-08'),
(15, 1, 0, 25000, 1, '2019-01-21', '2019-01-23'),
(16, 2, 1, 12500, 0, '2019-01-11', '2019-01-12'),
(17, 1, 0, 62500, 0, '2019-04-09', '2019-04-14'),
(18, 1, 0, 37500, 0, '2019-04-06', '2019-04-09'),
(19, 1, 0, 50000, 0, '2019-04-02', '2019-04-06'),
(20, 2, 0, 37500, 0, '2019-03-31', '2019-04-02'),
(21, 1, 1, 25000, 0, '2019-03-29', '2019-03-31'),
(22, 1, 0, 12500, 0, '2019-03-28', '2019-03-29'),
(23, 2, 1, 50000, 0, '2019-03-24', '2019-03-28'),
(24, 1, 0, 25000, 1, '2019-03-22', '2019-03-24'),
(25, 1, 0, 37500, 0, '2019-03-19', '2019-03-22'),
(27, 1, 0, 12500, 1, '2019-02-26', '2019-02-27'),
(28, 1, 1, 75000, 0, '2019-02-18', '2019-02-25'),
(29, 2, 0, 12500, 0, '2019-02-14', '2019-02-16');

CREATE TABLE `jelszo` (
  `id` tinyint(3) NOT NULL,
  `jelszo` varchar(50) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

INSERT INTO `jelszo` (`id`, `jelszo`) VALUES
(2, '93279e3308bdbbeed946fc965017f67a');

CREATE TABLE `koltseg` (
  `id` int(11) NOT NULL,
  `rezsi` int(11) DEFAULT NULL,
  `tisztitoszerek` int(11) DEFAULT NULL,
  `uzemanyag` int(11) UNSIGNED DEFAULT NULL,
  `felujitas` int(11) DEFAULT NULL,
  `egyeb` int(11) DEFAULT NULL,
  `koltekezes_datuma` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

INSERT INTO `koltseg` (`id`, `rezsi`, `tisztitoszerek`, `uzemanyag`, `felujitas`, `egyeb`) VALUES
(1, 4000, 0, 0, 0, 0),
(2, NULL, NULL, 1000, NULL, NULL),
(3, NULL, NULL, NULL, 10000, NULL),
(10, 5000, 0, 0, 0, 0),
(11, 0, 0, 0, 12000, 0),
(12, NULL, 2000, NULL, NULL, NULL),
(13, NULL, NULL, NULL, NULL, 3000),
(14, 4500, NULL, NULL, NULL, NULL),
(15, NULL, 3000, NULL, NULL, NULL);

CREATE TABLE `szallas` (
  `id` int(11) UNSIGNED NOT NULL,
  `v_id` int(11) UNSIGNED DEFAULT NULL,
  `f_id` int(11) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

INSERT INTO `szallas` (`id`, `v_id`, `f_id`) VALUES
(1, 11, 11),
(2, 5, 11),
(3, 18, 9),
(5, 15, 13),
(6, 9, 13),
(7, 16, 15),
(13, 20, 16),
(20, 31, 16),
(21, 35, 16),
(23, 37, 17),
(24, 38, 18),
(25, 39, 19),
(26, 40, 20),
(27, 41, 20),
(28, 42, 21),
(29, 45, 21),
(30, 46, 22),
(31, 47, 23),
(32, 48, 23),
(33, 50, 24),
(34, 51, 25),
(36, 52, 27),
(37, 53, 28),
(38, 54, 28),
(39, 9, 29),
(40, 15, 29);

CREATE TABLE `vendeg` (
  `id` int(11) UNSIGNED NOT NULL,
  `vezeteknev` varchar(255) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL,
  `keresztnev` varchar(255) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL,
  `telefonszam` varchar(255) CHARACTER SET latin2 COLLATE latin2_hungarian_ci DEFAULT NULL,
  `lakcim` varchar(255) CHARACTER SET latin2 COLLATE latin2_hungarian_ci DEFAULT NULL,
  `megye` varchar(50) CHARACTER SET latin2 COLLATE latin2_hungarian_ci DEFAULT NULL,
  `szuletesi_datum` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

INSERT INTO `vendeg` (`id`, `vezeteknev`, `keresztnev`, `telefonszam`, `lakcim`, `megye`, `szuletesi_datum`) VALUES
(5, 'Kiss', 'Kamilla', '06301234567', 'Rum', 'Vas', '1988-02-11'),
(9, 'Takács', 'Veronika', '', 'Drávapalkonya', 'Vas', '2000-03-23'),
(11, 'Nagy', 'Zoltán', '06302223333', 'Kemenespálfa', 'Vas', '1988-01-22'),
(15, 'Antal', 'Lajos', '06204445555', 'Drávapalkonya', 'Baranya', '1989-02-16'),
(16, 'Vámos', 'Gusztáv', '06201234567', 'Sárvár', 'Vas', '1992-03-21'),
(18, 'Lakatos', 'Árpád', '06701234566', 'Jobbágyi', 'Nógrád', '1993-04-14'),
(20, 'Kovács', 'Béla', '06703962735', 'Kőszeg', 'Vas', '1994-02-14'),
(31, 'Majoros ', 'Gyula', '', 'Kőszeg', 'Vas', '2001-11-23'),
(35, 'Berki', 'Orsolya', '06203542345', 'Budapest', 'Pest', '1983-01-30'),
(36, 'Gere', 'Tibor', '06703895723', 'Old', 'Baranya', '1977-10-23'),
(37, 'Hegyi', 'Krisztina', '06703852648', 'Duka', 'Vas', '1998-09-28'),
(38, 'Gergely', 'Benedek', '', 'Budapest', 'Pest', '1983-06-22'),
(39, 'Ságy', 'István', '06303761397', 'Tiszainoka', 'Jász-Nagykun-Szolnok', '1993-07-02'),
(40, 'Kővári', 'Mariann', '06203727581', 'Vásárosmiske', 'Vas', '1994-07-15'),
(41, 'Baranyai ', 'Ákos', '', 'Szilvás', 'Baranya', '1999-03-21'),
(42, 'Kecskés', 'Dániel', '06302759264', 'Kistapolca', 'Baranya', '1979-01-27'),
(45, 'Angyal', 'Janka', '06302452459', 'Bük', 'Vas', '1995-05-11'),
(46, 'Csizmazia', 'Máté', '06301232344', 'Rétság', 'Nógrád', '1991-08-27'),
(47, 'Pető', 'Ozor', '', 'Kiskorpád', 'Somogy', '1983-08-26'),
(48, 'Lackó', 'Vanessza', '06209333774', 'Kiskorpád', 'Somogy', '1998-03-16'),
(49, 'Rátz', 'Nándor', '06302344537', 'Kozármisleny', 'Baranya', '1975-12-21'),
(50, 'Benczik', 'Alexandra', '06302225363', 'Szombathely', 'Vas', '1982-05-08'),
(51, 'Vargha', 'Csilla', '', 'Ják', 'Vas', '1999-05-07'),
(52, 'Dénes', 'Angyalka', '06203467534', 'Tiszajenő', 'Jász-Nagykun-Szolnok', '1999-08-03'),
(53, 'Szőlősi', 'Ica', '', 'Kartal', 'Pest', '1988-08-08'),
(54, 'Bodo', 'Kund', '06301223583', 'Kartal', 'Pest', '1999-09-10');


ALTER TABLE `foglalas`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `jelszo`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `koltseg`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `szallas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK1_szallas_vendeg` (`v_id`),
  ADD KEY `FK2_szallas_foglalas` (`f_id`);

ALTER TABLE `vendeg`
  ADD PRIMARY KEY (`id`);


ALTER TABLE `foglalas`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

ALTER TABLE `jelszo`
  MODIFY `id` tinyint(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

ALTER TABLE `koltseg`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

ALTER TABLE `szallas`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

ALTER TABLE `vendeg`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;


ALTER TABLE `szallas`
  ADD CONSTRAINT `FK1_szallas_vendeg` FOREIGN KEY (`v_id`) REFERENCES `vendeg` (`id`),
  ADD CONSTRAINT `FK2_szallas_foglalas` FOREIGN KEY (`f_id`) REFERENCES `foglalas` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
