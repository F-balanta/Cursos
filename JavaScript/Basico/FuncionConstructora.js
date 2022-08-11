function auto(marca, modelo,annio) {
     this.modelo = modelo;
     this.marca = marca;
     this.annio = annio;
}

var autonuevo = new auto("Tesla","Model 3", 5)

var listaAutos = [new auto("Model 3", 5),
    new auto("Model 4", 5),
    new auto("Model 5", 5),]