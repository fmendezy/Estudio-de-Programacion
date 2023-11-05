"""
# break
numero = 0
while numero < 10:
        if numero == 5:
            break # se detiene el bucle cuando numero es igual a 5
        print(numero)
        numero += 1
"""

"""
# exit
nombre = input("Ingrese su nombre: ")
if nombre == "admin":
    print("Acceso concedido.")
else:
    print("Acceso denegado.")
    exit() # El programa se detendrá aqui sin imnportar el resultado
"""

# continue
for numero in range(1, 6):
        if numero == 3:
                continue # Se omite la iteración cuando numeros es igual a 3
        print(numero)