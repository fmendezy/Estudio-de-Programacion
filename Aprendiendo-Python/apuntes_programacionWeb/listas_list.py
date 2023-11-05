# Cadena de texto
cadena = "Hola, mundo!"

# Convertir el contenido de la variable en una lista de caracteres
lista_caracteres = list(cadena)

# Revisamos resultados
print(f"Resultado con Cadena de texto: {lista_caracteres}")# ['H', 'o', 'l', 'a', ',', ' ', 'm', 'u', 'n', 'd', 'o', '!']

# ******************
# CONVERTIR TUPLA EN LISTA
tupla_numeros = (1, 2, 3, 4, 5)

# COnvertir la tupla en una lista
lista_numeros = list(tupla_numeros)
# Revisamos resultados
print(f"Resultado con tupla: {lista_numeros}") # [1, 2, 3, 4, 5]

# ******************
# CONVERSION DE UN RANGO EN UNA LISTA
rango_numeros = range(1, 6)
lista_numeros = list(rango_numeros)
print(f"Resultado con Rangos: {lista_numeros}")# [1, 2, 3, 4, 5]

# ******************
# CONVERSION DE UN DICCIONARIO EN UNA LISTA
diccionario_frutas = {"manzana": 3, "naranja": 2, "platano": 5}

lista_frutas = list(diccionario_frutas.keys())# CLAVES
print(f"Resultado con Diccionario (claves): {lista_frutas}") #  ['manzana', 'naranja', 'platano']

lista_cantidades = list(diccionario_frutas.values())# VALORES
print(f"Resultado con Diccionario (valores): {lista_cantidades}") # [3, 2, 5]