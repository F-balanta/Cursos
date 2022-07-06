"""
Diseñe un código en Python para calcularla longitud de la hipotenusa (es decir, el lado máslargo
de un triángulo rectángulo, el opuesto al ángulo recto) utilizando el Teorema de Pitágoras:
"""


def hipotenusa(num1: int, num2: int):
    result = (num1 ** 2) + (num2 ** 2)
    return result


if __name__ == "__main__":
    print(hipotenusa(3, 2))

