interface Alumnos{
    nombre:string,
    edad : number
};

var listadoDeNombres: Array<string> = ["Juana", "Maria", "Ana", "Carmen"];
var listadoDeNumeros: Array<number> = [15,25,36,695,95]

let listadodeAlumnos: Array<Alumnos> = [
    {nombre:"Maria",edad:25},
    {nombre: "Jenifer",edad:45},
    {nombre: "Jhoana", edad: 55}
];

console.log(listadodeAlumnos[2].nombre);