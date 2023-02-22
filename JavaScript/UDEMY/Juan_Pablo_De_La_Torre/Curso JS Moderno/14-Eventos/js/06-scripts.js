//Event Bubbling

// Es cuando precionas un elemento que tiene un evento este evento hara estallar los eventos de las etiquetas hijas

const cardDiv1 = document.querySelector('.card');
const infoDiv = document.querySelector('.info');
const titulo = document.querySelector('.titulo');

//Al darle click un evento terminara disparando otro dependiendo de la jerarquia de las etiquetas
cardDiv1.addEventListener('click',(e)=>{
    
    // Cancela pa propagacion de los eventos
    e.stopPropagation();
    console.log("Click en card");
});

titulo.addEventListener('click',(e)=>{
    e.stopPropagation();
    console.log("Click en titulo");
});

infoDiv.addEventListener('click',(e)=>{
    e.stopPropagation();
    console.log("Click en info");
});