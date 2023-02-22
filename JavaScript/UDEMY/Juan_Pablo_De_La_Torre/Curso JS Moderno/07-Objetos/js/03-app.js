const producto = {
    nombre: "Monitor 20 pulgadas",
    precio: 300,
    disponible: true
}

// Agregando nuevas propiedades a un objeto
// se puede crear una propiedad cuando está no exista dentro del objeto, se le debe asignar un nombre despues del punto y el valor que contendra
producto.imagen = "Imgane.jpg";

console.log(producto);
// Eliminar una propiedad de un objeto
delete producto.disponible
console.log(producto)