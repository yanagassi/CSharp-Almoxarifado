
CREATE DATABASE almoxarifado
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'Portuguese_Brazil.1252'
    LC_CTYPE = 'Portuguese_Brazil.1252'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1;

CREATE TABLE estoque 
(
    id serial ,
    nome character varying(50),
    quantidade integer,
    descricao character varying(50)
);

CREATE TABLE funcionarios
(
id serial,
    nome character varying(50),
    departamento integer NOT NULL
);
CREATE TABLE requisicoes
(
    id serial,
    items character varying(30),
    usuario integer NOT NULL,
    observacao varchar(500),
    data timestamp without time zone
);

INSERT INTO funcionarios (nome, departamento) values ('Yan Esteves', 1);
INSERT INTO estoque ( nome, quantidade, descricao) values ( 'Fanta - UVA', 10,'Fanta sabor UVA.');
INSERT INTO estoque ( nome, quantidade, descricao) values ('Fanta - Laranja', 11, 'Fanta sabor LARANJA');

