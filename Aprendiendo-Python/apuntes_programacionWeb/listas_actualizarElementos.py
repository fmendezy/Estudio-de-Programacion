# 1.- Recorriendo la lista con un bucle for y actualizando con índices
numeros = [1, 2, 3, 4, 5]
for i in range(len(numeros)):
    numeros[i] *= 2 # multiplicar cada número por 2 para actualizarlo

# Resultado: [2, 4, 6, 8, 10]
print(f"Resultados ejercicio 1: {numeros}")

# 2.- Recorriendo la lista con un bucle for y actualizando con elementos
palabras = ['Hola', 'mundo', 'Python']

# Recorrer la lista con un bucle for y actualizar cada palabra
for i, palabra in enumerate(palabras):
    palabras[i] = palabra.upper()# Convertir cada palabra en mayusculas
print(f"Resultados ejercicio 2: {palabras}")

# 3.- Recorriendo la lista con un bucle while y actualizando los indices
numeros = [1, 2, 3, 4, 5]

indice = 0
while indice < len(numeros):
    numeros[indice] += 1 # Sumar 1 a cada numero para actualizarlo
    indice += 1
print(f"Resultados ejercicio 3: {numeros}")

# 4.- Creando copias de listas para respaldo (desarrollo propio)
numeros = [1, 2, 3, 4, 5]
indice = 0
respaldo = numeros[:]# respaldo de lista tambien sirve: respaldo = list(numeros2)
while indice < len(numeros):
    numeros[indice] += 1
    indice += 1
print(f"Resultados ejercicio 4 (igual al 3): {numeros} \nLista respaldada ejercicio 4: {respaldo}")