use HID

select * from TTipoIVA

select * from TRecursos

--
--  Categoria de los articulos
--
select * from TCategorias

select * from TArticulos

select * from TCategoriaRecurso

select * from TTipoIVA


/*
    Agrego algunas constraints que hacen falta para establecer las relaciones en E-F
*/
alter table TRecursos 
  add constraint FK_TRecursos_TCategoriaRecurso foreign key (IdCategoria) references TCategoriaRecurso 


alter table TRecursos 
  add constraint FK_TRecursos_TTipoIVA foreign key (IdTipoIVA) references TTipoIVA(IdTipoIVA)


/*
    Boludeces: actualizo los tipos de situacion AFIP
*/
update TTipoIVA set DescripcionIVA = 'Responsable Monotributo' where IdTipoIVA=1

insert into TTipoIVA values ('Exento')
insert into TTipoIVA values ('Consumidor Final')

/*
    Agrego un nuevo tipo de recurso para poder crear Recursos y Usuarios
*/
set identity_insert TCategoriaRecurso on

insert into TCategoriaRecurso values (11, 'Proveedor Informatica')

set identity_insert TCategoriaRecurso off


--
--  Recursos...
--
set identity_insert TRecursos on

insert into TRecursos (IdRecursos, Apellido, Nombre, FechaNacimiento, IdCategoria, IdTipoIVA) 
  values (18, 'Samá', 'Sergio Norberto', '12/09/1967', 11, 1)

insert into TRecursos (IdRecursos, Apellido, Nombre, FechaNacimiento, IdCategoria, IdTipoIVA) 
  values (19, 'Thedy', 'Enrique', '10/04/1967', 11, 1)

set identity_insert TRecursos off


/*
    USUARIOS


*/

create table tUsuarios 
(
  Login                   varchar(20)         not null,     --  identificador con el que accede el usuario al sistema
  Password                varchar(100),                     --  pass en base64 con SHA-256
  IdRecurso               int                 not null,     --  Recurso asociado al Usuario
  FechaExpiracionPass     smalldatetime,                    --  null => no expira
  FechaLastLogin          smalldatetime,
  MustChangePass          bit                 not null      default(1),   --  por defecto cualquier nuevo usuario debe cambiar la password
  EnforceExpiration       bit                 not null      default(1),   --  por defecto debe forzarse la expiracion de la password
  EnforceStrong           bit                 not null      default(1),   --  por default se fuerza a que la pass sea complicada
  constraint PK_tUsuarios primary key nonclustered (Login),
  constraint FK_tUsuarios_tRecursos foreign key (IdRecurso) references TRecursos(IdRecursos)
)

--
----
------

select * from tUsuarios

--  password es viterilove

insert into tUsuarios (Login, Password, IdRecurso, MustChangePass, EnforceExpiration, EnforceStrong)
values ('ssama', '6nDaANLlLtb68GkKXhdlkeJc5z7b6j29QE2eoi/t9HY=', 18, 0, 0, 0)

insert into tUsuarios (Login, Password, IdRecurso, MustChangePass, EnforceExpiration, EnforceStrong)
values ('ethedy', '6nDaANLlLtb68GkKXhdlkeJc5z7b6j29QE2eoi/t9HY=', 19, 0, 0, 0)

go;

--  'xp13fK4682vtgY8QzfCkCVbUKr7ZOJ5jnwono8v5FXU='    --hid@1234

insert into tUsuarios (Login, Password, IdRecurso, MustChangePass, EnforceExpiration, EnforceStrong)
values ('mjscoponi', 'xp13fK4682vtgY8QzfCkCVbUKr7ZOJ5jnwono8v5FXU=', 13, 1, 1, 1)

update tUsuarios set Password='xp13fK4682vtgY8QzfCkCVbUKr7ZOJ5jnwono8v5FXU=' where Login='mjscoponi'

insert into tUsuarios (Login, Password, IdRecurso, MustChangePass, EnforceExpiration, EnforceStrong)
values ('lquilici', 'xp13fK4682vtgY8QzfCkCVbUKr7ZOJ5jnwono8v5FXU=', 6, 1, 1, 1)



/*
  Aggrego el campo Imagen para los articulos - Turco: 24/08
*/

alter table dbo.TArticulos add Imagen varbinary(max)

/*
  Cambio en TArticulos para que los Proveedores residan en la tabla TRecursos
*/
exec sp_rename 'TArticulos.IdProveedor', 'IdRecursos', 'COLUMN'
exec sp_rename 'TArticulos.IdRecursos', 'IdRecurso', 'COLUMN'

/*
  Cambios en TRent 
*/
alter table TRent
add constraint FK_TRent_TArticulos foreign key (IdArticulo) references TArticulos (IdArticulo)

/*
  Pequeño cambio de nombre en la tabla de Pacientes
*/
exec sp_rename 'TPacientes.IdPacientes', 'IdPaciente', 'COLUMN'

/*
  Pequeño cambio de nombre en la tabla de Recursos
*/
exec sp_rename 'TRecursos.IdRecursos', 'IdRecurso', 'COLUMN'

/*
  Pequeño cambio de nombre en la tabla de Ordenes
*/
exec sp_rename 'TOrdenes.IdPacientes', 'IdPaciente', 'COLUMN'

/*
  Cambios en la tabla TOrdenes
*/  
alter table TOrdenes drop constraint FK_TOrdenes_TArticulos 

alter table TOrdenes  
add constraint FK_TOrdenes_TArticulos foreign key (IdArticulo) references TArticulos (IdArticulo)

alter table TOrdenes drop constraint FK_TOrdenes_TPacientes 

alter table TOrdenes  
add constraint FK_TOrdenes_TPacientes foreign key (IdPaciente) references TPacientes (IdPaciente)

alter table TOrdenes drop constraint FK_TOrdenes_TRecursos 

alter table TOrdenes  
add constraint FK_TOrdenes_TRecursos foreign key (IdRecurso) references TRecursos (IdRecurso)

/*
    Cambios en la tabla TArticulos
*/
alter table TArticulos drop constraint FK_TArticulos_TCategoria 

alter table TArticulos
add constraint FK_TArticulos_TCategoria foreign key (IdCategoria) references TCategorias (IdCategoria)

alter table TArticulos drop constraint FK_TArticulos_TTipoArticulos

alter table TArticulos
add constraint FK_TArticulos_TTipoArticulos foreign key (IdTipoArticulo) references TTipoArticulos (IdTipoArticulo)

alter table TArticulos
add constraint FK_TArticulos_TRecursos foreign key (IdRecurso) references TRecursos (IdRecurso)

/*
    Cambios en la tabla TProvincias
*/

alter table TProvincias
add constraint PK_TProvincias primary key (IdCodProv)

/*
    Cambios en la tabla TLocalidad
*/
execute sp_rename 'TLocalidad', 'TLocalidades'

alter table TLocalidades
add constraint PK_TLocalidades primary key (IdCodLoc)

alter table TLocalidades
add constraint FK_TLocalidad_TProvincias foreign key (IdCodProv) references TProvincias (IdCodProv)

go

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

use HID
go


create schema SEGU authorization dbo
go

create procedure SEGU.ValidarUsuarioPassword @user varchar(20), @pass varchar(100) 
as begin
  if exists( select * from tUsuarios where Login=@user and Password=@pass )
    select convert(int, 1)
  else
    select convert(int, 0)
end

--
--    PRUEBAS
--
execute SEGU.ValidarUsuarioPassword 'ethedy', '6nDaANLlLtb68GkKXhdlkeJc5z7b6j29QE2eoi/t9HY='  --  viterilove

execute SEGU.ValidarUsuarioPassword 'ethedy', 'xp13fK4682vtgY8QzfCkCVbUKr7ZOJ5jnwono8v5FXU='  -- hid@1234

execute SEGU.ValidarUsuarioPassword 'mjscoponi', 'xp13fK4682vtgY8QzfCkCVbUKr7ZOJ5jnwono8v5FXU='

execute SEGU.ValidarUsuarioPassword 'mjscoponi', '6nDaANLlLtb68GkKXhdlkeJc5z7b6j29QE2eoi/t9HY='

go

/*
    Utilizo el procedimiento de validacion para comprobar si la pass fue correctamente seteada
*/
create procedure SEGU.SetearPassword @user varchar(20), @pass varchar(100) 
as begin
  update tUsuarios set Password = @pass where Login=@user

  execute SEGU.ValidarUsuarioPassword @user, @pass
end

--
------

--
--    PRUEBAS
--

execute SEGU.SetearPassword 'ethedy', 'xp13fK4682vtgY8QzfCkCVbUKr7ZOJ5jnwono8v5FXU='

execute SEGU.SetearPassword 'ethedy', '6nDaANLlLtb68GkKXhdlkeJc5z7b6j29QE2eoi/t9HY='      --  ASI TIENE QUE QUEDAR

go

/*

  AUDITORIA

*/

create schema AUDIT authorization dbo 
go

create table AUDIT.tAuditoria (
  IdAuditoria       int             identity        not null,
  Fecha             smalldatetime                   not null,      --  será la hora local del equipo de usuario
  HostName          nvarchar(128)                   not null default host_name(),    --  el nombre del equipo del cliente
  Origen            varchar(300)                    not null,
  Tipo              int                             not null,
  Detalles          varchar(max),
  constraint PK_tAuditoria primary key (IdAuditoria)
)

select * from AUDIT.tAuditoria order by Fecha desc

--------------------------
--------------------------    TURKO 05/09/2014
--------------------------

use HID

alter table TArticulos
drop constraint FK_TArticulos_TCategoria


drop table TCategorias

exec sp_rename 'TCtaCteRecursos.IdRecursos', 'IdRecurso', 'COLUMN'

alter table TCtaCteRecursos  
add constraint FK_TCtaCteRecursos_TRecursos foreign key (IdRecurso) references TRecursos (IdRecurso)

---------------------------------------
---------------------------------------   ET 14/09/14
---------------------------------------

--  Agrego el campo habilitado a la tabla de usuarios para poder quitar un usuario facilmente sin necesidad de borrarlo
--  
alter table tUsuarios
  add Enabled bit not null default(1)

--  Agrego el campo bloqueado para indicar si el usuario no se puede loguear temporalmente porque tuvo accesos incorrectos
--
alter table tUsuarios
  add Blocked bit not null default(0)

alter table tRecursos
  add Sexo char(1) 

alter table tRecursos
  drop column Clave


select * from TCategoriaRecurso

update TCategoriaRecurso
  set Detalle = 'sysadmin'
  where IdCategoria = 11


update TRecursos
  set IdCategoria = 8 
where IdRecurso = 6

update TRecursos
  set IdCategoria = 10
where IdRecurso = 13


---------------------------------------
---------------------------------------
---------------------------------------

--
--  Tabla de Perfiles que luego asocio a los usuarios para permitir diferentes accesos
--
create table tPermisos
(
  IdPermiso           int             not null      identity primary key,
  Permiso             varchar(50)     not null,
  Descripcion         varchar(500),
  constraint UK_TPermisos unique (Permiso)
)

--

insert into tPermisos values ('UserAdmin', 'Permite acceder a la administracion de usuarios, dar altas, modificar o bloquear')
insert into tPermisos values ('SysAdmin', 'Todas las opciones del sistema estan permitidas (incluso las ocultas)')
insert into tPermisos values ('StockAdmin', 'Permite acceso total a opciones de ingreso, egreso, etc del stock de insumos')
insert into tPermisos values ('OrtopAdmin', 'Permite acceso total a opciones de ingreso, egreso, etc del stock de alquilables')

insert into tPermisos values ('', '')

--
--  Tabla para resolver la relacion n x m entre usuarios y permisos
--
create table tUsuarios_Permisos
(
  Login             varchar(20)     not null,
  IdPermiso         int             not null,
  constraint PK_tUsuarios_Permisos primary key (Login, IdPermiso),
  constraint FK_tUsuarios_Permisos_tUsuarios foreign key (Login) references tUsuarios(Login),
  constraint FK_tUsuarios_Permisos_tPermisos foreign key (IdPermiso) references tPermisos(IdPermiso)
)

---

select Foto, * from TRecursos

select * from tUsuarios

select * from TCategoriaRecurso

select * from AUDIT.tAuditoria order by Fecha desc


--
--	  Tabla de Proveedores
--	  ET - 28/10/2014
--
--  CUIT deberia ser unique...
--

create table TProveedores
(
  IdProveedor                 int               identity    not null,
  Nombre                      varchar(150)      not null,
  Direccion                   varchar(200),
  CUIT                        varchar(20)       not null,   --  colocar DNI en caso de no contar con CUIT
  Habilitado                  bit               not null default(1),  --  no borrar proveedores, inhabilitarlos!!
  constraint PK_TProveedores primary key (IdProveedor)
)

insert into TProveedores values ('La casa del Perno', 'Casiano Casas 234 bis', '30-12122122-8', default)

insert into TProveedores values ('El Arte Bolivariano', 'Chavez y Fidel', '99-21555777-X', default)

select * from TProveedores

select * from AUDIT.tAuditoria order by Fecha desc






