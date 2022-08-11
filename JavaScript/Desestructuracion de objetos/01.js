// Desestructuracion de objetos
var persona ={
    nombre: "Felipe",
    apellido:"Balanta",
    hijos: {
        numero: 12
    }
};

// la Desestructuracion de objetos sirve para sacar lso datos que son necesarios en el momento
let {nombre, apellido} = persona;
console.log(`${persona.nombre}, ${persona.apellido}`);

//!  ejm2:
var arreglo = [1,2,3,4,4,5];
let [x,y,z] = arreglo;
console.log(x,y,z);
// o simplemente

arreglo [1,2,3];
