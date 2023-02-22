console.group("Arrays")
const numeros = [10, 20, 30, 40, 50];

// Muestra una tabla con llave y valor indicando el Indice de este
console.table(numeros);
console.log(numeros);


// Accediendo a un arreglo


console.groupEnd();
console.log(numeros[1])



console.group("Objetos");
const objeto = {
    nombre:"Felipe",
    Apellido : "Balanta",
    Edad: 23
}

console.table(objeto);


console.groupEnd();