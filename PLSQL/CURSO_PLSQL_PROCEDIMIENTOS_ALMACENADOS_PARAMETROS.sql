--borrar tabla empelados anterior
 drop table empleados;
 
 --crear nueva tabla empleados
 create table empleados(
  documento char(8),
  nombre varchar2(20),
  apellido varchar2(20),
  sueldo number(6,2),
  fechaingreso date);

 --ingreso de datos
 insert into empleados values('22222222','Juan','Perez',300,to_date('10/10/1980','dd/mm/yyyy'));
 insert into empleados values('22333333','Luis','Lopez',300,to_date('12/05/1998','dd/mm/yyyy'));
 insert into empleados values('22444444','Marta','Perez',500,to_date('25/08/1990','dd/mm/yyyy'));
 insert into empleados values('22555555','Susana','Garcia',400,to_date('05/05/2000','dd/mm/yyyy'));
 insert into empleados values('22666666','Jose Maria','Morales',400,to_date('24/10/2005','dd/mm/yyyy'));
 
 
 select * from empleados;
 
 /*CREAR PROCEDIMIENTO ALMACENADO PARA PODER AUMENTAR EL SUELDO A LOS EMPLEADOS*/
 -- Crea o remplaza un procedimiento que se llamará aumentasueldo que recibe 2 parametros
 -- anio y porcentaje... la palabra in significa que sera un parametro de entrada y el tipo de dato que va a trabajar
 create or replace procedure aumentasueldo(anio in number, porcentaje in number)
 -- pasamos a nuestra sesion de ejecucion
 as
    begin
    -- Realizará una actualizacion en la tabla empleados 
    -- en la que actualizará el sueldo de los empleados que se encuentran en la base de datos
        update empleados set sueldo = sueldo +(sueldo*porcentaje/100)
    -- En donde  restará el año de la fecha actual  menos  el campo fechaingreso de la tabla y verifica que la resta se ma mayor que anio(parametro)
        where (extract(year from current_date)-extract(year from fechaingreso))>anio;
        end aumentasueldo;
 
-- Cuando los procedimientos almacenados tienen parametros de entrada hay que indicarles en la ejecucion los datos
-- Aumentará un 20 % mas de salario a las personas que llevan mas de 10 años en la empresa
execute aumentasueldo(10,20);
 
 
 
 
 create or replace procedure ingresoemple(docu in char, nom in varchar2, ape in VARCHAR2)
 as
    begin
        insert into empleados values (docu,nom,ape,null,null) ;
    end ingresoemple;
 
 
 execute ingresoemple('33333333', 'Emilio', 'Perez');
 
 select * from empleados;
 
 
 
 