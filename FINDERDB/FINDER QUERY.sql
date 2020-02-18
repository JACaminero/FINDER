CREATE TABLE Usuario(
ID_Usuario INT CONSTRAINT PKUsuario PRIMARY KEY IDENTITY,
nombre VARCHAR(60) NOT NULL,
fechaNacimiento DATE,
bio NVARCHAR(500),
localizacion varchar(500),
patrimonio DECIMAL(16,4),
genero CHAR(1) CONSTRAINT CKGenero CHECK (genero = 'M' OR genero = 'F'),
foto VARBINARY(MAX)
)

CREATE TABLE Swipe(
ID_Interesado INT CONSTRAINT FKUsuarioInteresado FOREIGN KEY REFERENCES Usuario(ID_Usuario),
ID_Pareja INT CONSTRAINT FKUsuarioPareja FOREIGN KEY REFERENCES Usuario(ID_Usuario),
CONSTRAINT PKSwipe PRIMARY KEY(ID_Interesado, ID_Pareja),
meGusta BIT,
)