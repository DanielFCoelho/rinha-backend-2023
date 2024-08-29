CREATE TABLE public.pessoas (
	id uuid NOT NULL,
	apelido varchar NOT NULL,
	nome varchar NOT NULL,
	nascimento date NOT NULL,
	stack varchar NULL,
	CONSTRAINT pessoas_pk PRIMARY KEY (id),
	CONSTRAINT pessoas_unique UNIQUE (apelido)
);
