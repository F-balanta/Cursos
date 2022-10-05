const dbz:string[] = ['Goku','Vegetta', 'Trunks'];
const [p1,p2,p3] = dbz // p1 = dbz[0]


console.log('Personaje 1', dbz[0]);
console.log('Personaje 2', dbz[1]);
console.log('Personaje 3', dbz[2]);

console.group("Desestructuracion de Arreglos");
console.log('Personaje 1', p1);
console.log('Personaje 2', p2);
console.log('Personaje 3', p3);
console.groupEnd()