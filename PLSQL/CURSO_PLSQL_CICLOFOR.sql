-- CICLO FOR 
/* Ejecuta la sentencia un numero especifico de veces*/

DECLARE

    numero number(2);

BEGIN
    for numero in 10..20 loop 
        dbms_output.put_line('valor de numero: ' || numero);
    end loop;

END;
