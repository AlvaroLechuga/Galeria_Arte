CREATE TABLE  EXPOSICION(
	CODIGOE INT(3) NOT NULL, 
	TITULO VARCHAR(400), 
	DESCRIPCION VARCHAR(400), 
	FECHAI DATE, 
	FECHAF DATE, 
	CONSTRAINT EXPOSICION_PK PRIMARY KEY (CODIGOE));

CREATE TABLE ARTISTA(
	CODIGOA INT(3) NOT NULL,
	NOMBRE VARCHAR(400),
	NACION VARCHAR(400),
	EDAD INT(3),
	CONSTRAINT ARTISTA_PK PRIMARY KEY(CODIGOA));

CREATE TABLE OBRA(
	CODIGOO INT(3) NOT NULL,
	NOMBRE VARCHAR(400),
	ANNO INT(4),
	ESTILO VARCHAR(400),
	PRECIO INT(6),
	CODA INT(3),
	CODEXPO INT(3),
	CONSTRAINT OBRA_PK PRIMARY KEY (CODIGOO));
ALTER TABLE OBRA ADD  FOREIGN KEY FK_CODE(CODEXPO) REFERENCES EXPOSICION(CODIGOE);
ALTER TABLE OBRA ADD  FOREIGN KEY FK_CODE1(CODA) REFERENCES ARTISTA(CODIGOA);

INSERT INTO EXPOSICION VALUES(1,'VANGUARDIA XXI','PINTURA Y ESCULTURA CONTEMPORANEA','2011-01-12','2011-03-23');
INSERT INTO EXPOSICION VALUES(2,'ESCULTURA JEREZANA','ESCULTURAS DE ARTISTAS JEREZANOS','2012-01-04','2012-02-24');
INSERT INTO EXPOSICION VALUES(3,'MARES DE PINTURA','PINTURAS DE ARTISTAS MEDITERRANEOS','2010-06-16','2010-09-04');


INSERT INTO ARTISTA VALUES(1,'Juan Lanzas','España', 45);
INSERT INTO ARTISTA VALUES(2,'Almudena Haro','Mexico',36);
INSERT INTO ARTISTA VALUES(3,'Giuseppe Conti','Italia',55);
INSERT INTO ARTISTA VALUES(4,'Linette Tatou', 'Francia',28);
INSERT INTO ARTISTA VALUES(5,'Dionisio Rivero','España',39);