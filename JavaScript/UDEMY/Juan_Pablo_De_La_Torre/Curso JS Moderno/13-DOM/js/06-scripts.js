// Modificar textos o Imagenes con JS

const encabezado = document.querySelector('.contenido-hero h1');
console.log(encabezado)

// Acceder al texto de un elemento
//console.log(encabezado.innerText); // Si en el CSS está activada la pripiedad - visibility:hidden; no va a encontrar el elemento

// Acceder al texto de un elemento
//console.log(encabezado.textContent);

// Se trae el texto y las etiquetas y el dofigo html que esté en este
//console.log(encabezado.innerHTML);

// Encadenamiento - chaning
//Seleccionar directamente la cadena de un elemento
const encabezado2 = document.querySelector('.contenido-hero h1').textContent;
console.log(encabezado2);


//Agregar un nuevo valor

const nuevoHeading = "¡Nuevo Heading!"

document.querySelector('.contenido-hero h1').textContent = nuevoHeading;


// Modificando Imagenes

const imagen = document.querySelector('.card img');
console.log(imagen);

imagen.src = 'img/hacer2.jpg'
