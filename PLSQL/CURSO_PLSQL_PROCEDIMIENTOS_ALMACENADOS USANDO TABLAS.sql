create table libros(
IDLIBRO integer primary Key,
TITULO varchar2(50),
AUTOR varchar2(50),
PRECIO float(4));

drop table libros;

select * from libros;
describe libros;
insert into libros (idlibro,titulo,autor,precio) values(1,'El quijote', 'Miguel de Cervantes', 454.5);
insert into libros (idlibro,titulo,autor,precio) values(2,'Cien años de soledad', 'Gabriel G. Marquez', 545.4);
insert into libros (idlibro,titulo,autor,precio) values(3,'El alquimista', 'Paulo Coehlo', 636.3);





create or replace procedure aumenta_precio
as
    begin
        update libros set precio = precio + (precio * .01);
    end aumenta_precio;
    execute aumenta_precio;
select * from libros;