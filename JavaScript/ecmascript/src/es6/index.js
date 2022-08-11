// Como funciopnaba antes las funciones
function newFunction(name, age,country){
    var name = name || "oscar";
    var age = age || 22;
    var country = country || "US";
    console.log(name , age, country);
}

// es6
function newFuntion2(name = "oscar", age = 22, country = "US"){
    console.log(name, age, country);
}

newFuntion2();
newFuntion2("David","25","Colombia");

// Template literals
// Antigua forma para concatenacion de las variables
let hello = "Hello";
let world = "World";
let epicPhrase = hello + world;
console.log(epicPhrase)

//Nueva forma usando literales
let epicPhrase2 = `${hello} ${world}`
console.console.log(epicPhrase2);


// Multilineas  sin y con literales
let lorem = "lorem ipsum dolor sit amet, consectet \n"
+ "otra frase lorem ipsum dolor sit amet, consect";

// Nueva forma de hacer las multilineas con las cadenas en javascript
// Haciendo uso de las  Comillas Literales
let lorem2 = `otra  frace epica que necesitamos
ahora es otra frase epica
`;
console.log(lorem);
console.log(lorem2);

// Estructutracion de elementos
// Forma en la que se declaraman y se accedia a los elementos
let person={
    "name": "John",
    age:   30,
    "Country": "Colombia"
}
console.log(person.name, person.age, person.Country);
// Ahora se puede acceder de esta forma,
// se crea una constante que tendrá los valores del objetode tipo persona
let {name, age, Country} = person;
console.log(name, age, Country);


// Elementos en arreglos y poder unirlos
let team1 = ['Oscar','Julian','Ricardo'];
let team2 = ['Valeria', 'Yessica', 'Camila'];

let education = ['David', ... team1,...team2]; // Nuevo elelemento donde estan los equipos unidos

console.log(education);


// let es la nueva palabra reservada para trabajar con
// los elementos que se deben dee guardar en memoria en este caso las variables
// var == Declarabla las variables de forma global sin importar el Scope
// let: La  variable creadas con e esta palabra reservada dejara el acceso de estas
// para el escope donde se definió

{
    var globalVar = "Global var";

}
{
    let globatlet = "globatlet";
    console.log(globatlet);
}
console.log(globalVar);
// globallet no seria accesible si no no se usa dentro del contexto donde se declaró
console.log(globatlet);


// Variable que no puede cambiar  su valor
const a = 'b';
console.log(a);


// Forma en la que se aignaba a un objeto el valor de una variable
let nombre= "Felipe";
let edad = 22;

obj = {nombre: nombre, edad: edad};
console.log(obj);
// Ahora se puede acceder de está forma:
obj2 = {nombre,edad};
console.log(obj2);



// Arrows Functiopns o Lambdas
// En este caso tenemos un arrays de objetos y queremos obtener solamente los nombres
const names = [
    {name: "felipe", age:22},
    {name: "felipe", age:22},
    {name: "felipe", age:22}
]
 // Hariamos uso de la funcion Map jungo a otra funcion que nos daria el resultado
let listOfNames = names.map(function(item){
    console.log(item.name);
});

// Sin necesidad de agregar una uncion a ala funcion map  simplemente le pasamos el item que nesesitamos recuperar
let listOfNames2 = names.map(item => console.log(item.name))

// Otra forma de utilizar las arrows functions
const listOfNames3 = (name, age,country) =>{
// TODO
}
const listOfNames4 = name=>{

}
const square = num => num * num;



//!QUE SON LAS PROESAS
//!Con las promesas podemos trabajar el Asincronismo
/*
! el sincronismo significa el poder trabajar con una sola tarea y hasta
! que no se cumpla esa tarea no puede iniciar una nueva.
*/

const helloPromise =() =>{
    return new Promise((resolve, reject)=>{
        if (true){
            resolve("Hey!");
        }else{
            reject("No se puedo!");
        }
    });
}

helloPromise()
    .then(Response=>console.log(response))
    .catch(error=>console.log(error));




// LLEGADA DE LAS CLASES
class calculator{
    constructor(){
        this.valorA = 0;
        this.Valorb = 0;
    }
    sumar(valorA,Valorb){
        this.valorA = valorA;
        this.Valorb = Valorb
        return this.valorA + Valorb;
    }
}

const Calc = new calculator();
console.log(Calc.sumar(2,2));

// Forma de importar un archivo o modulo
import {hello} from './module'

hello();


// Otra funcion agregada a  ES6  GENERATOR
// Es una funcion que retorna una serie de valores y algoritmos definidos

function* helloWorld(){
    if(true)
    {
        yield "Hello, ";
    }
    if(true){
        yield "World"
    }
};
const generatorHello = helloWorld();
console.log(generatorHello.next().value);
console.log(generatorHello.next().value);
console.log(generatorHello.next().value);

















