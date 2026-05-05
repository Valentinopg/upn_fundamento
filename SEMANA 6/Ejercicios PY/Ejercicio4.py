import random
secreto = random.randint(1, 50)

intentos = 0
max_intentos = 7
adivino = False

print("Adivina el numero entre 1 y 50. Tienes 7 intentos.")

while intentos < max_intentos and not adivino:
    intentos += 1

    intento = int(input(f"Intento {intentos}: "))

    if intento == secreto:
        adivino = True

    elif secreto > intento:
        print("El numero secreto es MAYOR.")

    else:
        print("El numero secreto es MENOR")

if adivino == True:
    print(f"Ganaste en {intentos} intentos.")
else:
    print(f"Perdiste. El numero era {secreto}")