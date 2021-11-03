CREATE DATABASE veterinaria_prog2
GO
USE veterinaria_prog2
GO
CREATE TABLE vendedor
(id_vendedor int identity (1,1),
nombre varchar (25),
apellido varchar(35),
tel bigint,
mail varchar (50),
usuario varchar(40),
pass varchar (40)
CONSTRAINT pk_vendedor primary key(id_vendedor));

CREATE TABLE clientes
(id_cliente int identity (1,1),
nombre varchar (25),
apellido varchar(35),
DNI bigint,
tel bigint
CONSTRAINT pk_clientes primary key(id_cliente));

CREATE TABLE tipo_mascotas
(id_tipo int identity (1,1),
tipo varchar(30)
CONSTRAINT pk_tipo_mascotas primary key(id_tipo));

CREATE TABLE mascotas
(id_mascota int identity (1,1),
nombre varchar (25),
edad varchar(35),
duenio int,
tipo int
CONSTRAINT pk_mascotas primary key(id_mascota),
CONSTRAINT fk_mascotas_clientes foreign key (duenio) REFERENCES clientes (id_cliente),
CONSTRAINT fk_mascotas_tipo_mascotas FOREIGN KEY (tipo) REFERENCES tipo_mascotas (id_tipo));

-------------------------------------------
CREATE TABLE tipo_servicios
(id_tipo int identity (1,1),
servicio varchar (50)
CONSTRAINT pk_tipo_servicios PRIMARY KEY (id_tipo));

CREATE TABLE servicios
(id_servicio int identity (1,1),
tipo int,
descripcion varchar (50),
precio decimal(10,2)
CONSTRAINT pk_servicios PRIMARY KEY (id_servicio),
CONSTRAINT fk_servicios_tipo_servicios FOREIGN KEY (tipo) REFERENCES tipo_servicios(id_tipo)
)



CREATE TABLE atencion
(id_atencion int identity (1,1),
fecha datetime,
mascota int,
total decimal (10,2),
CONSTRAINT pk_atencion PRIMARY KEY (id_atencion),
CONSTRAINT fk_atencion_mascotas FOREIGN KEY (mascota) REFERENCES mascotas (id_mascota));

CREATE TABLE detalle_atencion
(nro_detalle int identity (1,1),
nro_atencion int,
servicio int
CONSTRAINT pk_detalle_atencion PRIMARY KEY (nro_detalle,nro_atencion),
CONSTRAINT fk_detalle_atencion_servicios FOREIGN KEY (servicio) REFERENCES servicios (id_servicio),
CONSTRAINT fk_detalle_atencion_atencion FOREIGN KEY (nro_atencion) REFERENCES atencion (id_atencion));

-- Insercion de datos
-- TIPO MASCOTAS
INSERT INTO tipo_mascotas VALUES('Perro')
INSERT INTO tipo_mascotas VALUES('Gato')
INSERT INTO tipo_mascotas VALUES('Araña')
INSERT INTO tipo_mascotas VALUES('Iguana')

-- TIPO SERVICIOS
INSERT INTO tipo_servicios VALUES('Vacunacion')
INSERT INTO tipo_servicios VALUES('General')
INSERT INTO tipo_servicios VALUES('Consulta Medica')

-- SERVICIOS
INSERT INTO servicios VALUES (1, 'Quintuple', 800)
INSERT INTO servicios VALUES (1, 'Polivalente',850)
INSERT INTO servicios VALUES (1, 'Antirabica',1200)
INSERT INTO servicios VALUES (1, 'Primovacunacion',980)
INSERT INTO servicios VALUES (1, 'Moquillo canino',890)
INSERT INTO servicios VALUES (1, 'Influenza',1100)
INSERT INTO servicios VALUES (2, 'Peluqueria',1000)
INSERT INTO servicios VALUES (2, 'Baño',900)
INSERT INTO servicios VALUES (2, 'Corte de uñas',200)
INSERT INTO servicios VALUES (3, 'Consulta general',650)
INSERT INTO servicios VALUES (3, 'Control de peso',450)
INSERT INTO servicios VALUES (3, 'Control de heridas',600)
INSERT INTO servicios VALUES (3, 'Desparacitacion',350)

-- VENDEDORES
INSERT INTO vendedor
VALUES ('Roman', 'Bodoque', 3514566710, 'rbodoque1997@gmail.com', 'Bodoque', 'bodoke123')

-- CLIENTES
INSERT INTO clientes
VALUES ('Gaston', 'Guiñazu', 43450359, 513433937)

-- MASCOTAS
INSERT INTO mascotas
VALUES ('Chispita', 2, 1, 1)

-- ATENCION
INSERT INTO atencion
VALUES ('2021-10-25', 1, 980)

-- DETALLE ATENCION
INSERT INTO detalle_atencion
VALUES (1, 4)
