
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
//? Forma imperativa - Modifica el mismo objeto 
// Carrito es un arreglo de objetos
// Push para agregar al final de un arreglo
carrito.push(producto);
carrito.push(producto2);

const producto3 = {
    nombre: "Teclado",
    precio: 50
}
// Para agregar un elemento al inicio de un arreglo
carrito.unshift(producto3);


console.table(carrito);
