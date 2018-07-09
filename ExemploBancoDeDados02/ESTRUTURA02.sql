DROP TABLE herois;
CREATE TABLE herois(
	id INT IDENTITY (1,1) PRIMARY KEY,
	nome VARCHAR(100) NOT NULL,
	escuridao BIT NOT NULL,
	nome_pessoa VARCHAR(150) NOT NULL,
	raca VARCHAR(100) NOT NULL,
	conta_bancaria DECIMAL(17,2),
	data_nascimento DATE NOT NULL,
	sexo CHAR(1) NOT NULL,
	quantidade_filmes TINYINT NOT NULL,
	descricao TEXT
);

SELECT * FROM herois;