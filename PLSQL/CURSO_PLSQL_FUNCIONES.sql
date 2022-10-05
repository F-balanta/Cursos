-- Funciones como objetos de PL SQL
-- DATO IMPORTANTE POR CONVENCION DEPENDIENDO DEL PROGRAMA SE NOMBRAN
--function => f_prueba
-- SP => sp_prueba

-- Crea o remplaza si ya existe una funcion que se va a llamar  f_prueba
create or replace function f_prueba(valor number)
-- funcion que retornara un numero
return number
-- esta instruccion significa que pasaremos a la ejecucion del programa
is
    -- zona de ejecucion
    begin
    -- Multiplicara el valor ingresado por 2 y lo devolvera
        return valor * 2;
    end;

                    -- QUe paso?
-- A traves de un SELECT  se invocó la funcion f_prueba pasandole como parametro un dato entero
-- Luego el resultado se guardará en una campo llamado total.
-- Y se le agrega la palabra from sual ya que no hay alguna tabla que este siendo manejada por la funcion
select f_prueba(2) as total from dual;





--                                                  FUNCION QUE DEFINE CARACTERISTICAS DE PRECIOS DE LA TABLA LIBROS

create or replace function f_costo(valor number)
    return varchar
is
    costo varchar2(20);
    begin
        costo := '';
        if valor <= 500 then
            costo := 'economico';
        else costo := 'costoso';
        end if;
    return costo;
end;

select titulo,autor,precio,f_costo(precio) as "Costo"from libros;