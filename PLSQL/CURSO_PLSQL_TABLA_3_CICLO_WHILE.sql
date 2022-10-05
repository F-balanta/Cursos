SET SERVEROUTPUT ON

DECLARE
    numero number:=0;
    resultado number;

BEGIN
    while numero <= 10
        loop
            resultado := 3 * numero;
            dbms_output.put_line('3X ' ||numero|| ' = ' || resultado);  
            numero := numero +1;
        end loop;
END;