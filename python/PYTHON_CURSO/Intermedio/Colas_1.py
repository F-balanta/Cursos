import os
import queue
from typing import Tuple

AGENDAR = 1
ATENDER = 2
SALIR = 0

def mostrar_menu():
    os.system("cls")
    print (f"""Mi Agenda
    {AGENDAR}) agendar evento
    {ATENDER}) Atender Evento
    {SALIR}) Slir...""")


def agendar_evento(ag):
    print("                         Agendar evento")
    evento = input("Evento:  ")
    ag.put(evento)


def atender_evento(ag):
    print("                              Atender Evento")
    if ag.empty():
        print("No hay eventos por atender")
    else:
        evento = ag.get()
        print(f"Evento: {evento}")

def main():
    agenda = queue.PriorityQueue()
    continuar = True
    while continuar:
        mostrar_menu()
        opc = int(input("Selecciona una opcion:  "))
        os.system("cls")
        if opc == AGENDAR:
            agendar_evento(agenda)
        elif opc == ATENDER:
            atender_evento(agenda)
        elif opc == SALIR:
            continuar = False
        else:
            print("Op´cion no valida")
        input("Presiona 'Enter' para continuar...")
    print("Nos vemos...")

if __name__ == "__main__":
    main()