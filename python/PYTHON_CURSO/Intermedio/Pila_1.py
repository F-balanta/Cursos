"""
Solicita al usuario una expresion aritmetica  y el programa debe indicarle si
dicha expresion tiene la misma cantidad de parentesis y corchetes
"""

def validar_expresion(expresion):
    pila = []
    for simbolo in expresion:
        if simbolo == "(":
            pila.append("(")
        elif simbolo == ")":
            if len(pila) > 0:
                pila.pop()
            else:
                return False
    return len(pila) == 0

def main():
    print ("Escribe una expresion aritmetica")
    e = input("Expresion: ")
    valida = validar_expresion(e)
    if valida:
        print("La expresion esta balanceada")
    else:
        print("La expresion no esta balanceada")
    print("Nos vemos...")

if __name__ == "__main__":
    main()