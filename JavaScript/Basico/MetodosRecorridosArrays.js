var articulos = [
    {nombre: "Bici", costo: 3000},
    {nombre: "Tv", costo: 5000},
    {nombre: "Libro", costo: 10000},
    {nombre: "Celular", costo:20000},
    {nombre: "Laptop", costo:40000},
    {nombre: "Teclado", costo:40000},
    {nombre: "Audifonos", costo:40000}
]
// Genera un nuevo array con los articulos cuyo costo es menor a 5000
/*var  ArticulosFiltrados = articulos.filter(function(articulos){
    return articulos.costo <=5000
});*/

// me trae solos los nombre de los articulos dentro del array
// generando un nuevo array con el valor deseado
var nombreArticulos = articulos.map(function(articulos){
    return articulos.nombre
});

// Recorrer arrays

var encuentraarticulo = articulos.find(function(articulos){
    return articulos.nombre =="Laptop";
});


// Filtra sobre el array sin modificarlo
// Sirve para iterar dentro de un arreglo  al igual que los otros oteradors map y filter
//
articulos.forEach(function(articulos){
    console.log(articulos.nombre);
});

// Some es un metodo que valida True/False si existe el valor de retorno o condicion a evaluar 
// Genera un nuevo array
var baratos = articulos.some(function(articulos){
    return articulos.costo <=5000;
});
