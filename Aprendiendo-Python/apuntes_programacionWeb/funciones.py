# 1.- funcion simple
def saludar():
    print("Hola! bienvenido a la función.")
saludar() # llamamos la funcion

# 2.- Funcion con parametros y retorno
def suma(a, b):
    resultado = a + b
    return resultado
resultado_suma = suma(5, 3)
print(resultado_suma)

# 3.- Funcion con parametros predeterminados
def saludar(nombre="Usuario"):
    print(f"¡Hola, {nombre}!")
saludar() # se utiliza valor predeterminado
saludar("Francisco")# Se pasa un valor especifico para el parametro "nombre"

# 4.- Funcion con sentencia de control
def es_positivo(numero):
    if numero > 0:
        return True
    else:
        return False

resultado1 = es_positivo(5)
resultado2 = es_positivo(-2)
print(f"El resultado 1 con valor (5) es: '{resultado1}' y el resultado 2 con valor (-2) es: '{resultado2}'")

# 5.- Función que utiliza otras funciones
def cuadrado(numero):
    return numero ** 2

def suma_cuadrados(a, b):
    cuadrado_a = cuadrado(a)
    cuadrado_b = cuadrado(b)
    resultado = cuadrado_a + cuadrado_b
    return resultado

resultado_suma_cuadrados = suma_cuadrados(2, 3)
print(resultado_suma_cuadrados)