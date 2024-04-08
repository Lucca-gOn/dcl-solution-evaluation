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

SELECT 
	/*As : Definir nome*/
    p.NomeProduto AS Nome_do_Produto,
	/*COALESCE : Tratar nulo como 0*/
    (p.PrecoProduto + COALESCE(c.PrecoCor, 0)) AS Preco_Total,
    (p.PrecoProduto + COALESCE(c.PrecoCor, 0)) * 1.10 AS Preco_Com_Acrescimo,
    (p.PrecoProduto + COALESCE(c.PrecoCor, 0)) * 0.90 AS Preco_Com_Desconto,
    c.NomeCor AS Cor_do_Produto
FROM 
    Produto p
LEFT JOIN 
    Cor c ON p.IdProduto = c.IdProduto
/*Produtos não nulos retornados apenas*/
WHERE 
    p.NomeProduto IS NOT NULL
ORDER BY 
    Preco_Total ASC;
