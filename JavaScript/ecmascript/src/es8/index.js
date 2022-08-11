// Una de las caracteristicas acquiridas en está version fúe Object.entries
// Que su funcion es devolver tanto la clave como el dato de un diccionario;

const data = {
    frontend: "oscar",
    backed: "Felipe",
    design: "David"
}

const entries = Object.entries(data);
console.log(entries);

// Tambien podemos averiguar cuantos elementos tiene un objeto
console.log(entries.length.toPrecision);

// Para obtener los valores de una key en un objeto podemos hacer lo siguiente

const data = {
    frontend: "oscar",
    backed: "Felipe",
    design: "David"
}
const values = Object.values(data);
console.log(values);

const keys = Object.keys(data);
console.log(keys);



// Agregar mas  caracteres a una cadena
const string = "hello";
console.log(string.padStart(7, "hi"));