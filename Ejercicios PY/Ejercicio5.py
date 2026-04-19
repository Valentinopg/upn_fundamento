edad = int(input("Escribe su edad: "))

if edad >= 18:
    print("Acceso permitido. Bienvenido")

else:
    print("Acceso denegado")
    print(f"Te faltan {abs(18-edad)} años(s) para registrate.")
    

