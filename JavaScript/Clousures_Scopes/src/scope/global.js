//! GLOBAL SCOPE

var a; // declarando
var b ='b'; // Declaramos / Asignamos
b = 'bb'; // Redeclaracion

// El global scope indica que tocas ls variables que declaremos pasan a ser variables globales

var fruit= 'apple';

function bestFruit(){
    console.log(fruit);
}
bestFruit();

function countries(){
    country = "Colombia"; //! Esta variable se está declarando de forma global volviendola accesible desde cualquier lado
    console.log(`${country}`);
}