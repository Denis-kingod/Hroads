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
VALUES (7,1),(8,1),
		(8,2),(7,3),
		(8,4),(9,4),
		(9,6)
GO

--A ID da habilidade acima está como 7/8/9 por conta de uma complicação que tive que não fui capaz de alterar (angelo)

INSERT INTO Classes (nomeClasse)
VALUES  ('Bárbaro'),('Cruzado'),('Caçadora de Demônios'),('Monge'),('Necromante'),('Feiticeiro'),('Arcanista');
GO

SELECT * FROM Classes

INSERT INTO Personagem (idClasses,nomePersonagem,vidaMax,manaMax,dataAtt,dataCriada)
values (1,'DeuBug',100,80,'2021-08-10','2019-01-18'),(4,'BitBug',70,100,'2021-08-10','2016-03-17'),(7,'Fer8',75,60,'2021-08-10','2018-03-18');
GO

SELECT * FROM Personagem

UPDATE Personagem

SET nomePersonagem = 'Fer7'
WHERE idPersonagem = 3

UPDATE Classes

SET nomeClasse = 'Necromancer'
WHERE idClasses = 5;
GO
