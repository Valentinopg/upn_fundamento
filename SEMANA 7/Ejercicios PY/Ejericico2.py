clave_correcta = "UPN2026"
max_intentos = 3
intentos = 0
acceso = False

while True:
    intentos += 1
    clave = input(f"Intentos {intentos}/{max_intentos} - Clave: ")

    if clave == "UPN2026":
        acceso = True

    else:
        restantes = max_intentos - intentos

        if restantes > 0:
            print(f"Clave incorrecta. Queda {restantes} intentos.")

    if acceso or intentos >= max_intentos:
        break

if acceso == True:
    print("Acceso concedido. Bienvenido")

else:
    print("Cuenta bloqueada. Contacte al administador")





        