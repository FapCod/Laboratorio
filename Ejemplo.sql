select * from Usuario
create procedure ActualizarUser(
 @idUsario varchar(15),
 @nombres varchar(50),
 @apellidos varchar(50),
 @tipousuario varchar(20),
 @clave char(50),
 @estado bit
)
as 
begin 
update  Usuario set  nombres=@nombres,apellidos=@apellidos,  tipousuario=@tipousuario, clave=@clave, estado=@estado
where idUsuario= @idUsario 
end 
go

drop procedure ActualizarUser

create procedure EliminarUser(
@idusuario varchar(20)
)
as 
begin 
delete  from Usuario where idUsuario=@idusuario
end 
go

create procedure BuscarUser(
@id varchar(30)
)
as
begin
select * from Usuario where idUsuario = @id
end 
go