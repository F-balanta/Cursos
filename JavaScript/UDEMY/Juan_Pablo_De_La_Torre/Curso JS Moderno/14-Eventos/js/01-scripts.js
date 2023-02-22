// Detectar cuando el html ha cargado por completo

// addEventListener Indica que tipo de evento será ejecutado
// DOMContentLoaded Es un evento que se ejecuta cuando el documento html ha terminado de cargar todos loe recursos y eventos
console.log(1);
document.addEventListener('DOMContentLoaded', ()=>{
    console.log(2);
});
console.log(3);