declare
-- las constantes no cambian, definen oslamente un valor unico y no es posible cambiarlas
    mensaje CONSTANT varchar2(30) :='buenos dias a todos';
    numero CONSTANT number(6):=30000;
begin
    mensaje := 'adios a todos';
    dbms_output.put_line(mensaje);
    dbms_output.put_line(numero);

end;