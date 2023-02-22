// Seleccionando elementos por su clase

const header = document.getElementsByClassName('header');// Se deben de agregar las clases a como están definidas en el HTML
console.log(header);


const hero = document.getElementsByClassName('hero')
console.log(hero)


// Si las clases existen mas de 1 vez 
// Va a traer todos los elementos que tengan la clase Contenedor
const contenedores = document.getElementsByClassName('contenedor');
console.log(contenedores);


// Si una clase no existe

const noExiste = document.getElementsByClassName("no-existe");
console.log(noExiste);