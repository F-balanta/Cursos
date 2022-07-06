#!/bin/usr/python3

# Los diccionarios son colecciones de datos organizados de la siguiente manera
# Por el lado izquiedo derecho tenemos las llaves  o  keys
# y por el lado derecho tendromos el valor que tiene esa llave

dictionary = {
    'IDE': 'Integrated Development Enviroment',
    'OOP': 'Object  Oriented Programming',
    'DBMS': 'Database Management Systems'
}

print()
print(dictionary)
print()

print("Largo elementos")
print(len(dictionary))

# Para poder accerder a los elementos tenemos que proporcionar directamente la llave
print()
print("Recuperando elementos")
print(dictionary['IDE'])
print()
# Otra forma de recuperar elementos
print("Otra forma de recuperar elementos")
print(dictionary.get('OOP'))
print()

# Modificar elementos de un Diccionarios
# antes
print(dictionary['IDE'])
dictionary['IDE'] = 'integrated develpment environment'
# despues
print(dictionary['IDE'])
print()

#--------------------------
# Imprimir La llave y su contenido
print()
print("Imprimiendo cada llave y su contenido")
for termino, valor in dictionary.items():
    print(termino,": ", valor)
# Para poder acceder al valor que contienen las llaves utilizaremos la funcion items()
print()
print()
print()


# Otra forma de recuperar las llaves
print("Imprimiendo las llaves")
for termino in dictionary.keys():
    print(termino)
print()
print()
print()

#--------------------------------

# Si queremos sacar solo el valor de las llaves:
print("Imprimir solo el valor")
for termino in dictionary.values():
    print(termino)
print()
print()
print()
#--------------------------------
