#!/bin/usr/python3

##Aprendiendo Sobre Ciclos


#Ciclo While - Numeros del 0 al 10

number = 0
while number <= 10:
    print(number)
    number = number + 1
print()
#Cilo For

for elem in range(0,10):
    print(f'{elem}',end="")
    number += 1
print()
print()
cadena = 'Holberton School'

for elems in cadena:
    print("{:s}".format(elems), end="")
