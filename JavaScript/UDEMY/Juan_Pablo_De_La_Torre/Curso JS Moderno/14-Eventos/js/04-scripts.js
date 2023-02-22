// Eventos que suceden en un formulario


 const formulario = document.querySelector('#formulario');

 // cuando alguien preciona el boton que tiene el type Submit
 formulario.addEventListener('submit', (e)=>{
    // submit ejecutaria una accion y enviaria informacion a travez de un metodo http hacia una pagina
    //preventDefault previene o detiene la acción por defecto que realizaria un elemento
    e.preventDefault(); 
    // En este caos nosotros haremos que el formulario haga lo que requerimos
    console.log("Buscando...")

    // Para ver que tipo de método http se está utilizando
    console.log(e.target.method);
    // Muestra hacia donde va a enviar la informacion el formulario
    console.log(e.target.action);
 });