
// Agregar elementos a un arreglos
const meses = ['Enero', 'Febrero', 'Marzo'];
const carrito = []
// Agregar al final del arreglo
meses.push('Abril');
meses.push('Mayo');
console.table(meses);


const producto = {
    nombre: "Monitor 321 Pulgadas",
    precio: 400
}

const producto2 = {
    nombre: "Celular",
    precio: 800
}
// Carrito es un arreglo de objetos
// Push para agregar al final de un arreglo
carrito.push(producto);
carrito.push(producto2);

const producto3 = {
    nombre: "Teclado",
    precio: 50
}

const producto4 = {
    nombre: "celular2",
    precio: 100
}


// Para agregar un elemento al inicio de un arreglo
carrito.unshift(producto3);

console.table(carrito);

// console.table(carrito);

// //! Eliminar último elemento del arreglo

// carrito.pop();
// console.table(carrito);

// //! Eliminar del inicio del arreglo
// carrito.shift();
// console.table(carrito);


//! Eliminar dede cierta posicion y que cantidad eliminar
carrito.splice(1,1); //? Desde la posicion 1 va a eliminar 1 elemento
console.table(carrito);
