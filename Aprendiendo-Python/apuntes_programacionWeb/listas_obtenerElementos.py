# 1.- Recorriendo la lista con un bucle for
numeros = [1, 2, 3, 4, 5]
print(f"Resultados ejercicio 1:")
for numero in numeros:
    print(numero)
"""
Resultado:
1
2
3
4
5
"""

# 2.- Obteniendo elementos a través de indices
frutas = ['manzana', 'naranja', 'platano', 'uva', 'kiwi', 'piña']
fruta1 = frutas[1]
print(f"La fruta en la posición 1 es: {fruta1}")

# obtener los elementos desde el indice 1 hasta el final
frutas_desde_indice_1 = frutas[1:]
print(f"Resultado desde el indice 1 hasta el final: {frutas_desde_indice_1}")

# Obtener los elementos den un rango especifico
frutas_rango = frutas[1:3]
print(f"Resultado desde del rango 1:3: {frutas_rango}")

# 3.- Recorriendo la lista con un bucle while y un contador
letras = ['a', 'b', 'c', 'd', 'e']
# recorremos la lista utilizando un bucle while y un contador
indice = 0
print(f"Resultados ejercicio 3:")
while indice < len(letras):
    letra = letras[indice]
    print(letra)
    indice += 1

# 4.- Obteniendo elementos con la función enumerate()
colores = ['rojo', 'verde', 'azul', 'naranja']

# utilizar la función enumerate() para obtener el índice y el elementos
for indice, color in enumerate(colores):
    print(f"Indice {indice}: {color}")