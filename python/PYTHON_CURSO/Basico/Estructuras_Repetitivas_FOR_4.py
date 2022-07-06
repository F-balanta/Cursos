"""
Estructuras_Repetitivas_FOR_1.py
"""
import os

numero = int(input("De que numero deseas ver la tabla de multiplicar:  "))
limite = int(input("Hasta que multiplo deseas ver?:  "))

os.system('cls')
print(f"                  Tabla del {numero}")
for multiplo in range(1, limite + 1):
    print(f"{numero} X {multiplo} = {numero * multiplo}")
