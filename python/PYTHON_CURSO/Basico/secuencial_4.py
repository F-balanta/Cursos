"""
Script que solicite al ususario dos números y posteriormente muestre la suma de ambos numeros
"""

N1 = input("Digita numero 1: ")
N2 = input("Digita numero 2: ")
# En la linea 8 convierto los valores almacenados en la variables N1 y N2 en un  dato entero
suma = int(N1) + int(N2)
resta = int(N1) - int(N2)
multi = int(N1) * int(N2)
div = int(N1) / int(N2)
print("La suma de ambos valores es de: ", suma)
print("La resta de ambos valores es de: ", resta)
print("La multiplicacion de ambos valores es de: ", multi)
print("La Division de ambos valores es de: ", div)