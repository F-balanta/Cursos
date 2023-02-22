const carrito = [
  { nombre: "Monitor 27 Pulgadas", precio: 500 },
  { nombre: "Televisión", precio: 100 },
  { nombre: "Tablet", precio: 200 },
  { nombre: "Audifonos", precio: 300 },
  { nombre: "Teclado", precio: 400 },
  { nombre: "Celular", precio: 700 },
];

let total = 0;

carrito.forEach((producto) => (total += producto.precio));

console.log(total);

// Sacar un resultado de una operacion con metodo reduce()
//? recibe 2 parametros: el valor que ira a cumulando(el valor previo), y el valor actual o el objeto a evaluar
let resultado = carrito.reduce((total, producto) => total + producto.precio, 0);
