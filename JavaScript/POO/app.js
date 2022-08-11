// const PeliculaUno = {
//     nombre: 'Harry',
//     id: 01,
//     reporoducir(){
//         return `reproduciendo pelicula... ${this.nombre}`
//     }
// }

//console.log(PeliculaUno.reporoducir());

class Pelicula{

    constructor(nombre,id){
        this.nombre = nombre;
        this.id = id;
    }
    reproducir(){
        return `reproduciendo pelicula... ${this.nombre}`;
    }
}

class Serie extends Pelicula{ //! Al colocar la palabra extends hacemos uso de la herencia en poo
    constructor(nombre,id,cap) {
        super(nombre,id);
        this.cap = cap;
    }
    reproducirCapitulo(){
        return `reproduciendo capitulo.....`;
    }
}

const PeliculaUno = new Pelicula("Harry Potter",1);
const PeliculaDos = new Pelicula("Sin potter", 2);
const SerieUno = new Serie("Señor de los anillos",321, 654657)


console.log(PeliculaUno);
console.log(PeliculaDos);
console.log(PeliculaUno.reproducir());
console.log(PeliculaDos.reproducir());
console.log(SerieUno);
console.log(SerieUno.reproducirCapitulo());
