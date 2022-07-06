def area_triangulo():
    return base * altura / 2

print("Programa que calula el area  de un triangulo")
print("Ingresa los siguientes valores")

altura = float(input("Altura:  "))
base = float(input("Base:  "))

print(f"Area = {area_triangulo()}")