"""
Selectiva_simple_2.py
script en python que genere un numero aleatorio entre 1 y 10
y le pida al usuario que intente adivinarlo. Si adivina el número,
el usuario sera felicitado por su logro.
"""

"""#importamos un modulo llamado random"""
# Me permite generar un numeor random
import random

secreto = random.randint(1,10)

print("Acabo de generar un número aleatorio en tre 1 y 10")
input()
print("INTENTA ADIVINARLO!!")

numero = int(input("Cual crees que es el número?: "))

if numero == secreto:
    print("Excelente lo hiciste bien. :)")
print("El numero secreto es el: ", secreto)
print("Suerte para la proxima :(")
