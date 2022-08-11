let objeto = {
    Nombre: "Juan Felipe",
    Apellido: "Balanta Rentería",
    Edad: 22,
    Email: "jf.balanta@hotmail.com",
    MayorEdad: Boolean(true),
    DineroAhorrado:350.000,
    Deudas: 220.000
}

let {Nombre, Apellido} = objeto;
let dinero = objeto.DineroAhorrado - Deudas;
console.log(Nombre, Apellido, dinero);