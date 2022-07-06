"""
Funcion para calcular el area de un traingulo
"""


def area_triangulo():
    base = float(input("Base: "))
    altura = float(input("Altura: "))
    area = (base * altura) / 2

    return area

print("Programa para calcular el área de un triangulo")

a = area_triangulo()
print(f"Área = {a}")