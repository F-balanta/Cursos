/*
    ===== Código de TypeScript =====
*/

// Declaracion Variables con 1 o mas tipados
let nombre: string = 'Strider';

// EL operador | permite agregar mas tipados sobre una variable
let hp: number | string = 95;
// Permitiendo reasignarle un valor
hp = 'Full';
// Variables booleanas (true or false)
let estaVivo: boolean = true;
console.log(nombre, hp);