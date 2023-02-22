// Prevenir Evento Bubbling con delegacion

const cardDiv = document.querySelector('.card');
//! Ya que card tiene varias etiquetas hijas, como hacemos para saber a que elemento se le está haciendo click?


cardDiv.addEventListener('click', (e)=>{
    console.log(e.target);// Le pasamos el evento y con el target especificamos cual es el elemento seleccionado

    if(e.target.classList.contains('card')){
        console.log("Diste click en Card");
    }
    if(e.target.classList.contains('info')){
        console.log("Diste click en Info");
    }
    if(e.target.classList.contains('titulo')){
        console.log("Diste click en Titulo");
    }
});