set serveroutput on;

declare
    
    type matriz_nombres is varray(5) of varchar2(20);
    type matriz_edad is varray(5) of integer;
    
    nombres matriz_nombres;
    edad matriz_edad;
    total integer;
begin

    nombres := matriz_nombres('Jose','Antonio','Marta','Juan','Maria');
    edad := matriz_edad(28,35,41,22,36);
    total := nombres.count;
    
    for contador in 1..total loop
        dbms_output.put_line('Nombre: ' || nombres(contador) || ' Edad: ' || edad(contador));
    end loop;

end;
    