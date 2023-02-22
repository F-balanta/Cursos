const producto = {
    nombre: "Monitor 20 pulgadas",
    precio: 300,
    disponible: true,
    informacion : {
        
        medidas : {
            peso : '1kg',
            medida : '1m'
        },
        fabricacion : {
            pais : 'China'
        }
    }
}

// console.log(producto.nombre);
// Asignar el valor de una propiedad a una variable 
// const nombre = producto.nombre;
// console.log(nombre);

// Extraer el nombre de la propiedad del objeto su valor
// const {nombre, precio, disponible} = producto; // A esto se le llama Destrucutracion de objetos - Sacar de una estructura
// console.log(nombre);

console.log(producto);
console.log(producto.informacion.fabricacion.pais);
const {pais} = producto.informacion.fabricacion

console.log(pais);