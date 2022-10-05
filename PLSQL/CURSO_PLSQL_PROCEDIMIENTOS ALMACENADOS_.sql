                                                                            --PROCEDIMIENTOS ALMACENADOS--

/* Es un programa de PL SQL que puede recibir y devolver informacion 
    utilizando parametros de entrada y salida y sin hacer uso de esta.

                                                                            Tipos de Procedimientos Almacenados
    
    - A nivel de esquema
    - Dentro de paquete
    - Dentro de BLoque
    
                                                                            Partes - Procedimientos Almacenados
    - Parte Declarativa = Donde de crean las variables y tipos de datos
    - Parte Ejecutable=  Donde se ejecutan las sentencias
    - Manejo de Excepciones = Solo se usan en caso de que se quieran manerar las excepcionas al ejecutar un procedimiento
    
*/



set serveroutput on;


-- para crear un procedimiento > se usan las palabras create o replace
create or replace procedure saludo -- Si existe lo remplaza y si no está lo crea.
as
   begin -- inicia secion ejecutable
        dbms_output.put_line('Hola a todos');
    end saludo;

-- Para ejecutar un procedimiento almacenado -- Ejecuta el procedimiento con el nombre asignado.
    begin
     
        saludo;
    end;
    
    -- Otra forma se invocar el procedimiento srería
    execute saludo;