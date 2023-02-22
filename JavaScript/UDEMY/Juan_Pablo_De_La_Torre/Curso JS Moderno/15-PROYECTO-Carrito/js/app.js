// Variables
const carrito = document.querySelector("#carrito");
const contenedorCarrito = document.querySelector("#lista-carrito tbody");
const vaciarCarritoBtn = document.querySelector("#vaciar-carrito");
const listaCursos = document.querySelector("#lista-cursos");

cargarEventListeners();
function cargarEventListeners() {
  listaCursos.addEventListener("click", agregarCurso);
}

// Funciones

function agregarCurso(e) {
  e.preventDefault();
  // e = es el evento que se está ejecutando
  //target selecciona el elemento el cual reaccionó al evento
  // classList.contains = indico que se el elemento seleccionado tiene la clase
  // agregar-carrito ejecuta la condicion
  if (e.target.classList.contains("agregar-carrito")) {
    
    const cursoSeleccionado = e.target.parentElement.parentElement;//?Accediendo al elemento padre
    // Mostrar que card está ejecutando el evento
    leerDatosCurso(cursoSeleccionado)
  }
}

// Lee el contenido del HTML al que le dimos click y extrae la informacion del curso
function leerDatosCurso(curso) {
    console.log(curso)

    // Se crea objeto con el contenido del curso actual
    const infoCurso = {
        imagen : curso.querySelector('')
    };
}
