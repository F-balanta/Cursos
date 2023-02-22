const producto = {
    nombre: "Monitor 321 Pulgadas",
    precio: 400,
    disponible: true
}


// const nombre = producto.nombre;
// console.log(nombre);


//? Destructuring con arreglos

const numeros = [10, 20, 30, 40, 50];

// Obtengo el tercer valor
//! con las "," indico que pase a la siguiente indice para obtener su valor
const [ , , tercero ] = numeros;

console.log(tercero);