// querySelector  funciona similar a otros selectores y permite seleccionar por clase y Id

const card = document.querySelector('.card')// Tiene una sintazis similar a los selectores de css
console.log(card);



// podemos tener selectores especificos como en css
const info = document.querySelector('.premium .info');
console.log(info);
// mostraria la clase .info ya que es hijo de la clase premium

//seleccionar la segunda clase llamada card dentro de la clase hospedaje
const segundoCard = document.querySelector('section.hospedaje .card:nth-child(2)');
console.log(segundoCard);


// seleccionar por id
const formulario = document.querySelector('#formulario');
console.log(formulario);


// Seleccionar elemento HTML
const navegacion = document.querySelector('nav');
console.log(navegacion);