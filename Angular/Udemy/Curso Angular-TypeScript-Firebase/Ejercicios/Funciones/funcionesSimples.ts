function suma(){
    var numero1:number = 5;
    var numero2:number = 7;

    var total:number = numero1 + numero2;

    console.log("La suma es: ",total);
}

suma();

// Funcion con parametros
const sumar3 = function(a:number, b:number){
    var resultado:number;
    resultado = (a + b);
    console.log("La suma es: ", resultado);		
}
sumar3(5,7)


// Funcion con retorno
const sumar4 = function(a:number, b:number) : number{
    var resultado:number;
    resultado = (a + b);
    console.log("La suma es: ", resultado);		
    return resultado;
}
const resultadoSuma4 = sumar4(5,10);