CREATE DATABASE ProductColors;

USE ProductColors;

CREATE TABLE Produto(
	IdProduto INT PRIMARY KEY IDENTITY,
	NomeProduto VARCHAR(50),
	PrecoProduto DECIMAL(10, 2),
);

CREATE TABLE Cor(
	IdCor INT PRIMARY KEY IDENTITY,
	IdProduto INT FOREIGN KEY REFERENCES Produto(IdProduto),
	NomeCor VARCHAR(50),
	PrecoCor DECIMAL(10, 2),
);