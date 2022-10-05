
let Habilidades: string[] = ['Bash', 'Counter', 'Healing']

interface IPersonaje {
    puebloNatal: string;
    nombre: string;
    hp: number;
    habilidades: string[];
}

const personaje: IPersonaje = {
    nombre : 'strider',
    hp: 100,
    habilidades : ['Bash', 'Counter', 'Healing'],
    puebloNatal: ''
}

personaje.puebloNatal = 'Pueblo Paleta';

console.table(personaje);






