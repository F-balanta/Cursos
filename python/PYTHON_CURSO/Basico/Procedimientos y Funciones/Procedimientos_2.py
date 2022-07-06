"""
Script que solicite el nombre del usuario y le de un saludo personalizado
haciendo uso de un procedimientos
"""

def saludo():
    nombre = input("Hola, ¿como te llama?:  ")
    print("Un gusto conocerte, {}".format(nombre))

saludo()
print()
saludo()
print("Nos vemos")