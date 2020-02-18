--CREATE TABLE Usuario(
--ID_Usuario INT CONSTRAINT PKUsuario PRIMARY KEY IDENTITY,
--nombre VARCHAR(60) NOT NULL,
--fechaNacimiento DATE,
--bio NVARCHAR(500),
--localizacion varchar(500),
--patrimonio DECIMAL(16,4),
--foto VARBINARY(MAX),
--ID_Sexo INT CONSTRAINT FKUsuarioSexo FOREIGN KEY REFERENCES Sexo(ID_Sexo),
--ID_Atraccion INT CONSTRAINT FKUsuarioAtraccion FOREIGN KEY REFERENCES Atraccion(ID_Atraccion),
--)

--CREATE TABLE Swipe(
--ID_Interesado INT CONSTRAINT FKUsuarioInteresado FOREIGN KEY REFERENCES Usuario(ID_Usuario),
--ID_Pareja INT CONSTRAINT FKUsuarioPareja FOREIGN KEY REFERENCES Usuario(ID_Usuario),
--CONSTRAINT PKSwipe PRIMARY KEY(ID_Interesado, ID_Pareja),
--meGusta BIT,
--SuperLike BIT
--)

--CREATE TABLE Sexo(
--ID_Sexo INT CONSTRAINT PKSexo PRIMARY KEY IDENTITY,
--nombreSexo VARCHAR(15)
--)

--CREATE TABLE Atraccion(
--ID_Atraccion INT CONSTRAINT PKAtraccion PRIMARY KEY IDENTITY,
--atraccion VARCHAR(25)
--)

--CREATE TABLE Fetiche(
--ID_Fetiche INT CONSTRAINT PKFetiche PRIMARY KEY IDENTITY,
--nombreFetiche VARCHAR(25)
--)

--CREATE TABLE Perversion(
--ID_Usuario INT CONSTRAINT FKPerversionUsuario FOREIGN KEY REFERENCES Usuario(ID_Usuario),
--ID_Fetiche INT CONSTRAINT FKPerversionFetiche FOREIGN KEY REFERENCES Fetiche(ID_Fetiche),
--nivelConsentimiento INT CONSTRAINT CKnivelConsentimiento 
--	CHECK (nivelConsentimiento = 'Alto' OR nivelConsentimiento = 'Medio' OR nivelConsentimiento = 'Bajo')
--)


--INSERT INTO Atraccion VALUES ('Gay'), ('Heterosexual'), ('Lesbiana')
--INSERT INTO Fetiche VALUES ('BDSM'), ('No Consensual'), ('Interracial'), ('Maduro'), ('Multiples Parejas')

