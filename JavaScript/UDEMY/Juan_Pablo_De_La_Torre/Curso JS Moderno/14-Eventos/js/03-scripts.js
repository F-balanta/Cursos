// Eventos que suceden en el teclado

const busqueda = document.querySelector('.busqueda')
console.log(busqueda);

// // Este evento se ejecuta cuando se preciona una tecla o se deja precionada
// busqueda.addEventListener('keydown',()=>{
//     console.log("Escribiendo");
// });

// //Este evento se ejecuta cuandose deja de presionar una tecla
// busqueda.addEventListener('keyup',()=>{
//     console.log("Dejé de precionar la tecla");
// });

// // Este evento se ejecuta cuando se sale de un INPUT
// busqueda.addEventListener('blur',()=>{ // utilizado para validaciones 
//     console.log("Evento blur");
// });

// // Este evento se ejecuta cuando se copia un texto (puede ser con comandos o con el mouse)
// busqueda.addEventListener('copy',()=>{ // utilizado para validaciones 
//     console.log("Evento copy");
// });

// // Este evento se ejecuta cuando se Pega un texto
// busqueda.addEventListener('paste',()=>{
//     console.log("Evento paste");
// });

// // Este evento se ejecuta cuando se corta un texto
// busqueda.addEventListener('paste',()=>{
//     console.log("Evento cut");
// });

// // Este evento se ejecuta con las mismas acciones que los eventos anteriores a excepcion del blur
// busqueda.addEventListener('input',()=>{
//     console.log("Evento input");
// });

busqueda.addEventListener('input',(evento)=>{
    // indica sobre que elemento se está trabajando
    // console.log(evento.type);
    // Indica sobre que input en especifico se está trabajando
    // console.log(evento.target);
    // Se puede ver lo que el usuario está escribiendo
    //console.log(evento.target.value);


    // Validar que un input tenga informacion
    if(evento.target.value == ''){
        console.log("Falló la validación");
    }

});
