interface Reproductor{
    volumen:number;
    segundo:number;
    cancion:string;
    detalles:Detalles;
}

interface Detalles{
    author:string;
    anio:number;
}

const reproductor:Reproductor={
    volumen:90,
    segundo:36,
    cancion:'Mess',
    detalles:{
        author:'Ed Sheran',
        anio:2015
    }
}
const {volumen, segundo, cancion, detalles} = reproductor
//const {author} = detalles; desestructurar el objeto detalles
//const {volumen, segundo, cancion, detalles: {author}} = reproductor Sacando el autor de detalles
console.group("Forma Nativa");
console.log('EL volumen actual es de: ', reproductor.volumen);
console.log('EL segundo actual es de: ', reproductor.segundo);
console.log('La cancion actual es de: ', reproductor.cancion);
console.log('EL autor actual es de: ', reproductor.detalles.author);
console.groupEnd();

// Desestructuracion de Objetos
console.group("Desestructuracion de Objetos");
console.log('EL volumen actual es de: ', volumen);
console.log('EL segundo actual es de: ', segundo);
console.log('La cancion actual es de: ', cancion);
console.log('EL autor actual es de: ', detalles.author);
console.groupEnd();