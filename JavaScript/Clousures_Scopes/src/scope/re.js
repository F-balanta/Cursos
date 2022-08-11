var firstName; // Se le asigna un valor Undeficed
firstName = "Oscar";
console.log(firstName);

var lastName = "David"; // Declarando y asignando
lastName = "Ana"; // Reasignando
console.log(lastName);

var seconName = "Ana";  // Declarando y asignando
var seconName = "jhonatan" //!  Re asignacion y redeclaracion
console.log(seconName);

//!CON LA PALABRA LET  NO SE PUEDE REDECLARAR
let fruit = "apple"
fruit = "Kiwi";
console.log(fruit);

let fruit = "Banano";
console.log(fruit);

const animal = "dog";
animal = "cat"; //! NO SE PUEDE REASIGNAR UNA VARIABLE CONSTANTE
const animal = "cat";//! TAMPOCO SE PUEDE REDECLARAR
console.log(animal);


const vehicles = [];
vehicles.push("😎");
console.log(vehicles);