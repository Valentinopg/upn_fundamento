while True:
    nota = int(input("Ingrese nota (0-20): "))

    if 0 <= nota <= 20:
        break

    else:
        print("Error: nota debe ser entre 0 y 20")

if 18 <= nota <= 20:
    print("Clasificacion: EXCELENTE")

elif 14 <= nota <= 17:
    print("Clasificacion: BUENO")

elif 11 <= nota <= 13:
    print("Clasificacion: REGULAR")

else:
    print("Clasificacion: DESAPROBADO")