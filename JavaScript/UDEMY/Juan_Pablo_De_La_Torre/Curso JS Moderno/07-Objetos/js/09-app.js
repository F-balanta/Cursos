"use strict" // Exige ciertas reglas a la hora de escribir el código

const producto = {
    nombre: "Monitor 20 pulgadas",
    precio: 300,
    disponible: true
}

console.log(producto);

//Sellar un objeto
//? No permite que se agreguen, ni eliminen propiedades de un objeto > Pero si permite modificar las existentes
Object.seal(producto);
producto.disponible = false;
//producto.imagen = "imagen.jpg";
//delete producto.precio;

console.log(producto);
// Valida si el objeto está congelado

console.log(Object.isSealed(producto));