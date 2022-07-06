"""dic = {}
dic["item1"] = 1
dic["item2"] = 2
dic["item3"] = 3
dic["item4"] = 4
dic["item5"] = 5
dic["item6"] = 6
print(dic)

a = "                    hola hola hola hola"
print(a.strip())
print(a.replace("ho", "HO"))
print(dir(a))"""

def cliente(informacion:dict):
    resultado = informacion
    return resultado
inf = {}
inf["id_cliente"]=int(input("Digite el ID: "))
inf["nombre"] = input("Digite el nombre: ")
inf["edad"]= int(input("Digite la edad: "))
inf["primer_ingreso"] = bool(input("Es primer Ingreso (1 si, '' no: "))
a = cliente(inf)
print(a)