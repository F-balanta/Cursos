"""
procedimiento_parametros_1.py

Procedimiento que reciba el nombre del usuario y le de un saludo personalizado.
"""
import os

def saludo(nombre):
    print(f"Hola {nombre}, un gusto conocerte.")


usuario = input("Cual es tu nombre?:   ")
saludo(usuario)
print()
saludo("Felipe")
saludo("David")
saludo("Balanta")
print()
print("Bye....")