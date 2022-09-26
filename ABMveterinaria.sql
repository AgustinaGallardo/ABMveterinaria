create database ABMveterinaria
go
use ABMveterinaria
go

create table tipos
(tipo int,
nombre varchar(40)
constraint tipos_pk primary key (tipo)
)

create table clientes
( cod_cliente int identity(1,1),
nombre varchar(20),
apellido varchar(20),
dni int
constraint cliente_pk primary key (cod_cliente)
)


create table atenciones
(cod_atencion int identity(1,1),
descripcion varchar(100),
fecha datetime,
importe decimal(10,2)
constraint atenciones_pk primary key(cod_atencion)
)


create table mascotas
(cod_mascota int identity(1,1),
cod_cliente int,
cod_atencion int,
nombre varchar(20),
edad int,
tipo int,
constraint mascotas_pk primary key (cod_mascota),
constraint mascotas_tipos foreign key (tipo)
references tipos (tipo),
constraint mascotas_clientes foreign key (cod_cliente)
references clientes(cod_cliente),
constraint mascotas_atenciones foreign key (cod_atencion)
references atenciones(cod_atencion)
)



insert into tipos values(1,'perro')
insert into tipos values(2,'gato')
insert into tipos values(3,'araña')
insert into tipos values(4,'iguana')

insert into clientes (nombre, apellido,dni) values('robert','garden',34601166)
insert into clientes values('marta','famosa',23456734)
insert into clientes values('corre','caminos',3456768)
insert into clientes values('camila','cantos',2344567)
insert into clientes values('ruperta','fernandez',23456798)
insert into clientes values('herminia','garcia',65489877)
insert into clientes values('lucio','del valle',36251485)
insert into clientes values('fantasma','canterville',63521402)
insert into clientes values('claudio','castro',33020104)
insert into clientes values('elvis','presley',32353645)
insert into clientes values('snoop','dug',12546598)
insert into clientes values('frank','miller',65984512)
insert into clientes values('nora','jones',12324565)
insert into clientes values('alicia','keys',25020141)
insert into clientes values('jose','kleiner',38020114)

insert into mascotas (nombre, edad,tipo,cod_cliente,cod_atencion) values('pepe',4,1,1,1)
insert into mascotas (nombre, edad,tipo,cod_cliente,cod_atencion) values('michi',2,2,2,2)
insert into mascotas (nombre, edad,tipo,cod_cliente,cod_atencion) values('arañit',3,3,3,3)
insert into mascotas (nombre, edad,tipo,cod_cliente,cod_atencion) values('peshi',1,1,4,4)
insert into mascotas (nombre, edad,tipo,cod_cliente,cod_atencion) values('gatuno',2,2,5,5)
insert into mascotas (nombre, edad,tipo,cod_cliente,cod_atencion) values('don',2,2,6,6)
insert into mascotas (nombre, edad,tipo,cod_cliente,cod_atencion) values('iguanit',4,4,7,7)



insert into atenciones (descripcion,fecha,importe) 
values('vacunacion','5/7/2022',100.7)
insert into atenciones (descripcion,fecha,importe)  
values('fractura por choque','5/6/2022',9500)
insert into atenciones (descripcion,fecha,importe)  
values('vacunacion','3/3/2022',1000)
insert into atenciones (descripcion,fecha,importe) 
values('vacunacion','15/1/2021',1000)
insert into atenciones  (descripcion,fecha,importe) 
values('control anual','9/3/2022',1500)
insert into atenciones (descripcion,fecha,importe)  
values('fractura por choque','15/4/2022',1000)
insert into atenciones  (descripcion,fecha,importe) 
values('control anual','11/8/2022',1500)
insert into atenciones (descripcion,fecha,importe)  
values('desparacitacion','6/7/2022',1000)

--------------
 create procedure sp_combo
 as
 begin
 select * 
 from tipos
 execute sp_combo
 end
--------------------------------
create procedure Proximo_mascota
@next int output
as
begin
set @next = (select max(cod_mascota)+1 from mascotas);
end

----------------------------------

--INSERT

create procedure sp_insertDGV1
@apellidoCliente varchar(20),
@nombrecliente varchar(20),
@dni int,
@nombreMascota varchar(20),
@edad int,
@tipo int,
@descripcion varchar(100),
@fecha datetime,
@importe decimal(10,2)
as
begin
declare @codCliente int
declare @codMascota int
insert into clientes(apellido,nombre,dni) 
	values (@apellidoCliente,@nombreCliente,@dni)
set @codCliente = (select cod_cliente 
	from clientes 
	where dni=@dni )
insert into mascotas (nombre,edad,tipo,cod_cliente)
	values (@nombreMascota,@edad,@tipo,@codCliente)
set @codMascota = (select cod_mascota 
	from mascotas 
	where cod_cliente=@codCliente) 
insert into atenciones (descripcion,fecha,importe,cod_mascota) 
	values (@descripcion,@fecha,@importe,@codMascota)
end


