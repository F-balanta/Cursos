set SERVEROUTPUT on;
--FUNCIONES ---STRING PL SQL

declare
    saludo VARCHAR2(12):= 'hola a todos';
    
begin
    -- convierte a mayusculas
    dbms_output.put_line(UPPER(saludo));
    
    -- convierte en minusculas
    dbms_output.put_line(LOWER(saludo));
    
    --Coloca en mayusculas cada letra inicial de cada palabra
    dbms_output.put_line(INITCAP(saludo));
    
    -- Muestra un valor a partir de que hay
    dbms_output.put_line(SUBSTR(saludo,7,4));
    
    --Busca en que posicion se encuentra un caracter
    dbms_output.put_line(INSTR(saludo,'o'));
    
end;