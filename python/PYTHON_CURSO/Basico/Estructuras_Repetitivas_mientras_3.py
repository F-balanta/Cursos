"""
Estructuras_Repetitivas_mientras_1.py

Script en python que simule el sistema de validacion de datos de una
plataforma digital. Se le solicitara al usuario su nombre y contraseña
mientras la informacion proporcionada no coincida con la información previamente registrada
"""

import os
USER = "F_BALANTA"
PASSWD = "epaepa"

user = ""
password = ""

while USER != user or PASSWD != password:
    os.system('cls')
    print("                  Kit-Kot")
    user = input("Usuario: ")
    password = input("Password: ")

    if USER != user or PASSWD != password:
        print("Credenciales incorrectas")
        print("Intenta de nuevo")
        input("Precsiona enter para continuar...")
else:
    print("Bienvenid@")