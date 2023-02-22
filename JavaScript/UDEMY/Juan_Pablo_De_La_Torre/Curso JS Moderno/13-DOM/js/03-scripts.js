// Seleccionar elementos por su ID
// Solo se debe de usar ese id con ese nombre 1 vez  por documento
const formulario = document.getElementById('formulario');
console.log(formulario);

// Si no existe el id - devolvera null
const noexiste = document.getElementById('no-existe');
console.log(noexiste); 


//! Casi no se utiliza el "getElementById" y "getElementByClassName"
// En su lugar se creo un nuevo selector llamado querySelector