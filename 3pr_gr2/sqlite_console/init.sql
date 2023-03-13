-- SQLite
CREATE TABLE MyContacts(
    id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
    firstName varchar(50),
    lastName varchar(50),
    email varchar(50)
);
INSERT INTO MyContacts(firstName,lastName,email)
VALUES ('Jan','Nowak','jan@gmail.com');
INSERT INTO MyContacts(firstName,lastName,email)
VALUES ('Anna','Wanna','anna@gmail.com');
INSERT INTO MyContacts(firstName,lastName,email)
VALUES ('Teresa','Meresa','teresa@gmail.com');