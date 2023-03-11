interface Personas{
    nombre: string,
    apellido: string,
    edad: number, 
    peso: number
};

var persona1: Personas = {
    nombre : "Carmen",
    apellido: "Garcia",
    edad: 22,
    peso: 55.5
};

var persona2: Personas = {
    // La propiedad nombres no existe en la interfaz 
    nombres : "Carmen",
    apellido: "Garcia",
    edad: 22,
    peso: 55.5
};