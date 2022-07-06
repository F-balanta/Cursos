"""
Estructuras_Repetitivas_FOR_5.py
"""
import os
for numero in range(1,11,):
    os.system('cls')
    print(f"                         Tabla de multiplicar del {numero}")
    for multiplo in range(1,11):
        print(f"{numero} X {multiplo} = {numero * multiplo}")
    input("Presiona 'ENTER' para continuar.")
print("BYE BYE...........")
