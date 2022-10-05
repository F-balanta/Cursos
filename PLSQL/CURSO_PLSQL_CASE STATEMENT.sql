                                                                                            -- CONDICIONAL CASE

/*
    Se pueden configurar varias condiciones a cumplir cuando configuramo un programa
    a diferencia del condicional if que solo tiene 2 salidas ... cuando es true o false
    
*/
-- funcion dia semana
create or replace function f_diasemana(numero int)
return varchar2

is 

    dia varchar2(25);
    begin
        dia := '';
        case numero
            when 1 then dia:= 'Lunes';
            when 2 then dia:= 'Martes';
            when 3 then dia:= 'Miercoles';
            when 4 then dia:= 'Jueves';
            when 5 then dia:= 'Viernes';
            when 6 then dia:= 'Sabado';
            when 7 then dia:= 'Domingo';
            else dia := 'NO ES UN NUMERO CORRECTO';
        end case;
    return dia;
end;

-- Siempre se debe de seleccionar de donde sacará los datos con el FROM
select f_diasemana(11) as "Dia de la semana" from dual;







create or replace function f_trimestre(fecha date)
return varchar2
is
    mes varchar2(20);
    trimestre number;
    begin
        mes := extract(month from fecha);
        trimestre := 0;
        case mes
            when 1 then trimestre:=1;
            when 2 then trimestre:=1;
            when 3 then trimestre:=1;
            when 4 then trimestre:=2;
            when 5 then trimestre:=2;
            when 6 then trimestre:=2;
            when 7 then trimestre:=3;
            when 8 then trimestre:=3;
            when 9 then trimestre:=3;
            else trimestre :=4;
        end case;
    return trimestre;
end;


select f_trimestre(to_date('07/01/2021', 'dd/mm/yyyy')) as FechaTrismestre from dual;
