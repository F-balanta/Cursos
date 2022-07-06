"""
Calcular IMC
"""
def calcular_IMC():
    peso = float(input("Peso: "))
    estatura = float(input("Estatura: "))
    imc = peso / (estatura ** 2)
    return imc

print("Vamos a calcular tu IMC")
imc = calcular_IMC()
print("")
print(f"Tu indice de masa corporla es: {imc :.4f}")