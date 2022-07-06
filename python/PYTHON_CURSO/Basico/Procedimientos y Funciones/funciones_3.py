"""
Convertir grados fahrenheit a celclius
"""

def fahrenheit_a_celius():
    f = float(input("Grados fahrenheit:  "))
    c = (f-32) / 1.8
    return c

print("Programa que convierte grados fahrenheit a celclius")
celclius = fahrenheit_a_celius()
print("Resultado: {}".format(celclius))