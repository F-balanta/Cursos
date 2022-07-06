"""
Selectiva_simple_1.py
Evaluar edad del usuario
"""

usuario = ("Digita tu nombre: ")
edad = int(input("Cuantos años tienes?: " ))
if edad >= 18:
    print(f"Felicidades!! Sr. {usuario} eres mayor de edad :)")
else:
    print("Que hace aquí?")
    input()
    print("Vaya pa' la casa hpta")