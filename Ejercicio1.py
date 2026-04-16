monto = float(input("Ingrese el monto: "))
descuento = 0

if monto > 100:
    descuento = monto * 0.10


total = monto - descuento

print(f"Descuento aplicado: S/. {descuento:.2f}")
print(f"Total a pagar: S/. {total:.2f}")