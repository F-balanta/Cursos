"""
Procedimiento_main.py
"""

def saludo(nombre):
    print(f"Hola {nombre}, es un gusto conocerte")

def main():
    usuario = input("Hola como te llamas?:  ")
    saludo(usuario)

if __name__ == "__main__":
    main()