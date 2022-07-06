"""
Estructuras_Repetitivas_mientras_4.py
"""
import os
import random

inferior = 1
superior = 100
secreto = random.randint(1,100)
usuario = -1
maquina = -1


while usuario != secreto and maquina != secreto:
    os.system('cls')
    print("Maquina, ¿Cual crees que es el número secreto?:  ")
    maquina = random.randint(inferior,superior)
    print(f"Maquina: {maquina}")
    if maquina < secreto:
        print("Tu numero es menor")
        inferior = maquina + 1
    elif maquina > secreto:
        print("Tu numero es mayor")
        superior = maquina -1
    else:
        print("Ha ganado la maquina")

    if maquina != secreto:
        usuario = int(input("usuario, cual crees que es el numero secreto?:  "))
        if usuario < secreto:
            print("Tu número es menor")
            if usuario > inferior:
                inferior = usuario + 1
        elif usuario > secreto:
            print("Tu número es mayor")
            if usuario < superior:
                superior = usuario 
        else:
            print("El usuario ha ganado.")
    input("Presiona 'ENTER' para continuar")

print("Nos vemos")
