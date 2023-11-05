# Sumador con acumulación de valores en variable que recorre los datos de entrada
valores = [10, 5, 8, 3, 7]
total = 0

for valor in valores:
        total += valor

print(f"El resultado de la suma es: {total}.") # R: 33

# Contador
numeros = [2, 5, 2, 8, 2, 10, 2] # existen 4 numeros 2.
elemento_a_contar = 2
ocurrencias = 0

for elemento in numeros:
        if elemento == elemento_a_contar:
                ocurrencias += 1
print (f"El elemento {elemento_a_contar} aparece {ocurrencias} veces.") # R: El elemento 2 aparece 4 veces.