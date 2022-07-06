"""
Procedimientos_3

Dentro de un procedimiento solicite el nombre y la edad de un usuario, indicar si es mayor o menor de edad
"""
import os

def persona():
    os.system('cls')
    nombre = input("Cual es tu nombre?:  ")
    edad = int(input("Digita tu edad:  "))

    if edad < 18:
        print()
        print("No has cumlpido la mayoría de edad")
    else:
        print()
        print("Felicidades, eres mayor de edad")

persona()
print()
print("Bye...")