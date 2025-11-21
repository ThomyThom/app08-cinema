create DataBase SolucaoCinema
go
 
use SolucaoCinema; 
go
 
CREATE TABLE Usuario (
    idUsuario INT    IDENTITY (1, 1) NOT NULL,
    Usuario VARCHAR (10) NOT NULL,
    Senha VARCHAR (10)
 
    PRIMARY KEY CLUSTERED (idUsuario ASC)
);
Go

Insert into Usuario (Usuario , Senha) values ('Thomaz' , '123');

select * from Usuario;

CREATE TABLE Genero (
    idGenero INT    IDENTITY (1, 1) NOT NULL,
    dsGenero VARCHAR (20) NOT NULL,    
 
    PRIMARY KEY CLUSTERED (idGenero ASC)
);
Go

Insert into Genero (dsGenero) values ('Ação');

select * from Genero;

CREATE TABLE Cinema (
    idCinema INT    IDENTITY (1, 1) NOT NULL,
    nmCinema VARCHAR (30) NOT NULL,    
	dsEndereco VARCHAR (150) NOT NULL,  	
	nrSalas INT NOT NULL,  
    PRIMARY KEY CLUSTERED (idCinema ASC)
);
Go

Insert into Cinema (nmCinema, dsEndereco, nrSalas) values ('Cinemark Grand Plaza Shopping', 'Av. Industrial, 600', '10');

select * from Cinema;

CREATE TABLE Sala (
    idSala INT    IDENTITY (1, 1) NOT NULL,
	nrSala   INT NOT NULL, 
    nrPoltronas   INT NOT NULL,    
	tpSala        char(10) NOT NULL, 
	idCinema      INT NOT NULL
 
    PRIMARY KEY CLUSTERED (idSala ASC)
);
Go

select * from Sala;