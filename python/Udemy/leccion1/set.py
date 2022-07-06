# Colección de tipo set, a diferencias de las tuplas y las listas estos no mantienen un orden
# Tampoco permite almacenar elementos duplicados, pero es posible agregar elementos o eliminarlos.

#set planetas
print("Elementos  Colección tipo Set")
print()
planetas = {'Marte', 'Venus', 'Jupiter'}
# No necesariamente se va a imprimir con el mismo orden
print(planetas)
print()
# Largo de los elementos
print("Largo de los elementos")
print(len(planetas))

# Revisar si un elemento está presente
print("Vamos a preguntar si la el planeta marte se encuentra", end=" ")
print("dentro de nuestro set")
print()
print('Marte' in planetas)
print()

# Agregar un elemento
print(planetas)
planetas.add('Tierra')
print(planetas)
print()

# La coleccion de datos tipo SET no permite elementos duplicados
print(planetas)
planetas.add('Tierra')
print(planetas)
print()


# Eliminar elementos posiblemente arrojando un erros si no encuentra la llave {KEY}
print(planetas)
planetas.remove('Tierra')
print(planetas)

# Otra forma de iliminar
planetas.discard('Jupitar')
# Elimina si es exacto el valor entregado, si no, no lo eliminara y no arrojara error en caso de no encontrar el elemento
print(planetas)
print()
# Limpiar SET
planetas.clear()
print("Set Vacio!!")
print(planetas)
print()


# Eliminar por completo el SET, utilizamos la funcion del, posteriormente la variable que apunta a nustro set
del planetas
print()
#Si intentas imprimir despues de haber eliminar la variable que apuntaba a ese set saldra error, ya que no podemos acceder a ella.
print(planetas)
