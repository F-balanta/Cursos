"use strict" // Exige ciertas reglas a la hora de escribir el código

const producto = {
    nombre: "Monitor 20 pulgadas",
    precio: 300,
    disponible: true
}


producto.imagen = 'producto.jps';
console.log(producto);

// COmo hacer que un object se pueda comportar como una constate, que sus propiedaes y el prop objeto no puedan cambiar
// Se debe de habilitar el modo estricto
// Congela un objeto para que este no pueda ser modificado
Object.freeze(producto);
//! No permite que se agergué,modifique, ni eliminen propiedades de un objeto
//producto.disponible = false;
//producto.imagen = "imagen.jpg";
//delete producto.precio;

console.log(producto);
// Valida si el objeto está congelado
console.log(Object.isFrozen(producto));