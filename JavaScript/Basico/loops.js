var estudiantes = ["Maria", "Sergio", "David", "Daniel"];

function saludarEstudiante(estudiante) {
    console.log(`Hola, ${estudiante}`);
}
/*
for (var estudiante of estudiantes) {
    saludarEstudiante(estudiante);
}*/

/*for (var i = 0; i < estudiante.length; i++) {
    saludarEstudiante(estudiante[i]);
}*/

while(estudiantes.length > 0){
    console.log(estudiantes);
    var estudiante = estudiantes.shift();
    saludarEstudiante(estudiante);
}
