"""
procedimientos_4.py

Mostrar un menú ciclico
"""

import os

ESP = 1
ING = 2
NO_SUBS = 3
SALIR = 4

def mostrar_menu():
    print(f"""                                  SUBTITULOS
    {ESP}) Español
    {ING}) Ingles
    {NO_SUBS}) Sin Subtitulos
    {SALIR}) Salir
    """)

continuar = True
while continuar:
    os.system('cls')
    mostrar_menu()
    opc = int(input("Selecciona una opcion: "))
    if opc == ESP:
        os.system('cls')
        print("Subtitulos en español")
    elif opc == ING:
        print("Subtitulos en ingles")
    elif opc == NO_SUBS:
        print("Sin Subtitulos")
    elif opc == SALIR:
        continuar = False
    else:
        print("Opcion Invalia.")
    input("Presiona 'Enter' para continuar")

print("Bye...")