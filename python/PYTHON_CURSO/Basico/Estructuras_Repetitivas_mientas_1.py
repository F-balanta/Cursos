"""
Estructuras_Repetitivas_mientras_1.py
script en python que sume los valores pares y multiplique los valores impares
mientras el usuario no ingrese un 0. Se debera utilizar la estructura repetitiva
"Mientras" para solicitar al usuario un numero y dependiendo del número lo suma o lo multiplica.
"""
print()
print("Suma los  valores Pares y Multiplica los valores impares")

suma = 0
multiplicacion = 1
numero = 1

while numero != 0:
    numero = int(input("Ingresa un número (0 para salir.): "))
    if numero % 2 == 0:
        suma += numero
    else:
        multiplicacion *= numero
    
    print(f"suma: {suma}")
    print(f"Multiplicacion: {multiplicacion}")
print("Nos vemos")