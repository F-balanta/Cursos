function Componente({ backgroundColor }){
    return (<div className={`bg-color-${backgroundColor}`}>Hola</div>)
}

// Acortadores de nombre
const nombre = "Felipe";
const edad = 22;
const twitter = 'https://twitter.com/carlosazaustre';

// Si son iguales las variables se puede ahorrar el texto 
const persona = {
    nombre:nombre,
    edad: edad,
    twitter: twitter
}
// y dejarlo de la siguiente manera:
//const persona = {
//    nombre,
//    edad ,
//    twitter
//}

// Funciones lambdas
// Funcion llamada funcionFlecha que retorna una cadena
const funcionFlecha = ()=> "Hola"


funcion