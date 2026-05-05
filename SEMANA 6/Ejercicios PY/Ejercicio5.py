print("Deposito inicial: S/ ")
saldo = float(input(""))
print("Meta a alcanzar: S/")
meta = float(input(""))

tasa = 0.015
meses = 0

print("Mes 0: S/", saldo)

while saldo < meta:
    saldo = saldo * (1 + tasa)
    meses += 1

    print(f"Mes {meses}: S/ {saldo:.2f}")

print("Alcanzara la meta en", meses, "meses")