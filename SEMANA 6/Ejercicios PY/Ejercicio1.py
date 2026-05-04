saldo = 1000
retiros = 0

print("=== Cajero Automáctico ===")
print(f"Saldo disponible: S/{saldo:.2f}")

monto = float(input("Monto a retirar (0 para salir): "))

while monto != 0:
    if monto < 0:
        print("Error: monto invalido")

    elif monto > saldo:
        print("Error: saldo insuficiente")

    else:
        saldo -= monto
        retiros += 1

        print(f"Retiro exitoso. Saldo: S/{saldo:.2f}")

    monto = float(input("Monto a retirar (0 para salir): "))

print("---Resumen---")
print(f"Retiros realizados: {retiros}")
print(f"Saldo final: S/{saldo:.2f}")
