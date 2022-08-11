//! Para declarar un generator se le agerga un asterisco  a la palabra reservada function

function* gen(){
    //? valores de retorno para las functiones generator
    yield 1;
    yield 2;
    yield 3;
}
const g = gen();
console.log(g);
// Obtiene el primer valor de retorno
console.log(g.next());
// Al colocarlo una segunda vez comienza iterar y tra el siguiente valor a retornar
console.log(g.next());

function* iterate(array){
    for (let value of array){
        yield value;
    }
}
const it = iterate(["a","be","ce","de","eh","efe"]);
console.log(it.next().value); // Obtiene el valor del primer del elemento
console.log(it.next().value); // Obtiene el valor del  siguiente elemento
console.log(it.next().value); // Obtiene el valor del  siguiente elemento
console.log(it.next().value); // Obtiene el valor del  siguiente elemento
console.log(it.next().value); // Obtiene el valor del  siguiente elemento
console.log(it.next().value); // Obtiene el valor del  siguiente elemento
// !Cuando ya no hay mas contenido para mostrar depues del retorno de yield
// ! y si realizamos otro llamado nos devolverá un valor undefined

