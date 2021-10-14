/* TABLES */
CREATE TABLE ASSINANTE
(
	ID INT PRIMARY KEY ,
	NOME NVARCHAR(20),
	SENHA NVARCHAR(15),
	EMAIL NVARCHAR(20),
	DATAINCLUSAO DATETIME,
	DATACANCELAMENTO DATETIME DEFAULT NULL,
	ATIVO BIT DEFAULT 1
)

/* INSERTIONS */
INSERT INTO ASSINANTE VALUES (1, 'AARON', 'SENHATESTE', 'AARON@', GETDATE(), NULL, 1);
INSERT INTO ASSINANTE VALUES (2, 'EU', 'SENHATESTE', '2222TESTE@', GETDATE(), NULL, 1);
INSERT INTO ASSINANTE VALUES (3, 'TESTELL', 'SENHATESTE', '44@', GETDATE(), NULL, 1);
INSERT INTO ASSINANTE VALUES (4, 'TESTEAA', 'SENHATESTE', '12565656@', GETDATE(), NULL, 1);
INSERT INTO ASSINANTE VALUES (5,'TETSGGGB', 'SENHATESTE', '55555@', GETDATE(), NULL, 1);
INSERT INTO ASSINANTE VALUES (6, 'ALIEN2', 'SENHATESTE', 'POPPPP@', GETDATE(), NULL, 1);
-- CARGA 2 
INSERT INTO ASSINANTE VALUES (10, 'Camila', 'senaaa', 'email@', GETDATE(), NULL, 1);
INSERT INTO ASSINANTE VALUES (11, 'Geovane', 'password', 'aaaaaa@', GETDATE(), NULL, 1);
INSERT INTO ASSINANTE VALUES (12, 'Lucas', 'ppmmad', '44@', GETDATE(), NULL, 1);
INSERT INTO ASSINANTE VALUES (13, 'Geadson Lucas', 'senha123', 'GL@gmail', GETDATE(), NULL, 1);
INSERT INTO ASSINANTE VALUES (14,'TesteAliente', '6546565', 'MKA@gmail', GETDATE(), NULL, 1);
INSERT INTO ASSINANTE VALUES (15, 'ALaIEN2', 'aaaaaa', 'POPPponmamnPP@', GETDATE(), NULL, 1);

/* SELECTION */
SELECT * FROM ASSINANTE(NOLOCK)

/* ALTERATIONS */
ALTER TABLE ASSINANTE ADD  DataCancelamento DATETIME
ALTER TABLE ASSINANTE ADD  DataInclusao DATETIME
ALTER TABLE ASSINANTE ADD  Ativo BIT DEFAULT 1
UPDATE ASSINANTE SET ATIVO = 1
UPDATE ASSINANTE SET DATAINCLUSAO = GETDATE()
-- DROP TABLE ASSINANTE