CREATE DATABASE Test;
GO

USE Test;
GO

CREATE TABLE Carrera (
    ID INT NOT NULL PRIMARY KEY,
    Nombre VARCHAR(100),
    Tipo VARCHAR(100), -- se refiere a ser técnico, lic, ing
    Facultad VARCHAR(100)
);

CREATE TABLE Materias (
    Codigo VARCHAR(6) NOT NULL PRIMARY KEY,
    Nombre VARCHAR(30),
    Lab INT, -- puede ser 1 (true) o 0 (false)
    Grupo VARCHAR(3),
    ID INT,
    Requisito VARCHAR(6),
    UV INT,
    Inscritos INT,
    FOREIGN KEY (ID) REFERENCES Carrera(ID)
);

CREATE TABLE Usuario (
    Usuario VARCHAR(10) NOT NULL PRIMARY KEY,
    Nombres VARCHAR(60) NOT NULL,
    Apellidos VARCHAR(60) NOT NULL,
    Nacimiento VARCHAR(60) NOT NULL,
    Email VARCHAR(60) NOT NULL,
    Telefono VARCHAR(60) NOT NULL,
    Direccion VARCHAR(60) NOT NULL,
    DUI VARCHAR(60) NOT NULL,
    Contraseña VARCHAR(60) NOT NULL,
    ID INT NOT NULL,
	SEXO VARCHAR(30) NOT NULL,
    FOREIGN KEY (ID) REFERENCES Carrera(ID)
);

CREATE TABLE Inscripcion (
    CodigoMateria VARCHAR(6) NOT NULL,
    Usuario VARCHAR(10) NOT NULL,
    Estado VARCHAR(15) NOT NULL,
    FOREIGN KEY (CodigoMateria) REFERENCES Materias(Codigo),
    FOREIGN KEY (Usuario) REFERENCES Usuario(Usuario)
);



-- Insertar datos de prueba en la tabla Carrera
INSERT INTO Carrera (ID, Nombre, Tipo, Facultad) VALUES 
(1, 'Ingeniería en Sistemas', 'Ingeniería', 'Facultad de Ingeniería'),
(2, 'Licenciatura en Informática', 'Licenciatura', 'Facultad de Ciencias Naturales y Matemática'),
(3, 'Licenciatura en Diseño Gráfico', 'Licenciatura', 'Facultad de Artes'),
(4, 'Ingeniería en Telecomunicaciones', 'Ingeniería', 'Facultad de Ingeniería'),
(5,'Administradores','','');

-- Insertar datos de prueba en la tabla Materiaspta
INSERT INTO Materias (Codigo, Nombre, Lab, Grupo, ID, Requisito, UV, Inscritos) VALUES 
('MAT101', 'Matemática I', 0, '01', 1, NULL, 5, 30),
('MAT102', 'Matemática II', 0, '01', 1, 'MAT101', 5, 25),
('MAT201', 'Matemática III', 0, '01', 1, 'MAT102', 5, 20),
('MAT202', 'Matemática IV', 0, '01', 1, 'MAT201', 5, 15),
('INF101', 'Introducción a la Informática', 1, '01', 1, NULL, 3, 20),
('INF102', 'Programación I', 1, '01', 1, 'INF101', 5, 15),
('INF201', 'Programación II', 1, '01', 1, 'INF102', 5, 10),
('INF202', 'Programación III', 1, '01', 1, 'INF201', 5, 5),
('ISI101', 'Sistemas Operativos', 0, '01', 1, 'INF102', 4, 8),
('INF301', 'Programación Avanzada', 1, '01', 1, 'INF202', 5, 10),
('INF302', 'Bases de Datos', 1, '01', 1, 'INF201', 5, 20),

--Para diseño gráfico
('SCV101', 'Sistemas de Composicion Visual', 0, '01', 3, Null, 4, 23),
('ICI201', 'Investigacion, y Creatividad', 1, '01', 3, null, 4, 30),
('TEF202', 'Técnicas Fotográficas', 1, '01', 3, 'ICI201', 4, 25),
('TCV222', 'Técnicas de Composición Visual', 0, '01', 3, 'SV101', 4, 25),
('CTD302', 'Composición Tipográfica', 1, '01', 3, 'TCV222', 4, 25),
('DCC101', 'Dibujo y Composición I', 1, '01', 3, NULL, 3, 15),
('DCC202', 'Dibujo y Composición II', 1, '01', 3, 'DG101', 3, 18),
('DCC303', 'Dibujo y Composición III',1 ,'01',3, 'DC202', 3, 12),
--Para telecomunicaciones
('CAD101', 'Calculo Diferencial', 0, '01', 4, NULL, 5, 30),
('CAI102', 'Calculo Integral', 0, '01', 4, 'CAD101', 5, 25),
('EDI201', 'Ecuaciones Diferenciales', 0, '01', 4, 'CAI102', 5, 20),
('CAA202', 'Calculo Avanzado', 0, '01', 4, 'EDI201', 5, 15),
('ISI202', 'Sistemas Distribuidos', 1, '01', 4, 'ISI201', 4, 5),
('ISI201', 'Redes y Comunicaciones', 0, '01', 4, 'PAG102', 4, 10),
('FDE104', 'Fundamentos de la Electrónica', 0, '01',4, null, 4,30),
('PAG102', 'Programación de Algoritmos', 1, '01', 4, null, 5, 24),
('RAC201', 'Redes y Analisis de Circuitos', 1, '01', 4, 'PAG102', 5, 13),
--Para la licenciatura en sistemas
('PDD103', 'Programación Desarrollada I', 1, '01', 2, null, 5, 15),
('PDD203', 'Programación Desarrollada II', 1, '01', 2, 'INF103', 5, 15),
('PDD303', 'Programación Desarrollada III', 1, '01', 2, 'INF203', 5, 15),
('DWI102', 'Desarrollo Web Integrado I', 1, '01', 2, null, 5, 21),
('DWI202', 'Desarrollo Web Integrado II', 1, '01', 2, 'DWI102', 5, 23),
('COL103', 'Cooperación Laboral', 0, '01', 2, null, 3, 33),
('SSI201', 'Seguridad en Servidores', 0, '01', 2, 'INF203', 5, 18),
('ING101', 'Inglés', 0, '01', 2, null, 5, 33);
-- Insertar datos de prueba en la tabla Usuario

INSERT INTO Usuario (Usuario, Nombres, Apellidos, Nacimiento, Email, Telefono, Direccion, DUI, Contraseña, ID, SEXO) VALUES 
('JP220756', 'Juan', 'Pérez', '01/01/2000', 'juan.perez@example.com', '7777-7777', 'San Salvador', '12345678-9', 'contraseña1', 1,'Masculino'),
('MG220847', 'María', 'García', '01/01/2001', 'maria.garcia@example.com', '8888-8888', 'Santa Ana', '98765432-1', 'contraseña2', 2,'Femenino'),
('CL220453', 'Carlos', 'López', '01/01/1999', 'carlos.lopez@example.com', '9999-9999', 'San Miguel', '12345678-0', 'contraseña3', 1,'Masculino'),
('AM220483', 'Ana', 'Martínez', '01/01/2002', 'ana.martinez@example.com', '6666-6666', 'La Libertad', '99999999-9', 'contraseña4', 3,'Femenino'),
('123456', 'Rene', 'Castro', '01/01/2002', 'admin@example.com', '1111-1111', 'La Libertad', '99999999-8', 'rene123', 5,'Masculino'),
('1234567', 'Oscar', 'Navarro', '01/01/2002', 'admin@example.com', '2222-2222', 'Apopa', '99999999-7', 'oscar123', 5,'Masculino');

-- Insertar datos de prueba en la tabla Inscripcion
INSERT INTO Inscripcion (CodigoMateria, Usuario, Estado) VALUES 
('MAT101', 'JP220756', 'aprobada'),
('INF101', 'JP220756', 'aprobada'),
('INF102', 'JP220756', 'aprobada'),
('INF201', 'JP220756', 'inscrita');



---QUERRY PARA SABER QUE MATERIAS HA APROBADO UN ESTUDIANTE
SELECT Materias.Nombre, Materias.UV
FROM Inscripcion 
INNER JOIN Materias ON Inscripcion.CodigoMateria = Materias.Codigo
WHERE Inscripcion.Estado = 'aprobada' AND Inscripcion.Usuario = 'JP220756';





			


















use master
go
drop database Test


























	