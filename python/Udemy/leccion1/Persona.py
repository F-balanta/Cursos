"#!/bin/usr/python3"

class personas:
    """ 
    __init__ es un metodo especial para inicializar una clase por primera vez
    Atraves del metodo inicializador __init__ tenemos que recibir una referencia de objeto que vamos a crear "self"
    """
    def __init__(self):
        """Con la palabra self vamos a crear los atributos de nuestra clase
        nombre apellido y edad"""
        self.nombre = 'Felipe'
        self.apellido = 'Balanta'
        self.edad = 22
"""Creamos una  referencia del objeto a la vartiable persona1 """
persona1 = personas()
print(persona1.nombre)
print(persona1.apellido)
print(persona1.edad)

