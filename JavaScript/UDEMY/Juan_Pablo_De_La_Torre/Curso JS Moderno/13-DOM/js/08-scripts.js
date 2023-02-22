// Traversing the DOm - Viajar sobre el DOM


// En jacavacript todo esta conectado al "document", pero la forma de moverse sobre los elementos 
// Se le llama Traversing the DOM


// const navegacion = document.querySelector('.navegacion');
// // A los enlaces en JavaScript se les conoce como nodos
// console.log(navegacion);

// //Lista elementos
// //Los espacios en blanco o saltos de linea al declarar las etiquetas son considerados elementos del html o childNodes cuando se renderizan
// console.log(navegacion.childNodes);

// // Listar los elementos que si sean hijos
// console.log(navegacion.children);
// Selecciono el elemento padre
const card = document.querySelector('.card')
// Con children accedo a los elementos hijos
console.log(card.children);
console.log(card.children[1]);
console.log(card.children[1].children[1].textContent);

// Traversing es ir recorreindo un camino sobre los nodos, elementos de una pagina HTML

// Cambiar imagen con traversing
card.children[0].src = 'img/arriba2.jpg'


// Traversing del hijo al padre

console.log(card.parentElement);
// Tomará al elemento considerado hermano de este
console.log(card.nextElementSibling)