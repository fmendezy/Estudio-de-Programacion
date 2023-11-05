# Ejemplo 1: POP
numeros = [10, 20, 30, 40, 50]
elemento_eliminado = numeros.pop(2) # Eliminamos el 30. ( por estar en la posicion 2)
print(f"Ejemplo 1 Pop, Resultado: {numeros} - Elemento eliminado: {elemento_eliminado}")

# Ejemplo 2: POP
nombres = ['Francisco', 'Alicia', 'Melisa', 'Valentina', 'Luna']
elemento_eliminado = nombres.pop(4) # 'Luna'
print(f"Ejemplo 2 Pop, Resultado: {nombres} - Elemento eliminado: {elemento_eliminado}")

# Ejemplo 3: POP
colores = ['rojo', 'verde', 'azul']
elemento_eliminado = colores.pop(1)
print(f"Ejemplo 3 Pop, Resultado: {colores} - Elemento eliminado: {elemento_eliminado}")

# ******************
# REMOVE

# Ejemplo 1: REMOVE
numeros = [10, 20, 30, 40, 30, 50]# notese que esta repetido el '30'
numeros.remove(30)
print(f"Ejemplo 1 Remove, Resultado: {numeros}")


# Ejemplo 2: REMOVE
nombres = ['Ana', 'Juan', 'Maria', 'Pedro', 'Ana', 'Luis']# Notese que se reoute Ana
nombres.remove('Ana')
print(f"Ejemplo 2 Remove, Resultado: {nombres}")

# Ejemplo 3: REMOVE
colores = ['rojo', 'verde', 'azul', 'verde']
colores.remove('verde')
print(f"Ejemplo 3 Remove, Resultado: {colores}")