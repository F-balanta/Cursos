const carrito = [
  { nombre: "Monitor 27 Pulgadas", precio: 500 },
  { nombre: "Televisión", precio: 100 },
  { nombre: "Tablet", precio: 200 },
  { nombre: "Audifonos", precio: 300 },
  { nombre: "Teclado", precio: 400 },
  { nombre: "Celular", precio: 700 },
];

//Filtrar elementos de un arreglo

let resultado = carrito.filter((producto) => producto.precio > 400);
console.log(resultado);

resultado = carrito.filter(producto=>producto.precio < 600);
console.log(resultado);


//sacar del filtro un elemento
resultado = carrito.filter(producto=>producto.nombre !=='Audifonos');
console.log(resultado);