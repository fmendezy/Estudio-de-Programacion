try:
    # Intentamos ejecutar algún código que podría generar una excepción
    numero = int(input("Por favor, ingresa un número: "))
    resultado = 10 / numero
    print("El resultado es:", resultado)

except ZeroDivisionError:
    print("¡Error! No puedes dividir por cero.")
except ValueError:
    print("¡Error! Debes ingresar un número válido.")
except Exception as e:
    print("Se ha producido un error inesperado:", e)