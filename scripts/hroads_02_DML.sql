USE HROADS
GO

INSERT INTO TipoHabilidade (tipo)
VALUES ('Ataque'),('Defesa'),('Cura'),('Magia');
GO

SELECT * FROM TipoHabilidade

INSERT INTO Habilidades(nomeHabilidade, idTipoHabilidade)
VALUES ('Lança mortal', '1'),('Escudo Supremo', '2'),('Recuperar Vida','3');
GO

SELECT * FROM Habilidades


INSERT INTO HabClasses (idHabilidade, idClasses)
VALUES (1,1),(1,1),
		(2,2),(2,3),
		(3,2),(3,1)
GO


INSERT INTO Classes (nomeClasse)
VALUES  ('Bárbaro'),('Cruzado'),('Caçadora de Demônios'),('Monge'),('Necromante'),('Feiticeiro'),('Arcanista');
GO

SELECT * FROM Classes

INSERT INTO Personagem (idClasses,nomePersonagem,vidaMax,manaMax,dataAtt,dataCriada)
values (1,'DeuBug',100,80,'2021-08-10','2019-01-18'),(4,'BitBug',70,100,'2021-08-10','2016-03-17'),(7,'Fer8',75,60,'2021-08-10','2018-03-18');
GO

INSERT INTO TipoUsuario(titulo)
VALUES ('Usuario'),('Adm')
GO

INSERT INTO Usuario(idTipoUsuario,nomeJogador,email,senha)
VALUES (1,'cardosoMATAPOMBO','cardoso@gmail.com','1234');
GO

INSERT INTO Usuario(idTipoUsuario,nomeJogador,email,senha)
VALUES (1,'Ricardin','ricardo@gmail.com','12345');
GO

INSERT INTO Usuario(idTipoUsuario,nomeJogador,email,senha)
VALUES (2,'KingCr4zY','saulo@gmail.com','123456');
GO

SELECT * FROM Personagem

UPDATE Personagem

SET nomePersonagem = 'Fer7'
WHERE idPersonagem = 3

UPDATE Classes

SET nomeClasse = 'Necromancer'
WHERE idClasses = 5;
GO
