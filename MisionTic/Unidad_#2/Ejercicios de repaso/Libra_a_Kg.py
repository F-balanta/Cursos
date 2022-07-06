"""
* Diseñar un algoritmo que lea el peso de una persona en libras y devuelva su peso en kilogramo.

* 1 libra equivale a 0.453592 kilogramos.
"""


def kilos(libra):
    resultado = libra * 0.45359237
    print(f"Su peso en Kg es de: {resultado}")


if __name__ == "__main__":
    kilos(5)
