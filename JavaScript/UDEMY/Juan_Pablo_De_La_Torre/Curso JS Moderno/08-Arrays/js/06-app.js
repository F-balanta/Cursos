const carrito = [];


const producto = {
    nombre: "Monitor 321 Pulgadas",
    precio: 400
}

const producto2 = {
    nombre: "Celular",
    precio: 800
}

const producto3 = {
    nombre: "Teclado",
    precio: 50
}

//? Forma Declarativa - No modifica el objeto actual- se crea uno nuevo

resultado = [...carrito,producto ];
resultado = [...resultado,producto2 ];
// Trabaja como el unshif
resultado = [producto3,producto ];

console.table(resultado);
