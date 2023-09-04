-- TABLAS PRINCIPALES

--- Entidad REGION
CREATE TABLE REGION(
codigo NUMBER(6) GENERATED ALWAYS AS IDENTITY START WITH 1 INCREMENT BY 1,
nombre VARCHAR2(20) NOT NULL,
CONSTRAINT PK_REGION PRIMARY KEY (codigo) 
);

-- Entidad PROFESION
CREATE TABLE PROFESION(
codigo NUMBER(6) GENERATED ALWAYS AS IDENTITY START WITH 1 INCREMENT BY 1,
nombre VARCHAR2(20) NOT NULL,
CONSTRAINT PK_PROFESION PRIMARY KEY (codigo)
);

-- Entidad ESTADO_CIVIL
CREATE TABLE ESTADO_CIVIL(
codigo NUMBER(6) GENERATED ALWAYS AS IDENTITY START WITH 1 INCREMENT BY 1,
nombre VARCHAR2(20) NOT NULL,
CONSTRAINT PK_ESTADO_CIVIL PRIMARY KEY (codigo)
);

-- Entidad TIPO_ESCUELA
CREATE TABLE TIPO_ESCUELA(
codigo NUMBER(6) GENERATED ALWAYS AS IDENTITY START WITH 1 INCREMENT BY 1,
nombre VARCHAR2(20) NOT NULL,
CONSTRAINT PK_TIPO_ESCUELA PRIMARY KEY (codigo)
);

-- Entidad LUGAR_ESTUDIO
CREATE TABLE LUGAR_ESTUDIO(
codigo NUMBER(6) GENERATED ALWAYS AS IDENTITY START WITH 1 INCREMENT BY 1,
nombre VARCHAR2(20) NOT NULL,
CONSTRAINT PK_LUGAR_ESTUDIO PRIMARY KEY (codigo)
);

-- Entidad ESPECIALIDAD
CREATE TABLE ESPECIALIDAD(
codigo NUMBER(6) GENERATED ALWAYS AS IDENTITY START WITH 1 INCREMENT BY 1,
nombre VARCHAR2(20) NOT NULL,
CONSTRAINT PK_ESPECIALIDAD PRIMARY KEY (codigo)
);

-- Entidad AFP
CREATE TABLE AFP(
codigo NUMBER(6) GENERATED ALWAYS AS IDENTITY START WITH 1 INCREMENT BY 1,
nombre VARCHAR2(20) NOT NULL,
CONSTRAINT PK_AFP PRIMARY KEY (codigo)
);

-- Entidad SALUD
CREATE TABLE SALUD(
codigo NUMBER(6) GENERATED ALWAYS AS IDENTITY START WITH 1 INCREMENT BY 1,
nombre VARCHAR2(20) NOT NULL,
CONSTRAINT PK_SALUD PRIMARY KEY (codigo)
);

-- Entidad COMUNA
CREATE TABLE COMUNA(
codigo NUMBER(6) GENERATED ALWAYS AS IDENTITY START WITH 1 INCREMENT BY 1,
nombre VARCHAR2(20) NOT NULL,
REGION_codigo NUMBER(6) NOT NULL,
CONSTRAINT PK_COMUNA PRIMARY KEY (codigo),
CONSTRAINT FK_COMUNA_REGION FOREIGN KEY (REGION_codigo) REFERENCES REGION (codigo)
);

-- Entidad PROFESOR
-- Cambie run de NUMBER(12) a NUMBER(8) por que RUN tiene solo 8 digitos.
CREATE TABLE PROFESOR(
numero_folio NUMBER(10) GENERATED ALWAYS AS IDENTITY START WITH 1 INCREMENT BY 1,
run NUMBER(8) NOT NULL,
dvrun VARCHAR2(1) NOT NULL,
pnombre VARCHAR2(20) NOT NULL,
snombre VARCHAR2(20), 
apaterno VARCHAR2(20) NOT NULL,
amaterno VARCHAR2(20) NOT NULL,
calle VARCHAR2(30) NOT NULL,
numero NUMBER(5) NOT NULL,
COMUNA_codigo NUMBER(6) NOT NULL,
LUGAR_ESTUDIO_codigo NUMBER(6) NOT NULL,
ESPECIALIDAD_codigo NUMBER(6),
CONSTRAINT PK_PROFESOR PRIMARY KEY (numero_folio),
CONSTRAINT FK_PROFESOR_COMUNA FOREIGN KEY (COMUNA_codigo) REFERENCES COMUNA (codigo),
CONSTRAINT FK_PROFESOR_LUGAR_ESTUDIO FOREIGN KEY (LUGAR_ESTUDIO_codigo) REFERENCES LUGAR_ESTUDIO (codigo),
CONSTRAINT FK_PROFESOR_ESPECIALIDAD FOREIGN KEY (ESPECIALIDAD_codigo) REFERENCES ESPECIALIDAD (codigo)
);

-- Entidad DIRECTOR
CREATE TABLE DIRECTOR(
rut NUMBER(8) NOT NULL,
dv_rut VARCHAR2(1) NOT NULL,
pnombre VARCHAR2(20) NOT NULL,
snombre VARCHAR2(20),
apaterno VARCHAR2(20) NOT NULL,
amaterno VARCHAR2(20) NOT NULL,
calle VARCHAR2(20) NOT NULL,
numero NUMBER(6) NOT NULL,
mail VARCHAR2(50) NOT NULL,
nacionalidad VARCHAR2(20) NOT NULL,
fecha DATE,
firma BLOB,
ESCUELA_nombre VARCHAR2(30) NOT NULL,
PROFESION_codigo NUMBER(6) NOT NULL,
ESTADO_CIVIL_codigo NUMBER(6) NOT NULL,
COMUNA_codigo NUMBER(6) NOT NULL,
CONSTRAINT PK_DIRECTOR PRIMARY KEY (rut),
CONSTRAINT FK_DIRECTOR_PROFESION FOREIGN KEY (PROFESION_codigo) REFERENCES PROFESION (codigo),
CONSTRAINT FK_DIRECTOR_COMUNA FOREIGN KEY (COMUNA_codigo) REFERENCES COMUNA (codigo),
CONSTRAINT FK_DIRECTOR_ESTADO_CIVIL FOREIGN KEY (ESTADO_CIVIL_codigo) REFERENCES ESTADO_CIVIL (codigo)
);

-- Entidad ESCUELA
CREATE TABLE ESCUELA(
nombre VARCHAR2(30) NOT NULL,
calle VARCHAR2(30) NOT NULL,
numero NUMBER(7) NOT NULL,
sitio_web VARCHAR2(40),
nombre_club VARCHAR2(30) NOT NULL,
nro_inscripcion NUMBER(7) NOT NULL,
fecha_resolucion DATE NOT NULL,
DIRECTOR_rut NUMBER(8) NOT NULL,
COMUNA_codigo NUMBER(6) NOT NULL,
TIPO_ESCUELA_codigo NUMBER(6) NOT NULL,
CONSTRAINT PK_ESCUELA PRIMARY KEY (nombre),
CONSTRAINT FK_ESCUELA_COMUNA FOREIGN KEY (COMUNA_codigo) REFERENCES COMUNA(codigo),
CONSTRAINT FK_ESCUELA_TIPO_ESCUELA FOREIGN KEY (TIPO_ESCUELA_codigo) REFERENCES TIPO_ESCUELA(codigo)
);

-- Restricción UNIQUE en la tabla DIRECTOR y ESCUELA
ALTER TABLE DIRECTOR ADD CONSTRAINT DIRECTOR_IDX UNIQUE (ESCUELA_nombre);
ALTER TABLE ESCUELA ADD CONSTRAINT ESCUELA_IDX UNIQUE (DIRECTOR_rut);

-- Entidad TELEFONO
CREATE TABLE TELEFONO(
fono1 NUMBER(12) NOT NULL,
fono2 NUMBER(12),
fono3 NUMBER(12),
DIRECTOR_rut NUMBER(12) NOT NULL,
CONSTRAINT PK_TELEFONO PRIMARY KEY (DIRECTOR_rut),
CONSTRAINT FK_TELEFONO_DIRECTOR FOREIGN KEY (DIRECTOR_rut) REFERENCES DIRECTOR(rut)
);

-- Entidad INVERSION
CREATE TABLE INVERSION(
nombre_proyecto VARCHAR2(30) NOT NULL,
monto_inversion NUMBER(6) NOT NULL,
ESCUELA_nombre VARCHAR2(30) NOT NULL,
CONSTRAINT PK_INVERSION PRIMARY KEY (nombre_proyecto),
CONSTRAINT FK_INVERSION_ESCUELA FOREIGN KEY (ESCUELA_nombre) REFERENCES ESCUELA(nombre)
);

-- Entidad ADJUDICACION
CREATE TABLE ADJUDICACION(
codigo NUMBER(6) GENERATED ALWAYS AS IDENTITY START WITH 1 INCREMENT BY 1,
puntaje NUMBER(5) NOT NULL,
monto_otorgado NUMBER(6) NOT NULL,
cumple CHAR(1) NOT NULL,
INVERSION_nombre_proyecto VARCHAR2(30) NOT NULL,
CONSTRAINT PK_ADJUDICACION PRIMARY KEY (codigo),
CONSTRAINT FK_ADJUDICACION_INVERSION FOREIGN KEY (INVERSION_nombre_proyecto) REFERENCES INVERSION(nombre_proyecto),
CONSTRAINT ADJUDICACION_IDX UNIQUE (INVERSION_nombre_proyecto)
);

-- Entidad INFRAESTRUCTURA
CREATE TABLE INFRAESTRUCTURA(
nombre_proyecto VARCHAR2(30) NOT NULL,
CONSTRAINT PK_INFRAESTRUCTURA PRIMARY KEY (nombre_proyecto),
CONSTRAINT FK_INFRAESTRUCTURA_INVERSION FOREIGN KEY (nombre_proyecto) REFERENCES INVERSION(nombre_proyecto)
);

-- Entidad IMPLEMENTO
CREATE TABLE IMPLEMENTO(
nombre_proyecto VARCHAR2(30) NOT NULL,
CONSTRAINT PK_IMPLEMENTO PRIMARY KEY (nombre_proyecto),
CONSTRAINT FK_IMPLEMENTO_INVERSION FOREIGN KEY (nombre_proyecto) REFERENCES INVERSION(nombre_proyecto)
);

-- Entidad CONTRATO
CREATE TABLE CONTRATO(
nombre_proyecto VARCHAR2(30) NOT NULL,
CONSTRAINT PK_CONTRATO PRIMARY KEY (nombre_proyecto),
CONSTRAINT FK_CONTRATO_INVERSION FOREIGN KEY (nombre_proyecto) REFERENCES INVERSION(nombre_proyecto)
);

-- Entidad PROFESOR_INDEFINIDO
CREATE TABLE PROFESOR_INDEFINIDO(
numero_folio NUMBER(10) NOT NULL,
sueldo NUMBER(7) NOT NULL,
AFP_codigo NUMBER(6) NOT NULL,
SALUD_codigo NUMBER(6) NOT NULL,
CONSTRAINT PK_PROFESOR_INDEFINIDO PRIMARY KEY (numero_folio),
CONSTRAINT FK_PROF_INDEFINIDO_PROFESOR FOREIGN KEY (numero_folio) REFERENCES PROFESOR(numero_folio),
CONSTRAINT FK_PROFESOR_INDEFINIDO_AFP FOREIGN KEY (AFP_codigo) REFERENCES AFP(codigo),
CONSTRAINT FK_PROFESOR_INDEFINIDO_SALUD FOREIGN KEY (SALUD_codigo) REFERENCES SALUD(codigo)
);

-- Entidad PROFESOR_HONORARIO
CREATE TABLE PROFESOR_HONORARIO(
numero_folio NUMBER(10) NOT NULL,
total_horas NUMBER(5) NOT NULL,
valor_hora NUMBER(5) NOT NULL,
CONSTRAINT PK_PROFESOR_HONORARIO PRIMARY KEY (numero_folio),
CONSTRAINT FK_PROF_HONORARIO_PROFESOR FOREIGN KEY (numero_folio) REFERENCES PROFESOR(numero_folio)
);

-- Entidad TURNO
CREATE TABLE TURNO(
dia_hora_inicio DATE NOT NULL,
dia_hora_termino DATE NOT NULL,
ESCUELA_nombre VARCHAR2(30) NOT NULL,
PROFESOR_numero_folio NUMBER(10) NOT NULL,
CONSTRAINT PK_TURNO PRIMARY KEY (ESCUELA_nombre, PROFESOR_numero_folio),
CONSTRAINT FK_TURNO_ESCUELA FOREIGN KEY (ESCUELA_nombre) REFERENCES ESCUELA (nombre),
CONSTRAINT FK_TURNO_PROFESOR FOREIGN KEY (PROFESOR_numero_folio) REFERENCES PROFESOR (numero_folio)
);

-- Ingreso de datos a las Entidades

-- Registros para REGION
INSERT INTO REGION (nombre) VALUES ('Metropolitana');
INSERT INTO REGION (nombre) VALUES ('Tarapaca');
INSERT INTO REGION (nombre) VALUES ('Antofagasta');
INSERT INTO REGION (nombre) VALUES ('Atacama');
INSERT INTO REGION (nombre) VALUES ('Coquimbo');

-- Registros para PROFESION
INSERT INTO PROFESION (nombre) VALUES ('Profesion 1');
INSERT INTO PROFESION (nombre) VALUES ('Profesion 2');
INSERT INTO PROFESION (nombre) VALUES ('Profesion 3');
INSERT INTO PROFESION (nombre) VALUES ('Profesion 4');
INSERT INTO PROFESION (nombre) VALUES ('Profesion 5');

-- Registros para ESTADO_CIVL
INSERT INTO ESTADO_CIVIL (nombre) VALUES ('Soltero');
INSERT INTO ESTADO_CIVIL (nombre) VALUES ('Casado');
INSERT INTO ESTADO_CIVIL (nombre) VALUES ('Viudo');
INSERT INTO ESTADO_CIVIL (nombre) VALUES ('Divorciado');
INSERT INTO ESTADO_CIVIL (nombre) VALUES ('Separado');

-- Registros para TIPO_ESCUELA
INSERT INTO TIPO_ESCUELA (nombre) VALUES ('Tipo Escuela 1');
INSERT INTO TIPO_ESCUELA (nombre) VALUES ('Tipo Escuela 2');
INSERT INTO TIPO_ESCUELA (nombre) VALUES ('Tipo Escuela 3');
INSERT INTO TIPO_ESCUELA (nombre) VALUES ('Tipo Escuela 4');
INSERT INTO TIPO_ESCUELA (nombre) VALUES ('Tipo Escuela 5');

-- Registros para LUGAR_ESTUDIO
INSERT INTO LUGAR_ESTUDIO (nombre) VALUES ('Lugar estudio 1');
INSERT INTO LUGAR_ESTUDIO (nombre) VALUES ('Lugar estudio 2');
INSERT INTO LUGAR_ESTUDIO (nombre) VALUES ('Lugar estudio 3');
INSERT INTO LUGAR_ESTUDIO (nombre) VALUES ('Lugar estudio 4');
INSERT INTO LUGAR_ESTUDIO (nombre) VALUES ('Lugar estduio 5');

-- Registros para ESPECIALIDAD
INSERT INTO ESPECIALIDAD (nombre) VALUES ('Especialidad 1');
INSERT INTO ESPECIALIDAD (nombre) VALUES ('Especialidad 2');
INSERT INTO ESPECIALIDAD (nombre) VALUES ('Especialidad 3');
INSERT INTO ESPECIALIDAD (nombre) VALUES ('Especialidad 4');
INSERT INTO ESPECIALIDAD (nombre) VALUES ('Especialidad 5');

-- Registros para AFP
INSERT INTO AFP (nombre) VALUES ('AFP 1');
INSERT INTO AFP (nombre) VALUES ('AFP 2');
INSERT INTO AFP (nombre) VALUES ('AFP 3');
INSERT INTO AFP (nombre) VALUES ('AFP 4');
INSERT INTO AFP (nombre) VALUES ('AFP 5');

-- Registros para SALUD
INSERT INTO SALUD (nombre) VALUES ('Salud 1');
INSERT INTO SALUD (nombre) VALUES ('Salud 2');
INSERT INTO SALUD (nombre) VALUES ('Salud 3');
INSERT INTO SALUD (nombre) VALUES ('Salud 4');
INSERT INTO SALUD (nombre) VALUES ('Salud 5');

-- Registros para COMUNA
INSERT INTO COMUNA (nombre, REGION_codigo) VALUES ('Comuna 1', 1);
INSERT INTO COMUNA (nombre, REGION_codigo) VALUES ('Comuna 2', 2);
INSERT INTO COMUNA (nombre, REGION_codigo) VALUES ('Comuna 3', 3);
INSERT INTO COMUNA (nombre, REGION_codigo) VALUES ('Comuna 4', 4);
INSERT INTO COMUNA (nombre, REGION_codigo) VALUES ('Comuna 5', 5);

-- Registros para PROFESOR
INSERT INTO PROFESOR (run, dvrun, pnombre, snombre, apaterno, amaterno, calle, numero, COMUNA_codigo, LUGAR_ESTUDIO_codigo, ESPECIALIDAD_codigo)
VALUES (20543608, '5', 'nombre 1', 'segundo nombre 1', 'apellido 1', 'apellido 1', 'calle 1', 1, 1, 1, 1);

INSERT INTO PROFESOR (run, dvrun, pnombre, snombre, apaterno, amaterno, calle, numero, COMUNA_codigo, LUGAR_ESTUDIO_codigo, ESPECIALIDAD_codigo)
VALUES (13895762, '7', 'nombre 2', 'segundo nobre 2', 'apelido 2', 'apellido 2', 'calle2', 2, 2, 2, 2);

INSERT INTO PROFESOR (run, dvrun, pnombre, snombre, apaterno, amaterno, calle, numero, COMUNA_codigo, LUGAR_ESTUDIO_codigo, ESPECIALIDAD_codigo)
VALUES (22318753, '2', 'nombre 3', 'segudo nombre 3', 'apellido 3', 'apellido 3', 'calle 3', 3, 3, 3, 3);

INSERT INTO PROFESOR (run, dvrun, pnombre, snombre, apaterno, amaterno, calle, numero, COMUNA_codigo, LUGAR_ESTUDIO_codigo, ESPECIALIDAD_codigo)
VALUES (11980236, '9', 'nombre 4', 'segundo nombre 4', 'apelldio 4', 'apellido 4', 'calle4', 4, 4, 4, 4);

INSERT INTO PROFESOR (run, dvrun, pnombre, snombre, apaterno, amaterno, calle, numero, COMUNA_codigo, LUGAR_ESTUDIO_codigo, ESPECIALIDAD_codigo)
VALUES (18164597, '0', 'nombre 5', 'segundo nombre 5', 'apellido 5', 'apellido 5', 'calle 5', 5, 5, 5, 5);

-- Registros para ESCUELA
INSERT INTO ESCUELA (nombre, calle, numero, sitio_web, nombre_club, nro_inscripcion, fecha_resolucion, DIRECTOR_rut, COMUNA_codigo, TIPO_ESCUELA_codigo) 
VALUES ('Escuela 1', 'Calleescuela 1', 1, 'www.escuela1.cl', 'club 1', 1, TO_DATE('2023-07-07', 'YYYY-MM-DD'), 15487692, 1, 1);

INSERT INTO ESCUELA (nombre, calle, numero, sitio_web, nombre_club, nro_inscripcion, fecha_resolucion, DIRECTOR_rut, COMUNA_codigo, TIPO_ESCUELA_codigo) 
VALUES ('Escuela 2', 'Calle escuela 2', 2, 'www.escula2.cl', 'club 2', 2, TO_DATE('2023-07-07', 'YYYY-MM-DD'), 21830973, 2, 2);

INSERT INTO ESCUELA (nombre, calle, numero, sitio_web, nombre_club, nro_inscripcion, fecha_resolucion, DIRECTOR_rut, COMUNA_codigo, TIPO_ESCUELA_codigo) 
VALUES ('Escuela 3', 'Calle escuela 3', 3, 'www.escuela3.cl', 'club 3', 3, TO_DATE('2023-07-07', 'YYYY-MM-DD'), 16975483, 3, 3);

INSERT INTO ESCUELA (nombre, calle, numero, sitio_web, nombre_club, nro_inscripcion, fecha_resolucion, DIRECTOR_rut, COMUNA_codigo, TIPO_ESCUELA_codigo) 
VALUES ('Escuela 4', 'calle escula 4', 4, 'www.escuela4.cl', 'club 4', 4, TO_DATE('2023-07-07', 'YYYY-MM-DD'), 23786594, 4, 4);

INSERT INTO ESCUELA (nombre, calle, numero, sitio_web, nombre_club, nro_inscripcion, fecha_resolucion, DIRECTOR_rut, COMUNA_codigo, TIPO_ESCUELA_codigo) 
VALUES ('Escuela 5', 'Calle escuela 5', 5, 'www.ecuela5.cl', 'club 5', 5, TO_DATE('2023-07-07', 'YYYY-MM-DD'), 19283746, 5, 5);

-- Registros para DIRECTOR
INSERT INTO DIRECTOR (rut, dv_rut, pnombre, snombre, apaterno, amaterno, calle, numero, mail, nacionalidad, fecha, firma, ESCUELA_nombre, PROFESION_codigo, ESTADO_CIVIL_codigo, COMUNA_codigo)
VALUES (15487692, '3', 'Juan', NULL, 'Perez', 'Gonzalez', 'Calle Director 1', 1, 'juan.perez@correo.cl', 'Chileno', TO_DATE('01/01/1990', 'DD/MM/YYYY'), NULL, 'Escuela 1', 1, 1, 1);

INSERT INTO DIRECTOR (rut, dv_rut, pnombre, snombre, apaterno, amaterno, calle, numero, mail, nacionalidad, fecha, firma, ESCUELA_nombre, PROFESION_codigo, ESTADO_CIVIL_codigo, COMUNA_codigo)
VALUES (21830973, '1', 'Maria', 'Elena', 'Gonzalez', 'Lopez', 'Calle Director 2', 2, 'maria.gonzalez@correo.cl', 'chilena', TO_DATE('15/02/1995', 'DD/MM/YYYY'), NULL, 'Escuela 2', 2, 2, 2);

INSERT INTO DIRECTOR (rut, dv_rut, pnombre, snombre, apaterno, amaterno, calle, numero, mail, nacionalidad, fecha, firma, ESCUELA_nombre, PROFESION_codigo, ESTADO_CIVIL_codigo, COMUNA_codigo)
VALUES (16975483, '8', 'Pedro', 'Antonio', 'Lopez', 'Sanchez', 'Calle director 3', 3, 'pedrolopez@correo.cl', 'chileno', TO_DATE('20/06/1985', 'DD/MM/YYYY'), NULL, 'Escuela 3', 3, 3, 3);

INSERT INTO DIRECTOR (rut, dv_rut, pnombre, snombre, apaterno, amaterno, calle, numero, mail, nacionalidad, fecha, firma, ESCUELA_nombre, PROFESION_codigo, ESTADO_CIVIL_codigo, COMUNA_codigo)
VALUES (23786594, '0', 'Ana', NULL, 'Sanchez', 'Munoz', 'Calle director 4', 4, 'ana.sanchez@correo.cl', 'Chilena', TO_DATE('10/11/1992', 'DD/MM/YYYY'), NULL, 'Escuela 4', 4, 4, 4);

INSERT INTO DIRECTOR (rut, dv_rut, pnombre, snombre, apaterno, amaterno, calle, numero, mail, nacionalidad, fecha, firma, ESCUELA_nombre, PROFESION_codigo, ESTADO_CIVIL_codigo, COMUNA_codigo)
VALUES (19283746, '2', 'Carlos', 'Albeto', 'Gutierrez', 'Vargas', 'Calle director 5', 5, 'carlosgutierrez@correo.cl', 'Chileno', TO_DATE('25/09/1998', 'DD/MM/YYYY'), NULL, 'Escuela 5', 5, 5, 5);

-- Registros para TELEFONO
INSERT INTO TELEFONO (fono1, fono2, fono3, DIRECTOR_rut)
VALUES (912345678, 923456789, NULL, 15487692);

INSERT INTO TELEFONO (fono1, fono2, fono3, DIRECTOR_rut)
VALUES (934567890, NULL, NULL, 21830973);

INSERT INTO TELEFONO (fono1, fono2, fono3, DIRECTOR_rut)
VALUES (956789012, 967890123, NULL, 16975483);

INSERT INTO TELEFONO (fono1, fono2, fono3, DIRECTOR_rut)
VALUES (978901234, NULL, NULL, 23786594);

INSERT INTO TELEFONO (fono1, fono2, fono3, DIRECTOR_rut)
VALUES (990123456, 901234567, NULL, 19283746);

-- Registros para INVERSION
INSERT INTO INVERSION (nombre_proyecto, monto_inversion, ESCUELA_nombre)
VALUES ('Proyecto 1', 100000, 'Escuela 1');

INSERT INTO INVERSION (nombre_proyecto, monto_inversion, ESCUELA_nombre)
VALUES ('Proyecto 2', 200000, 'Escuela 2');

INSERT INTO INVERSION (nombre_proyecto, monto_inversion, ESCUELA_nombre)
VALUES ('Proyecto 3', 300000, 'Escuela 3');

INSERT INTO INVERSION (nombre_proyecto, monto_inversion, ESCUELA_nombre)
VALUES ('Proyecto 4', 400000, 'Escuela 4');

INSERT INTO INVERSION (nombre_proyecto, monto_inversion, ESCUELA_nombre)
VALUES ('Proyecto 5', 500000, 'Escuela 5');

-- Registros para ADJUDICACION
INSERT INTO ADJUDICACION (puntaje, monto_otorgado, cumple, INVERSION_nombre_proyecto)
VALUES (80, 800000, 's', 'Proyecto 1');

INSERT INTO ADJUDICACION (puntaje, monto_otorgado, cumple, INVERSION_nombre_proyecto)
VALUES (85, 150000, 's', 'Proyecto 2');

INSERT INTO ADJUDICACION (puntaje, monto_otorgado, cumple, INVERSION_nombre_proyecto)
VALUES (90, 270000, 'n', 'Proyecto 3');

INSERT INTO ADJUDICACION (puntaje, monto_otorgado, cumple, INVERSION_nombre_proyecto)
VALUES (75, 320000, 'n', 'Proyecto 4');

INSERT INTO ADJUDICACION (puntaje, monto_otorgado, cumple, INVERSION_nombre_proyecto)
VALUES (95, 480000, 'n', 'Proyecto 5');

-- Registros para INFRAESTRUCTURA
INSERT INTO INFRAESTRUCTURA (nombre_proyecto)
VALUES ('Proyecto 1');

INSERT INTO INFRAESTRUCTURA (nombre_proyecto)
VALUES ('Proyecto 2');

INSERT INTO INFRAESTRUCTURA (nombre_proyecto)
VALUES ('Proyecto 3');

INSERT INTO INFRAESTRUCTURA (nombre_proyecto)
VALUES ('Proyecto 4');

INSERT INTO INFRAESTRUCTURA (nombre_proyecto)
VALUES ('Proyecto 5');

-- Registros para IMPLEMENTO
INSERT INTO IMPLEMENTO (nombre_proyecto)
VALUES ('Proyecto 1');

INSERT INTO IMPLEMENTO (nombre_proyecto)
VALUES ('Proyecto 2');

INSERT INTO IMPLEMENTO (nombre_proyecto)
VALUES ('Proyecto 3');

INSERT INTO IMPLEMENTO (nombre_proyecto)
VALUES ('Proyecto 4');

INSERT INTO IMPLEMENTO (nombre_proyecto)
VALUES ('Proyecto 5');

-- Registros para CONTRATO
INSERT INTO CONTRATO (nombre_proyecto)
VALUES ('Proyecto 1');

INSERT INTO CONTRATO (nombre_proyecto)
VALUES ('Proyecto 2');

INSERT INTO CONTRATO (nombre_proyecto)
VALUES ('Proyecto 3');

INSERT INTO CONTRATO (nombre_proyecto)
VALUES ('Proyecto 4');

INSERT INTO CONTRATO (nombre_proyecto)
VALUES ('Proyecto 5');

-- Registros para PROFESOR_INDEFINIDO
INSERT INTO PROFESOR_INDEFINIDO (numero_folio, sueldo, AFP_codigo, SALUD_codigo)
VALUES (1, 1000000, 1, 1);

INSERT INTO PROFESOR_INDEFINIDO (numero_folio, sueldo, AFP_codigo, SALUD_codigo)
VALUES (2, 1500000, 2, 2);

INSERT INTO PROFESOR_INDEFINIDO (numero_folio, sueldo, AFP_codigo, SALUD_codigo)
VALUES (3, 2000000, 3, 3);

INSERT INTO PROFESOR_INDEFINIDO (numero_folio, sueldo, AFP_codigo, SALUD_codigo)
VALUES (4, 2500000, 4, 4);

INSERT INTO PROFESOR_INDEFINIDO (numero_folio, sueldo, AFP_codigo, SALUD_codigo)
VALUES (5, 3000000, 5, 5);

-- Registros para PROFESOR_HONORARIO
INSERT INTO PROFESOR_HONORARIO (numero_folio, total_horas, valor_hora)
VALUES (1, 80, 10000);

INSERT INTO PROFESOR_HONORARIO (numero_folio, total_horas, valor_hora)
VALUES (2, 100, 12000);

INSERT INTO PROFESOR_HONORARIO (numero_folio, total_horas, valor_hora)
VALUES (3, 120, 15000);

INSERT INTO PROFESOR_HONORARIO (numero_folio, total_horas, valor_hora)
VALUES (4, 90, 11000);

INSERT INTO PROFESOR_HONORARIO (numero_folio, total_horas, valor_hora)
VALUES (5, 110, 13000);

-- Registros para TURNO
INSERT INTO TURNO (dia_hora_inicio, dia_hora_termino, ESCUELA_nombre, PROFESOR_numero_folio)
VALUES (TIMESTAMP '2023-01-01 08:00:00', TIMESTAMP '2023-01-01 12:00:00', 'Escuela 1', 1);

INSERT INTO TURNO (dia_hora_inicio, dia_hora_termino, ESCUELA_nombre, PROFESOR_numero_folio)
VALUES (TIMESTAMP '2023-02-02 09:30:00', TIMESTAMP '2023-02-02 13:30:00', 'Escuela 2', 2);

INSERT INTO TURNO (dia_hora_inicio, dia_hora_termino, ESCUELA_nombre, PROFESOR_numero_folio)
VALUES (TIMESTAMP '2023-03-03 10:15:00', TIMESTAMP '2023-03-03 14:15:00', 'Escuela 3', 3);

INSERT INTO TURNO (dia_hora_inicio, dia_hora_termino, ESCUELA_nombre, PROFESOR_numero_folio)
VALUES (TIMESTAMP '2023-04-04 11:45:00', TIMESTAMP '2023-04-04 15:45:00', 'Escuela 4', 4);

INSERT INTO TURNO (dia_hora_inicio, dia_hora_termino, ESCUELA_nombre, PROFESOR_numero_folio)
VALUES (TIMESTAMP '2023-05-05 13:20:00', TIMESTAMP '2023-05-05 17:20:00', 'Escuela 5', 5);
