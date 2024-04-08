USE ProductColors;

INSERT INTO Produto(NomeProduto, PrecoProduto)
VALUES 
('Monitor LCD Samsung 740N',750),
('Mouse Microsoft ',70),
('Notebook Sony Vaio',11320.34),
(NULL,392.99)

SELECT * FROM Produto;

INSERT INTO Cor(IdProduto,NomeCor,PrecoCor)
VALUES 
(1,'Preto',5),
(1,'Azul',10),
(2,'Amarelo',20),
(4,'Chumbo',3)

SELECT * FROM Cor;