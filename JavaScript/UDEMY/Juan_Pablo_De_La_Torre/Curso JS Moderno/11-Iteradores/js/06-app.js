// forEach

const carrito = [
  { nombre: "Monitor 27 Pulgadas", precio: 500 },
  { nombre: "Television", precio: 100 },
  { nombre: "Tablet", precio: 200 },
  { nombre: "Audifonos", precio: 300 },
  { nombre: "Teclado", precio: 400 },
  { nombre: "Celular", precio: 700 },
];

const pendientes = ["Tarea", "Comer", "Proyecto", "Estudiar", "JavaScript"];

pendientes.forEach((pendiente, indice) =>
  console.log(`${indice} : ${pendiente}`)
);

carrito.forEach((producto) => {
  console.log(producto.nombre);
});



nuevoCarrito = carrito.map((producto)=> producto.nombre);
nuevoCarrito2 = carrito.forEach((producto)=> producto.nombre);

console.log(nuevoCarrito);
console.log(nuevoCarrito2);