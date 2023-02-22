//Inicializar una variable con un valor
var producto = "Monitor de 24 Pulgadas";
console.log(producto);

// Las variables se pueden reasignar
producto = "Monitor de 19 Pulgadas";
console.log(producto);

// Javascript es un lenguaje de tipo dinamico, no se especifica tipo de dato
producto = 20;
console.log(producto);


// Se pueden inicializar sin valor y asignarlo despues
var disponible;
disponible = true;
disponible = false;

// Inicializar múltiples variables
var categoria = 'Computadoras',
    marca = "Marca Famosa",
    calificación = 5;


// Reglas de las variables:

// Pueden tener: letras, numeros, _
// No pueden iniciar con numero
var 99dias;
var dias99;

var _01;
var 01_;

// Estilos para nombrar variables con más de una palabra

// más de una palabra.
var  nombreProducto = 'Monitor 30 Pulgadas'; // CamelCase
var nombre_producto = 'Monitor 30 Pulgadas'; //underscore
var NombreProducto = 'Monitor 30 Pulgadas'; // pascal case
var nombreproducto = 'Monitor 30 Pulgadas';