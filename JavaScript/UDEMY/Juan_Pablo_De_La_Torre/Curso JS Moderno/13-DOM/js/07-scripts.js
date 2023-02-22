// Cambiar el CSS o Apariencia

// Es posible agregar o quitar clases

const encabezado = document.querySelector('h1');
console.log(encabezado);
console.log(encabezado.style);
// Cambiar el color de fondo
//encabezado.style.backgroundColor = 'red';

// Cambiar la fuente de texto
encabezado.style.fontFamily = 'Arial'

// Cambiar a mayusculas
encabezado.style.textTransform = 'uppercase';
// Cambiar en minusculas 
encabezado.style.textTransform = 'lowercase';
  

// Agergar o quitar clases

const card = document.querySelector('.card');
card.classList.add('nueva-clase', 'segunda-clase')
console.log(card.classList);


// Remover clases
card.classList.remove('card');