// Eventos con el mouse

const nav = document.querySelector('.navegacion');
console.log(nav);
//Evento que se ejecuta cuando se hace click
nav.addEventListener('click', ()=>{
    console.log('click en nav');
})


//Evento que se ejecuta cuando cuando el mouse pasa por un elemento
nav.addEventListener('mouseenter', ()=>{
    nav.style.backgroundColor = 'white';// Cuando el mouse entra el nav cambia a color blanco
    console.log('Entrando en el nav');
});


// Evento que se ejecuta cuando el mouse sale de un elemento
nav.addEventListener('mouseout', ()=>{
    nav.style.backgroundColor = 'transparent'; // Cuando el mouse sale del nav cambia a color blanco
    console.log('Saliendo del nav');
});

// Este evento se ejecuta cuando se hace click  es muy similar al evento "click"
nav.addEventListener('mousedown', ()=>{
    console.log('Mousedown en el nav');
});

//Se ejecuta cuando se suelta el click
nav.addEventListener('mouseup', ()=>{
    console.log('mouseup en el nav');
});

//Este evento se ejecuta cuando se hace doble click
nav.addEventListener('dblclick', ()=>{
    console.log('mouseup en el nav');
});