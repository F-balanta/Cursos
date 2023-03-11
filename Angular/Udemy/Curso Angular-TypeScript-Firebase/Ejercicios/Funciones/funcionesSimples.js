function suma() {
    var numero1 = 5;
    var numero2 = 7;
    var total = numero1 + numero2;
    console.log("La suma es: ", total);
}
suma();
// Funcion con parametros
var sumar3 = function (a, b) {
    var resultado;
    resultado = (a + b);
    console.log("La suma es: ", resultado);
};
sumar3(5, 7);
// Funcion con retorno
var sumar4 = function (a, b) {
    var resultado;
    resultado = (a + b);
    console.log("La suma es: ", resultado);
    return resultado;
};
var resultadoSuma4 = sumar4(5, 10);
