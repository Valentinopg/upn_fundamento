peso = float(input("Ingrese el peso en kg: "))
estatura = float(input("Ingrese la estatura en metros: "))

imc = peso / (estatura ** 2)
imc_red = round(imc, 2)

print(f"IMC: {imc_red}")

if imc < 18.5:
    print("Bajo peso")

elif imc < 24.9:
    print("Peso normal")

elif imc < 29.5:
    print("Sobrepeso")

else:
    print("Obesidad")

