"#!/bin/usr/python3"

class personas:

    """Haremos lo mismo pero con parametros"""
    def __init__(self, nombre, apellido, edad):
        self.nombre = nombre
        self.apellido = apellido
        self.edad = edad

persona1 = personas('Juan', 'Felipe',22)
print(persona1.nombre)
print(persona1.apellido)
print(persona1.edad)
print()
print()
persona2 = personas('David','Balanta', 22)
print(f'Objeto Persona 1: {persona1.nombre} {persona1.apellido} {persona1.edad}')
print(f'Objeto Persona 2: {persona2.nombre} {persona2.apellido} {persona2.edad}')