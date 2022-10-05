set SERVEROUTPUT on;

declare
    saludo2 varchar2(30) := '####Hola a todos####';

begin
    --Corta todos los caracteres que se indiquen del lado derecho de la cadena
    dbms_output.put_line(RTRIM(saludo2, '#'));
    
    --Corta todos los caracteres especificado del lado izqiuerdo de la cadena
    dbms_output.put_line(LTRIM(saludo2, '#'));
    
    --QUeta todos los caracteres especificados
    dbms_output.put_line(TRIM('#' from saludo2));
    

end;
