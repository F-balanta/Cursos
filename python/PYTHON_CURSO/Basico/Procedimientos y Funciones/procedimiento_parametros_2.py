"""

Procedimientos con parametros 2

En un procedimiento solicitar al susario su nombre y edad, validar si es mayor o menor de edad.
"""

def persona(Nombre, Edad):
    if Edad >= 18:
        print(f"Hola {Nombre}, que tal?")
        print("Veo que ya eres mayor de edad.")
    else:
        print(f"Hola {Nombre},no eres mayor de edad...")

nombre = input("Digita tu nombre:  ")
edad = int(input("Digita tu edad:  "))
persona(nombre,edad)

print()
print("Bye...")

