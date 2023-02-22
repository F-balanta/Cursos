// Añadir o Crear elementos

const enlace = document.createElement('A');

// Agregar texto a un enlace
enlace.textContent = 'Nuevo texto en el enlace';

// Añadiendo href
enlace.href = '/nuevo-enlace';
console.log(enlace);


enlace.target = "_blank"

enlace.setAttribute('data-enlace', 'nuevo-enlace');

enlace.classList('');

// Seleccionar navegacion
const navegacion = document.querySelector('.navegacion')
// Agregaqr un elemento hijo al padre
navegacion.appendChild(enlace);

// Agregar en cierta posicion
// Se agregará antes de la posicion 1 
navegacion.insertBefore(enlace, navegacion.children[1]);




// Crear un card de forma dinamica
const parrafo1 = document.createElement('P');
parrafo1.textContent = "Concierto";
parrafo1.classList.add('categoria', 'concierto');



const parrafo2 = document.createElement('P');
parrafo2.textContent = "Concierto de Rock";
parrafo2.classList.add('titulo');



const parrafo3 = document.createElement('P');
parrafo3.textContent = '$800 por persona';
parrafo3.classList.add('precio');



// Crear div con la clase INFO
const info = document.createElement('div');
info.classList.add('info');
info.appendChild(parrafo1)
info.appendChild(parrafo2)
info.appendChild(parrafo3)

const imagen = document.createElement('img');
imagen.src = 'img/hacer2.jpg'

imagen.alt = "Texto alternativo";

// Crear card

const card = document.createElement('div');
card.classList.add('card');

// Asignar la imagen
card.appendChild(imagen);
// asignar info
card.appendChild(info);
console.log(card);

// Insertar en el HTML

const contenedor = document.querySelector('.hacer .contenedor-cards');
contenedor.appendChild(card);