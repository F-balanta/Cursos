let fArray = [1,2,3,4];
let sArray = [6,7,8];


// Concatena 2 array
//let concatenateArray = concat(sArray);
// Devolver el valor del array como un objeto usando el metodo entries
for(let[index, value] of sArray.entries()){
    console.log(`Indice [${index}]  valor ${value}`);
}

console.log("\n\nCon foreach")
sArray.forEach((value, index) =>{
    console.log(value +" => " + index );
});

// MEtodo every y Some
console.log("METODO EVERY Y SOME");
// El metodo every retorna verdadero si encuentra el valor del array
console.log(fArray.every(value => value >= 0)); //! En este caso retornaa verdadero si todos los elementos del array son > 0

// Por el contrario el metodo some   devuelve true si  alguno de los valores cumple la condicion
console.log(fArray.some(value => value > 2)); 

//! El metodo Slice devuelve una copia del array
let arraycecopy = fArray.slice();
console.log("\n\nCopia array\n"+arraycecopy);
//! El metodo eslice tambien puede cortar un array
const newarray = fArray.slice(1,3)
console.log(newarray);


fArray.push(5,6,7,8,9,10,12,5,4,8,7,5,-5);
console.log("\n\n" + fArray);

// METODO FILTER Y FIND
// Filter encuentra todos los valores que coinciden con la condicion que se le pasa
console.log(fArray.filter(value => value >10));

// El metodo find  devuelve  1 valor cumpla con la condicion
console.log(fArray.find(value => value > 1));

//FindInddex
console.log(fArray.findIndex(value => value >= 0));


// EL METODO include devuelve true o false si el valor buscado coincide
console.log(fArray.includes(11)); // En este caso es falso ya que el valor no está en el array

// Metodo IndexOf devuelve el indice en el que se encuentra un valor buscandolo de izquierda a derecha
console.log(fArray.indexOf(-5)); //! Indice 16
// metdodo lastindexof devuelve el indice en el que se encuentra un valor buscandolo de derecha a izquierda
console.log(fArray.lastIndexOf(-5)); //! Indice 16

// Metodo Map
// Al utilizarlo se crea un nuevo array con las modificaciones que se le den
console.log(fArray.map(value => value * 3));