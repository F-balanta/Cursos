"""
script en python que le pregunte al usuario la cantidad de numeros
a registrar, le solicite dichos valores y finalmente imprima
el promedio de los mismos.
"""
Estructuras_Repetitivas_FOR_5.py
acumulador = 0
print("Vamos a calcular un promedio")
total_datos = int(input("Cuantos datos deseas registrar?:  "))

for valor in range(total_datos):
    numero = int(input(f"Ingresa elvalor {valor + 1}: "))
    acumulador += numero

promedio = acumulador / total_datos
print(f"El promedio es: {promedio}")
