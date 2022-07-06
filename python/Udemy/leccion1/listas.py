#Definimos una lista de Tipo String
nombres = ['Felipe', 'David' , 'Carlina', 'Vanessa', 'Orianna']

# Imprimimos el contenido de la lista
print()
print("Imprimiendo contenido de la lista")
print()
print(nombres)
print()
# Acceder a los elementos de la lista
print("Elementos de mi Lista")
print()
print(nombres[0])
print(nombres[1])
print(nombres[2])
print(nombres[3])
print(nombres[4])
print()
# Podemos acceder a los elementos de manera inversa
print("Elementos de la lista impresos de manera inversa")
print()
print(nombres[-1])
print(nombres[-2])
print(nombres[-3])
print(nombres[-4])
print(nombres[-5])
print()
print()

# Acceder a un rango

print("Recuperando elementos")
print()
# Imprimimos el indice 0 y el indice 1
print(nombres[0:2]) # Sin incluir el Indice 2
# Accede a los indices 0 , 1 y 2 pero no include el 3
print(nombres[:3])
print()
# Desde el indice indicado hasta el final
print("Imprimimos desde el indice indicado hasta el final")
print(nombres[1:])

print()
# Iterar una lista
print("Imprimimos el contenido de la lista con un ciclo")
for elementos in nombres:
    print(elementos)
else:
    print("NO EXISTEN MAS ELEMENTOS EN LA LISTA")
print()
print()
# Averiguar el tamaño de una lista
print("Cantidad de elementos de una lista")
print(len(nombres))
print()

print("Agregar mas elementos en una lista")
nombres.append('Balantik')
print(nombres)

#insertar un elemento en un indice proporcionado, al hacerlo el resto de los
# elementos se moveran un indice hacia la derecha
print()
print("Insertar un elemento a  una lista")
nombres.insert(1, 'HOLBERTON SCHOOL')
print(nombres)
print()

# Eliminar un elementos de una lista por el valor del indice
print("Eliminar  un elemento de una lista dependiendo del valor")
print()
nombres.remove('HOLBERTON SCHOOL')
print(nombres)
print()

# Podemos remover el ultimo indice de una lista con la funcion pop
print("Eliminar el ultimo indice")
nombres.pop()
print(nombres)
print()

# Eliminar un elemento en un indice indicado
print("Eliminar un indice determinado")
print(nombres)
del nombres[0]
print(nombres)
print()

# limpiar el contenido de una lista
print("Limpar el contenido de una lista")
print(nombres)
nombres.clear()
print(nombres)

# Eliminar una lista de la memoria
print()
print("Eliminar una lista de la memoria, incluida la variable")
print(nombres)
del nombres
prinnt(nombres)
