DECLARE
    -- Se declaran 2 variables enteras
    a number(2) :=10; 
    b number(2) :=20;
BEGIN
    IF a > b then -- si la sentencia es verdadera(condicion) se ejecutará la siguiente linea de codigo
        dbms_output.put_line(a || ' es mayor que: ' || b);
    ELSE
        dbms_output.put_line(b || ' es mayor que: ' || a);
    END IF;
    
END;