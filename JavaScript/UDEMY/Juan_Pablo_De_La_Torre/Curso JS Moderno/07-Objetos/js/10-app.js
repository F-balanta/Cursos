// Unir Objetos

const producto = {
    nombre : "Monitor 20 Pulgadas",
    precio: 300,
    disponible: true
}

const medidas = {
    peso: '1Kg',
    medida: '1m'
}

console.log(producto);
console.log(medidas);


const resultado = Object.assign(producto, medidas);

console.log(resultado);


// Spread Operator o Rest operator

// Toma una copia de los objetos y las agrega al nuevo
const resultado2 = {...producto, ...medidas}
console.log(resultado2)