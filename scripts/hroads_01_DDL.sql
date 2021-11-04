CREATE DATABASE HROADS
GO

USE HROADS
GO

--DAR GO EM CADA UM

CREATE TABLE TipoHabilidade(
	idTipoHabilidade TINYINT PRIMARY KEY IDENTITY(1,1),
	tipo VARCHAR(15) NOT NULL,
);
GO

CREATE TABLE Habilidades(
	idHabilidade TINYINT PRIMARY KEY IDENTITY(1,1),
	idTipoHabilidade TINYINT FOREIGN KEY REFERENCES TipoHabilidade(idTipoHabilidade),
	nomeHabilidade VARCHAR(30) NOT NULL UNIQUE
);
GO

CREATE TABLE Classes(
	idClasses TINYINT PRIMARY KEY IDENTITY(1,1),
	idHabilidade TINYINT FOREIGN KEY REFERENCES Habilidades(idHabilidade),
	nomeClasse VARCHAR(30) UNIQUE NOT NULL
);
GO
SELECT * FROM Classes

CREATE TABLE HabClasses (
	idHabClasses TINYINT PRIMARY KEY IDENTITY (1,1),
	idHabilidade TINYINT FOREIGN KEY REFERENCES Habilidades(idHabilidade),
	idClasses TINYINT FOREIGN KEY REFERENCES Classes(idClasses)
);
GO

CREATE TABLE Personagem(
	idPersonagem TINYINT PRIMARY KEY IDENTITY (1,1),
	idClasses TINYINT FOREIGN KEY REFERENCES Classes(idClasses),
	nomePersonagem VARCHAR(30) NOT NULL,
	vidaMax TINYINT NOT NULL,
	manaMax TINYINT NOT NULL, 
	dataAtt DATE NOT NULL,
	dataCriada DATE NOT NULL
);
GO

CREATE TABLE TipoUsuario( 
	idTipoUsuario INT PRIMARY KEY IDENTITY, 
	titulo VARCHAR(200) ); 
GO  

CREATE TABLE Usuario( 
	idUsuario INT PRIMARY KEY IDENTITY, 
	idTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario(idTipoUsuario), 
	nomeJogador VARCHAR(200), 
	email VARCHAR(200), 
	senha VARCHAR(200) ); 
GO

