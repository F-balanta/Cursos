--                                                  2. Declarar una variable numerica y mostrar si es mayor de 10 o no.

set serveroutput on;

declare
    numero number;

begin
    numero:= 5;

    if numero > 10 then
        dbms_output.put_line(numero ||' es mayor a 10');
    else
        dbms_output.put_line(numero ||' es menor a 10');
    end if;
end;