print("--Promedio final del alumno--")
exa_parc = float(input("Ingrese su examen parcial: "))
exa_fin = float(input("Ingrese su examen final: "))
p1 = float(input("Ingrese su practica 1: "))
p2 = float(input("Ingrese su practica 2: "))
p3 = float(input("Ingrese su practica 3: "))

if exa_parc < 0 or exa_parc > 20 or exa_fin < 0 or exa_fin > 20 or p1 < 0 or p1 > 20 or p2 < 0 or p2 > 20 or p3 < 0 or p3 > 20:
    print("Hay una nota invalida")
    quit()

prom_prac = (p1 + p2 + p3 - min(p1, p2, p3))/2
prom_final = (exa_parc + exa_fin + prom_prac)/3

if prom_final >= 18:
    dese = "Excelente"

elif prom_final >= 14:
    dese = "Bueno"

elif prom_final >= 10:
    dese = "Regular"

else:
    dese = "Deficiente"

print(f"Promedio de practicas: {round(prom_prac, 2)}")
print(f"Promedio final: {round(prom_final, 2)} | Su desempeño fue {dese}")