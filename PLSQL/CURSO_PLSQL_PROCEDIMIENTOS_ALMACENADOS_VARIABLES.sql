-- Variables dentro de Procedimientos
set serveroutput on;

-- Crea o remplaza un porocedimiento que se llamará autorlibro, con un parametro de entrada que se va a llamar atitulo
create or replace procedure autorlibro(atitulo in varchar2)
as
-- crea una variable v_autor

    v_autor varchar2(20);
    begin
        -- selecciona el campo autor e introduce dentro de la variable el valor seleccionado
        select autor into v_autor from libros where titulo=atitulo;
        --va a insertar dentro de la tabla1 el titulo y el precio en donde el autor coincida con el parametro de entrada;
        insert into tabla1
        select titulo,precio from libros
        where autor = v_autor;
end autorlibro;
        

execute autorlibro('El alquimista');

drop table libros;