set SERVEROUTPUT on

begin 
    -- recorre en reversa
    for f in REVERSE 0..5 loop -- los valores se guardaran en la variable f (no está declarada)
        dbms_output.put_line('Valor de f = ' || f);
    end loop;
    dbms_output.put_line('');
    -- tabla de multiplicar
    dbms_output.put_line('Tabla de multiplicar');
    for c in 1..10 loop
       dbms_output.put_line('2X ' || c ||'  =  '|| (c*2));
       
       
    end loop;

end;