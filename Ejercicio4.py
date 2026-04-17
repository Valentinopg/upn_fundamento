cat = input("Categoria (A/B/C): ").upper()
horas = float(input("Horas: "))
años = int(input("Años de servicio: "))

if cat == "A":
    tarifa = 33.50

elif cat == "B":
    tarifa = 29.80

elif cat == "C":
    tarifa = 25.70

else:
    print("Categoria invalida")
    exit()

if años <= 3:
    bono = 0.00

elif años <= 10:
    bono = 0.10

elif años <= 17:
    bono = 0.20

else:
    bono = 0.30

print(f"Sueldo: S/. {tarifa * horas * (1 + bono):.2f}")