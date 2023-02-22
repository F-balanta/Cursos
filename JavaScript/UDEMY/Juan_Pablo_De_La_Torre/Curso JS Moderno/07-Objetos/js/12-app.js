// Crear Objetos usando Object Constructor

// Object Literal
const producto = {
    nombre: "Monitor 20 Pulgadas",
    precio: 300,
    disponible: true,
}

// Object constructor

function Producto(nombre, precio){
    this.nombre = nombre;
    this.precio = precio;
    this.disponible = true;
}

const producto2 = new Producto("Monitor 65 Pulgadas", 7000);

console.log(producto);
console.log(producto);