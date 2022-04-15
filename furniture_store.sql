-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Дек 10 2021 г., 11:16
-- Версия сервера: 8.0.19
-- Версия PHP: 8.0.1

CREATE DATABASE furniture_store;

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `furniture_store`
--
USE furniture_store;
-- --------------------------------------------------------

--
-- Структура таблицы `client`
--

CREATE TABLE `client` (
  `id` int NOT NULL,
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT 'имя клиента ',
  `adress` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT 'адрес клиента',
  `telephone` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT 'контактный телефон'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `client`
--

INSERT INTO `client` (`id`, `name`, `adress`, `telephone`) VALUES
(1, 'Родовский Марк Игоревич', 'г. Москва, ул. Гаггарина, д. 67, кв. 98', '8-999-612-09-86'),
(2, 'Ляхов Григорий Алексеевич', 'г. Москва, Ленинский проспект, д. 98, кв. 54', '8-951-299-00-11'),
(3, 'ООО \"МОЯ ОБОРОНА\"', 'г. Омск, ул. Ленина, д. 130/Д', '8-800-124-00-11'),
(4, 'ООО \"СПС\"', 'г. Брянс, ул. Германа Титова, д 43/1', '8-800-754-09-43'),
(5, 'Пейн Макс Алекс', 'Нью-Джерси, Палисад стрит, д. 99', '1-800-009-MAXPAYNE'),
(14, 'Плаудис Роберт Улансович', 'г. Санкт-Петербург, ул. Фуршатская д. 192', '8-923-000-21-65');

-- --------------------------------------------------------

--
-- Структура таблицы `furnture_model`
--

CREATE TABLE `furnture_model` (
  `id` int NOT NULL,
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT 'именование мебели',
  `model` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT 'модель мебели',
  `item` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT 'краткое описание модели мебели',
  `price` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT 'цена'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `furnture_model`
--

INSERT INTO `furnture_model` (`id`, `name`, `model`, `item`, `price`) VALUES
(1, 'Анаконда', 'ПМ-21-09', 'Письменный стол', '4000 руб'),
(2, 'Сакура', '266-98-ДД', 'Шкаф-купе', '15500 руб'),
(3, 'Барракуда', 'ДНМП-18-00', 'Журнальный стол', '7000 руб.'),
(9, 'Либерти', 'ЛБ-21-00', 'Кровать одноместная', '25000');

-- --------------------------------------------------------

--
-- Структура таблицы `sell_contract`
--

CREATE TABLE `sell_contract` (
  `num_contract` int NOT NULL COMMENT 'номер договора',
  `id_client` int NOT NULL COMMENT 'номер клиента',
  `id_furniture` int NOT NULL COMMENT 'ин мебели',
  `name_furniture` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT 'название мебели',
  `model_furniture` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT 'модель мебели',
  `count` int NOT NULL COMMENT 'кол-во мебели',
  `registration_date` text NOT NULL COMMENT 'дата оформления договора',
  `achievement_date` text NOT NULL COMMENT 'дата исполнения договора',
  `sum` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `sell_contract`
--

INSERT INTO `sell_contract` (`num_contract`, `id_client`, `id_furniture`, `name_furniture`, `model_furniture`, `count`, `registration_date`, `achievement_date`, `sum`) VALUES
(1, 1, 1, 'Анаконда', 'ПМ-21-09', 5, '2021-11-09', '2021-11-18', '320000'),
(2, 1, 1, 'Анаконда', 'ПМ-21-09', 4, '3 декабря 2021 г.', '9 декабря 2021 г.', '16000'),
(3, 4, 3, 'Барракуда', 'ДНМП-18-00', 15, '12 февраля 2021 г.', '18 февраля 2021 г.', '105 000');

-- --------------------------------------------------------

--
-- Структура таблицы `user`
--

CREATE TABLE `user` (
  `id` int NOT NULL,
  `name` varchar(255) NOT NULL,
  `surname` varchar(255) NOT NULL,
  `thirdname` varchar(255) NOT NULL,
  `login` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `user`
--

INSERT INTO `user` (`id`, `name`, `surname`, `thirdname`, `login`, `password`) VALUES
(1, 'Григорий', 'Юрьевич', 'Гаврилин', 'grag', '1337'),
(2, 'Павел', 'Елисеев', 'Алексеевич', 'vvazaur', 'plaxeverodunum');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `furnture_model`
--
ALTER TABLE `furnture_model`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `sell_contract`
--
ALTER TABLE `sell_contract`
  ADD PRIMARY KEY (`num_contract`),
  ADD KEY `id_client` (`id_client`) USING BTREE,
  ADD KEY `id_furniture` (`id_furniture`) USING BTREE;

--
-- Индексы таблицы `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `client`
--
ALTER TABLE `client`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT для таблицы `furnture_model`
--
ALTER TABLE `furnture_model`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT для таблицы `sell_contract`
--
ALTER TABLE `sell_contract`
  MODIFY `num_contract` int NOT NULL AUTO_INCREMENT COMMENT 'номер договора', AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `user`
--
ALTER TABLE `user`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `sell_contract`
--
ALTER TABLE `sell_contract`
  ADD CONSTRAINT `sell_contract_ibfk_2` FOREIGN KEY (`id_furniture`) REFERENCES `furnture_model` (`id`),
  ADD CONSTRAINT `sell_contract_ibfk_5` FOREIGN KEY (`id_client`) REFERENCES `client` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
