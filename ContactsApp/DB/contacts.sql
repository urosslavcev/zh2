CREATE TABLE Contacts (
 ID integer not null PRIMARY key AUTOINCREMENT,
 Name text not null,
 Age integer not null,
 Address text not null,
 Phone text not null,
 UNIQUE(Name)
);
