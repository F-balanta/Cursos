const carrito = [

    {nombre: "Monitor 27 Pulgadas",precio: 500},
    {nombre: "Television", precio: 100},
    {nombre: "Tablet", precio: 200},
    {nombre: "Audifonos", precio: 300},
    {nombre: "Teclado", precio: 400},
    {nombre: "Celular", precio: 700},
]

console.group("Map Function")
carrito.map(function(producto){
    console.log(`${producto.nombre} - Precio: ${producto.precio}`);
})

    
console.group("forEach Function")
carrito.forEach( function(producto){
    console.log(`${producto.nombre} - Precio: ${producto.precio}`);
});
console.groupEnd()
//? Diferencias entre map y foreach 
// Map crea un arreglo nuevo -- Llenara una variable con un arreglo nuevo