// Encontrar la posicion de un array
const meses = ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio"];

const carrito = [
  { nombre: "Monitor 27 Pulgadas", precio: 500 },
  { nombre: "Televisión", precio: 100 },
  { nombre: "Tablet", precio: 200 },
  { nombre: "Audifonos", precio: 300 },
  { nombre: "Teclado", precio: 400 },
  { nombre: "Celular", precio: 700 },
];
console.table(meses);
meses.forEach((mes,i)=>{
    if(mes === 'Abril'){
        console.log(`El mes ${mes} fue encontrado en el indice: ${i}`)
    }
})

// encontrar el indice

const indice = meses.findIndex(mes => mes=== 'Diciembre');
console.log(indice);

const indice2 = carrito.findIndex(producto=>producto.precio === 100);

console.log("El indice es: ", indice2);