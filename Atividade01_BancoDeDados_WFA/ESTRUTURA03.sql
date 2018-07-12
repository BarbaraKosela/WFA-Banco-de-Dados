CREATE TABLE alunos(
    id INT IDENTITY (1,1) PRIMARY KEY,
	nome VARCHAR(100) NOT NULL, 
	codigo_matricula VARCHAR(100) NOT NULL,
	nota01 REAL NOT NULL,
	nota02 REAL NOT NULL,
	nota03 REAL NOT NULL,
	frequencia TINYINT

);

SELECT * FROM alunos;

