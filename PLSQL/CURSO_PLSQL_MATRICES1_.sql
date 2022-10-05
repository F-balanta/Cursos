                                                                                    -- ARRAYS  // MATRICES
/*
* Se utilizan para almacenar una coleccion ordenada de datos
* Se puede pensar en ellos como un arreglo de variables del mismo tipo
* Se puede cambiar dinamicamente el tamaño 
*
                                                                                                REGLAS
* El indice de un array / matriz siempre va a ser 1  
* Solo hay matrices Unidimensionales
* Los valores al declararse son automaticamente nulos  POR LO QUE DEBEN DE INICIALIZARSE ANTES DE ACCEDER A SUS ELEMENTOS
*/



set serveroutput on;


declare
    -- Para declarar un nuevo tipo de objeto hacemos uso de la palabra reservada Type
    /*
    Con esto le indicamos al sistema que se creará un nuevo tipo de objeto de tipo varray de 5 elementos
    y cada elemento sera una cadena de 20 caracteres
    */
    TYPE a_paises is VARRAY(5) of varchar2(20);
    
    -- Variable llamada nombre de tipo a_paises
    -- Almacenara distintos valores como un array de PL/SQL
    nombre a_paises;   

begin
    -- inicializamos la matriz  colocndole el nombre de la matriz := a_paises para que el sistema asuma  la configuracion de matriz
    -- Y dentro de los parentesis estan los valores de tipo varchar2
    nombre := a_paises('Argentina', 'Brazil','Peru', 'Mexico', 'Rep. Dominicana');
    
    /*Bucle que rrecorrera el array
    En este caso  la variable ( "f") será el iterador en un rango de de 1 a 5*/
    for f in 1..5 loop
    -- Imprimos el valor del arreglo
    -- El indice se deja entre parentesis
        dbms_output.put_line('Nombre: ' || nombre(f));
    end loop;
end;
