DECLARE
    numero number(3) :=100;
BEGIN
    if (numero = 10) then
        dbms_output.put_line('El valor del numero es de 10.');
    elsif (numero = 20) then
        dbms_output.put_line('El valor del numero es de 20.');
    elsif (numero = 30) then
        dbms_output.put_line('El valor del numero es de 30.');
    else
        dbms_output.put_line('Ninguno de los valores fué encontrado.');
    end if;
    
END;