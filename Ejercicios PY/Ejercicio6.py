promedio = float(input("Escriba su promedio (0-20): "))

if promedio < 0 or promedio > 20:
    cali = "Valor inválido"

elif promedio <= 5:
    cali = "Deficiente"

elif promedio <= 10:
    cali = "Regular"

elif promedio <= 14:
    cali = "Bueno"

else:
    cali = "Excelente"

print(f"Tu calificacion es: {cali}")