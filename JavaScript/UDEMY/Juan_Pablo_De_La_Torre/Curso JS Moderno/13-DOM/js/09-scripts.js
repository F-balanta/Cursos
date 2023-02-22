// Eliminar Elementos

// Seleccionarlo
// const primerElemento = document.querySelector('a'); // primer enlace del Nav
// primerElemento.remove();


// Eliminarlo desde el padre
// const navegacion = document.querySelector('.navegacion')
// console.log(navegacion);
// etiquetaBorrar = navegacion.children;
// console.log(etiquetaBorrar);

// console.log(etiquetaBorrar[2].remove());

const navegacion = document.querySelector('.navegacion')
console.log(navegacion.children);
navegacion.removeChild(navegacion.children[2]);