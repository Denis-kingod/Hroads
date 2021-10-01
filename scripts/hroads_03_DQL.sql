USE HROADS;
GO

SELECT * FROM Habilidades;
GO

SELECT * FROM HabClasses;
GO

--Selecionar todos os personagens;
SELECT * FROM Personagem
GO

--Selecionar todos as classes
SELECT * FROM Classes
ORDER BY idClasses
GO


--Selecionar apenas os nomes das classes
SELECT nomeClasse Classe FROM Classes
GO

--Selecionar todas as habilidades
SELECT * FROM Habilidades
GO

--Realizar a contagem de quantas habilidades estão cadastradas
SELECT COUNT (*) AS [Habilidades cadastradas] FROM Habilidades
GO

--Selecionar somente os id’s das habilidades classificando-os por ordem crescente
SELECT idHabilidade FROM Habilidades
ORDER BY idHabilidade
GO

--Selecionar todos os tipos de habilidades
SELECT * FROM TIPOHABILIDADE
GO

--Selecionar todas as habilidades e a quais tipos de habilidades elas fazem parte
SELECT nomeHabilidade Habilidades, tipo Tipo FROM Habilidades
LEFT JOIN TipoHabilidade
ON TipoHabilidade.idTipoHabilidade = Habilidades.idTipoHabilidade;

--Selecionar todos os personagens e suas respectivas classes
SELECT nomePersonagem 'Nome', vidaMax 'Vida Máxima', manaMax 'Mana Máxima', nomeClasse 'Classe', dataCriada 'Data Criação', dataAtt 'Data Atualização' FROM Personagem
LEFT JOIN Classes
ON Personagem.idClasses = Classes.idClasses;
GO

--Selecionar todos os personagens e as classes (mesmo que elas não tenham correspondência em personagens)
SELECT nomePersonagem 'Nome', vidaMax 'Vida Máxima', manaMax 'Mana Máxima', nomeClasse 'Classe', dataCriada 'Data Criação', dataAtt 'Data Atualização' FROM Classes
FULL OUTER JOIN Personagem
ON Classes.idClasses = Personagem.idClasses
GO

--Selecionar todas as classes e suas respectivas habilidades
SELECT nomeClasse Classes, nomeHabilidade Habilidades FROM Classes
LEFT JOIN HabClasses
ON Classes.idClasses = HabClasses.idClasses
LEFT JOIN Habilidades
ON HabClasses.idHabilidade = Habilidades.idHabilidade
GO

--Selecionar todas as habilidades e suas classes (somente as que possuem correspondência)
SELECT nomeClasse Classes, nomeHabilidade Habilidades FROM Habilidades
LEFT JOIN HabClasses
ON HabClasses.idHabilidade = Habilidades.idHabilidade
INNER JOIN Classes
ON Classes.idClasses = HabClasses.idClasses
GO

