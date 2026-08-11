
--Creacion tabla Usuarios
CREATE TABLE Usuarios(
	UsuarioId INT IDENTITY(1,1) NOT NULL,
	NombreUsuario NVARCHAR(50) NOT NULL,
	Email NVARCHAR(255) NOT NULL,
	ContrasenaHash VARBINARY(256) NOT NULL,
	Nombre NVARCHAR(100) NOT NULL,
	Apellido NVARCHAR(100) NOT NULL,
	Activo BIT DEFAULT 1,
	FechaRegistro DATETIME DEFAULT GETDATE(),
	UltimoLogin DATETIME NULL
);

--Constraints de tabla Usuarios

ALTER TABLE Usuarios
 ADD CONSTRAINT PK_Usuarios_UsuarioId
  PRIMARY KEY (UsuarioId);

ALTER TABLE Usuarios
 ADD CONSTRAINT UQ_Usuarios_NombreUsuario
  UNIQUE (NombreUsuario);

ALTER TABLE Usuarios
 ADD CONSTRAINT UQ_Usuarios_Email
  UNIQUE (Email);

ALTER TABLE Usuarios
 ADD CONSTRAINT CK_Usuarios_Activo CHECK (Activo IN(0,1));

GO

--Creación tabla Roles
CREATE TABLE Roles(
	RolId INT IDENTITY(1,1) NOT NULL,
	NombreRol NVARCHAR(50) NOT NULL,
	Descripcion NVARCHAR(255) NULL
);

--Constraints tabla Roles

ALTER TABLE Roles
 ADD CONSTRAINT PK_Roles_RolId 
  PRIMARY KEY (RolId);

ALTER TABLE Roles
 ADD CONSTRAINT UQ_Roles_NombreRol 
  UNIQUE(NombreRol);

GO

--Creación tabla UsuariosRoles
CREATE TABLE UsuariosRoles(
	UsuarioId INT NOT NULL,
	RolId INT NOT NULL
);

--Constraints tabla UsuariosRoles

ALTER TABLE UsuariosRoles
 ADD CONSTRAINT PK_UsuariosRoles_UsuarioIdRolId
  PRIMARY KEY (UsuarioId,RolId);

--Foreign keys entre Usuarios y Roles
ALTER TABLE UsuariosRoles
 ADD CONSTRAINT FK_UsuariosRoles_UsuarioId
  FOREIGN KEY (UsuarioId) REFERENCES Usuarios(UsuarioId);

ALTER TABLE UsuariosRoles
 ADD CONSTRAINT FK_UsuariosRoles_RolId
  FOREIGN KEY (RolId) REFERENCES Roles(RolId);


