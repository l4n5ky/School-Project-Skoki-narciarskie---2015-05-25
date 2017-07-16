DROP DATABASE IF EXISTS skokinarciarskie;
create database skokinarciarskie;
use skokinarciarskie;


CREATE Table Reprezentacje
(
ID_Reprezentacji INTEGER PRIMARY KEY NOT NULL AUTO_INCREMENT,
Nazwa VARCHAR(30) NOT NULL,
Adres_Flagi VARCHAR(30) NOT NULL 
);


CREATE Table Trenerzy
(
ID_Trenera INTEGER PRIMARY KEY NOT NULL AUTO_INCREMENT,
Imie VARCHAR(20) NOT NULL,
Nazwisko VARCHAR(30) NOT NULL,
ID_Reprezentacji INTEGER NOT NULL,
FOREIGN KEY FK_Trenerzy_Reprezentacje(ID_Reprezentacji) REFERENCES Reprezentacje(ID_Reprezentacji)
);


CREATE Table Skoczkowie
(
ID_Skoczka INTEGER PRIMARY KEY NOT NULL AUTO_INCREMENT,
Imie VARCHAR(20) NOT NULL,
Nazwisko VARCHAR(30) NOT NULL,
Data_urodzenia DATE NOT NULL,
Punkty INTEGER NULL,
Adres_zdjecia VARCHAR(30) NOT NULL,
ID_Trenera INTEGER NOT NULL,
ID_Reprezentacji INTEGER NOT NULL,
FOREIGN KEY FK_Skoczkowie_Trenerzy(ID_Trenera) REFERENCES Trenerzy(ID_Trenera),
FOREIGN KEY FK_Skoczkowie_Reprezentacje(ID_Reprezentacji) REFERENCES Reprezentacje(ID_Reprezentacji)
);


CREATE Table Skocznie
(
ID_Skoczni INTEGER PRIMARY KEY NOT NULL AUTO_INCREMENT,
Nazwa VARCHAR(40) NOT NULL,
Miejscowosc VARCHAR(30) NOT NULL,
Kraj VARCHAR(30) NOT NULL,
PunktK INTEGER NOT NULL,
Rekord INTEGER NULL,
Czyj_rekord VARCHAR(30) NULL,
Adres_zdjecia VARCHAR(30) NOT NULL
);

CREATE Table Zawody
(
ID_Zawodow INTEGER PRIMARY KEY NOT NULL AUTO_INCREMENT,
Data_zawodow DATE NOT NULL,
ID_Skoczni INTEGER NOT NULL,
FOREIGN KEY FK_Zawody_Skocznie(ID_Skoczni) REFERENCES Skocznie(ID_Skoczni)
);

CREATE Table Skoki
(
ID_Skoku INTEGER PRIMARY KEY NOT NULL AUTO_INCREMENT,
Odleglosc DOUBLE NOT NULL,
Punkty INTEGER NOT NULL,
ID_Skoczka INTEGER NOT NULL,
ID_Zawodow INTEGER NOT NULL,
FOREIGN KEY FK_Skoki_Skoczek(ID_Skoczka) REFERENCES Skoczkowie(ID_Skoczka),
FOREIGN KEY FK_Skoki_Zawody(ID_Zawodow) REFERENCES Zawody(ID_Zawodow)
);

-- DODAWANIE SKOCZNI - 10 SKOCZNI
INSERT INTO Skocznie VALUES(null, 'Wielka Krokiew', 'Zakopane', 'Polska', 120, 140, 'Simon AMMANN', 'skocznia1.jpg');
INSERT INTO Skocznie VALUES(null, 'im. Adama Małysza', 'Wisła', 'Polska', 120, 139, 'Stefan KRAFT', 'skocznia2.jpg');
INSERT INTO Skocznie VALUES(null, 'Skalite', 'Szczyrk', 'Polska', 95, 116, 'Krzysztof LEJA', 'skocznia3.jpg');
INSERT INTO Skocznie VALUES(null, 'Orlinek', 'Karpacz', 'Polska', 85, 94, 'Adam MAŁYSZ', 'skocznia4.jpg');
INSERT INTO Skocznie VALUES(null, 'Kulm-Skiflugschanze', 'Bad Mitterndorf', 'Austria', 185, null, null, 'skocznia5.jpg');
INSERT INTO Skocznie VALUES(null, 'Bergisel', 'Innsbruck', 'Austria', 120, 136, 'Adam MAŁYSZ', 'skocznia6.jpg');
INSERT INTO Skocznie VALUES(null, 'im. P. Ausserleitnera', 'Bischofshofen', 'Austria', 125, 143, 'Daiki ITO', 'skocznia7.jpg');
INSERT INTO Skocznie VALUES(null, 'Certak', 'Harrachov', 'Czechy', 185, 197, 'Jakub JANDA', 'skocznia8.jpg');
INSERT INTO Skocznie VALUES(null, 'Areal Horecky', 'Frenstat', 'Czechy', 95, null, null, 'skocznia9.jpg');
INSERT INTO Skocznie VALUES(null, 'Jested', 'Liberec', 'Czechy', 120, null, null, 'skocznia10.jpg');

-- DODAWANIE REPREZENTACJI - 5 REPREZENTACJI
INSERT INTO Reprezentacje VALUES(null, 'Polska', 'flag_Polska.jpg');
INSERT INTO Reprezentacje VALUES(null, 'Austria', 'flag_Austria.jpg');
INSERT INTO Reprezentacje VALUES(null, 'Czechy', 'flag_Czechy.jpg');
INSERT INTO Reprezentacje VALUES(null, 'Niemcy', 'flag_Niemcy.jpg');
INSERT INTO Reprezentacje VALUES(null, 'Rosja', 'flag_Rosja.jpg');

-- DODAWANIE TRENERÓW - 5 TRENERÓW
INSERT INTO Trenerzy VALUES(null, 'Łukasz', 'Kruczek', 1);
INSERT INTO Trenerzy VALUES(null, 'Thomas', 'Diethart', 2);
INSERT INTO Trenerzy VALUES(null, 'David', 'Jiroutek', 3);
INSERT INTO Trenerzy VALUES(null, 'Werner', 'Schuster', 4);
INSERT INTO Trenerzy VALUES(null, 'Aleksandr', 'Ariefjew', 5);

-- DODAWANIE SKOCZKÓW - 20 SKOCZKÓW
INSERT INTO Skoczkowie VALUES(null, 'Kamil', 'Stoch', '1987-05-25', null, 'skoczek1.jpg', 1, 1);
INSERT INTO Skoczkowie VALUES(null, 'Piotr', 'Żyła', '1987-01-16', null, 'skoczek2.jpg', 1, 1);
INSERT INTO Skoczkowie VALUES(null, 'Dawid', 'Kubacki', '1990-03-12', null, 'skoczek3.jpg', 1, 1);
INSERT INTO Skoczkowie VALUES(null, 'Jan', 'Ziobro', '1991-06-24', null, 'skoczek4.jpg', 1, 1);
INSERT INTO Skoczkowie VALUES(null, 'Marinus', 'Kraus','1991-02-13', null, 'skoczek5.jpg', 4, 4);
INSERT INTO Skoczkowie VALUES(null, 'Severin', 'Freund', '1988-05-11', null, 'skoczek6.jpg', 4, 4);
INSERT INTO Skoczkowie VALUES(null, 'Richard', 'Freitag', '1991-08-14', null, 'skoczek7.jpg', 4, 4);
INSERT INTO Skoczkowie VALUES(null, 'Michael', 'Neumayer', '1979-01-15', null, 'skoczek8.jpg', 4, 4);
INSERT INTO Skoczkowie VALUES(null, 'Denis', 'Kornilow', '1986-08-17', null, 'skoczek9.jpg', 5, 5);
INSERT INTO Skoczkowie VALUES(null, 'Dmitrij', 'Ipatow', '1984-06-30', null, 'skoczek10.jpg', 5, 5);
INSERT INTO Skoczkowie VALUES(null, 'Dmitrij', 'Wasiljew', '1979-12-26', null, 'skoczek11.jpg', 5, 5);
INSERT INTO Skoczkowie VALUES(null, 'Aleksander', 'Sardyko', '1990-05-08', null, 'skoczek12.jpg', 5, 5);
INSERT INTO Skoczkowie VALUES(null, 'Thomas', 'Diethart', '1992-02-25', null, 'skoczek13.jpg', 2, 2);
INSERT INTO Skoczkowie VALUES(null, 'Manueal', 'Fettner', '1985-06-17', null, 'skoczek14.jpg', 2, 2);
INSERT INTO Skoczkowie VALUES(null, 'Michael', 'Hayboeack', '1991-03-05', null, 'skoczek15.jpg', 2, 2);
INSERT INTO Skoczkowie VALUES(null, 'Stefan', 'Kraft', '1993-05-13', null, 'skoczek16.jpg', 2, 2);
INSERT INTO Skoczkowie VALUES(null, 'Tomas', 'Friedrich', '1995-02-02', null, 'skoczek17.jpg', 3, 3);
INSERT INTO Skoczkowie VALUES(null, 'Antonin', 'Hajek', '1987-02-12', null, 'skoczek18.jpg', 3, 3);
INSERT INTO Skoczkowie VALUES(null, 'Jakub', 'Janda', '1978-04-27', null, 'skoczek19.jpg', 3, 3);
INSERT INTO Skoczkowie VALUES(null, 'Roman', 'Koudelka', '1989-07-09', null, 'skoczek20.jpg', 3, 3);
