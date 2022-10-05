-- habilita la salida de mensajes por consola
SET SERVEROUTPUT ON
-- CICLO WHILE -- Ejecuta una sentencia siempre que una condicion sea verdadera

--bloque
declare 

    valor number(2):=10;

begin

    while valor <= 20
        loop -- inicia el bucle
            dbms_output.put_line('El valor es: '|| valor);
            valor := valor +1;
        end loop;
end;