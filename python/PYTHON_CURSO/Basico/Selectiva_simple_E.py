"""
Selectiva_simple_E.py
Script en python que implemente un sistema de redondeo de
calificaciones. el usuario que es el encargado de ingresar su
calificacion. Si a la calificacion le faltan 4 unidades o menos
para el siguiente multiplo de 10, entonces su calificación será
rodeondeada al siguiente multiplo de 10, en caso contrario lambdacalificacion no es modificada.
"""
"""Solo puedes usar un IF"""

nota = int(input("Digite su nota: "))
residuo = nota % 10

if  0 <= nota <= 100 and residuo >= 6:
    nota = nota + (10 - residuo)
    print(f"Su nota es {nota}")

print("Tu calificacion no amerita redondeo")