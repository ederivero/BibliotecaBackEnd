--create database biblioteca;
use biblioteca;

create table tbPersona(
	dni int primary key not null,
	nombre varchar(30),
	apellidoPaterno varchar(30),
	apellidoMaterno varchar(30),
	direccion varchar(40),
	password varchar(15)
);

create table tbCliente(
	id int primary key not null identity(1,1),
	dni int constraint fkClientePersona foreign key references tbPersona(dni) not null
)

create table tbUsuario(
	id int primary key not null identity(1,1),
	dni int constraint fkUsuarioPersona foreign key references tbPersona(dni) not null
)

create table tbCategoria(
	id int primary key not null identity(1,1),
	descCategoria varchar(40) not null
)

create table tbLibro(
	id int primary key not null identity(1,1),
	nombre varchar(30) not null,
	autor varchar(80) not null,
	idCategoria int constraint fkCategoriaCategoria foreign key references tbCategoria(id) not null,
	estado bit not null
)

create table tbHistorico(
	id int primary key not null identity(1,1),
	idCliente int constraint fkHistoricoCliente foreign key references tbCliente(id) not null,
	idLibro int constraint fkHistoricoLibro foreign key references tbLibro(id) not null,
	fechaPrestamo date not null,
	fechaDevolucion date
)

--INSERT DE PERSONAS
insert into tbPersona values (25476982,'EDUARDO','DE RIVERO','MANRIQUE','CALLE SIEMPRE VIVA 324',null);
insert into tbPersona values (25896341,'JUAN','RODRIGUEZ','CACERES','AV BOLGONESI 114','3456');
insert into tbPersona values (59874162,'ROBERTO','VILLALBA','ZEGARRA','LEON VELARDE 104',null);
insert into tbPersona values (35741982,'LUIS','PRIETO','JUAREZ','AV PROGRESO 315',null);
insert into tbPersona values (65412387,'CHRISTOPHER','LOAYZA','DELGADO','AV EJERCITO 1114',null);
insert into tbPersona VALUES (35719646,'JAVIER','GARCIA','TOLEDO','SIMON BOLIVAR 113','');
insert into tbPersona VALUES (22648579,'ROCIO','MOSCOL','URETA','AV LOS ROSALES E-14',NULL);

--INSERT DE CLIENTES
insert into tbCliente values (25476982),(59874162),(35741982),(65412387);
insert into tbCliente values (35719646),(22648579);

--INSERT DE USUARIOS
insert into tbUsuario values (25896341);

--INSERT DE CATEGORIAS
insert into tbCategoria values ('SUSPENSO'),('TERROR'),('COMEDIA'),('FICCION'),('INFANTILES');

--INSERT DE LIBROS
insert into tbLibro values ('HARRY POTTER IV','J. K. ROWLING',4,1);
insert into tbLibro values ('CONVERSACION EN LA CATEDRAL','MARIO VARGAS LLOSA',1,1);
insert into tbLibro values ('NO ME ESPEREN EN ABRIL','ALFREDO BRYCE ECHENIQUE',2,1);
insert into tbLibro values ('LA VACA','CAMILO CRUZ',5,1);
insert into tbLibro values ('CONDORITO ED. 114','RENE RIOS',3,1);

select * from tbLibro