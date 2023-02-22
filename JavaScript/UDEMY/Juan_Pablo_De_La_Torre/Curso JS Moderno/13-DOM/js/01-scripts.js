let elemento;
// Selecciona todo lo relacionado con el documento HTMl
elemento = document;
// Selecciona todo los elementos que conforman el HTML
elemento = document.all;
// Obtiene todas las etiquedas dentro del head incluido el head
elemento = document.head;
// Obtiene todas las etiquetas del Body
elemento = document.body;
// Selecciona el dominio actual
elemento = document.domain; 
// Mostrar cuantos formularios hay en el documento
// Retorna los elementos en forma de arreglo
//? A esto se le llama HTML Collection
elemento = document.forms;

// Accediendo a las propiedades del from
elemento = document.forms[0].id; // ID
console.log(elemento);
elemento = document.forms[0].classList; // Clases
console.log(elemento);
elemento = document.forms[0].method; // Metodo Http
console.log(elemento);
elemento = document.forms[0].action;
console.log(elemento);
// Obtiene un arreglo con los  enlaces que tiene el documento
elemento = document.links;
// Accediendo a los enlaces
elemento = document.links[4];
console.log(elemento);

// Obtiene un arreglo con las clases asignadas
elemento = document.links[4].classList;
console.log(elemento);
// Obtiene una cadena con el nombre de la clase
elemento = document.links[4].className;
console.log(elemento);




//console.log(elemento);