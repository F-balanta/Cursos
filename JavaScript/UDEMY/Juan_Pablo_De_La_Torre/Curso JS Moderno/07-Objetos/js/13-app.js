// Metodos para objetos: Keys, Value, Entries

const producto = {
    nombre: "Monitor 20 Pulgadas",
    precio: 300,
    disponible: true,
}

//!Obtiene un arreglo con las propiedades o llaves del objeto
console.log(Object.keys(producto));
// ? Se puede utilizar para ver si la consulta hacia una base de datos fue exitosa
//! Retorna un arreglo con los valores de las propiedades del objeto
console.log(Object.values(producto));
//! Devuelve un arreglo con las propiedades y seguidamente su valor de un objeto
console.log(Object.entries(producto));