CREATE DATABASE AgendaContatos;
GO


USE AgendaContatos;
GO

CREATE TABLE Contatos
(
Id INT IDENTITY (1,1) PRIMARY KEY,
Nome VARCHAR(50),
Endereço VARCHAR(50),
Celular VARCHAR(16),
Telefone VARCHAR(16),
Email VARCHAR(50)
)
GO


INSERT INTO Contatos VALUES('Kauã Fragozo', 'Hilário Fontana, 42','(54)996998550','40028922','kauafragozo@programador.com')
GO

SELECT* FROM Contatos;
GO