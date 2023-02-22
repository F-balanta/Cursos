//? Funciones de Objetos

const producto = {
    nombre: "Monitor 20 pulgadas",
    precio: 300,
    disponible: true,
    mostrarInfo : function(){
        // Con la palabra this accedemos a lso valroes que existan dento del mismo escope o ambito
        // en este caso las variables del objeto al ser utilizadas en la funcion
        console.log(`El producto: ${this.nombre} tiene un precio de: ${this.precio}`)
    }
}

console.log(producto);
producto.mostrarInfo();


const producto2 = {
    nombre: "Tablet",
    precio: 3000,
    disponible: true,
    mostrarInfo : function(){
        // Con la palabra this accedemos a lso valroes que existan dento del mismo escope o ambito
        // en este caso las variables del objeto al ser utilizadas en la funcion
        console.log(`El producto: ${this.nombre} tiene un precio de: ${this.precio}`)
    }
}

console.log(producto2);
producto2.mostrarInfo();