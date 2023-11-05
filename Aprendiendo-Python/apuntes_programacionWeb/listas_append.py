# NUMEROS
# Lista inicial
numeros = [1, 2, 3, 4]

# Agregamos el numero 5 al final de la lista
numeros.append(5)

# Revisamos resultados
print(f"Append con numeros: {numeros}") # Append con numeros: [1, 2, 3, 4, 5]

# ******************
# TEXTO
frutas = ['manzana', 'naranja', 'plátano']

# Agregar una nueva fruta al final de la lista
frutas.append('uva')

# Revisamos resultados
print(f"Append con String: {frutas}") #  ['manzana', 'naranja', 'plátano', 'uva']

# ******************
# LISTAS DENTRO DE OTRA LISTA
lista_anterior = [1, 2, 3] # Lista inicial

# Lista que se agregará al final de lal ista inicial
lista_nueva = [4, 5, 6]

# Agregar la lista_nueva al final de lista_anterior
lista_anterior.append(lista_nueva)

# Revisamos resultados
print(f"Append con Lista Interior: {lista_anterior}") # [1, 2, 3, [4, 5, 6]

# ******************
# CON BOOLEANOS
valores = [True, False]

# Agregamos un nuevo valor booleano al final de la lista
valores.append(True)

# Revisamos resultados
print(f"Append con Booleanos: {valores}") # [True, False, True]

# ******************
# CON OBJETOS COMPLEJOS
datos = [{'nombre': 'Francisco', 'edad': 29}, {'nombre': 'Magdalena', 'edad': 46}]

# Agregar un nuevo diccionario al final de la lista
datos.append({'nombre': 'Auralia', 'edad': 29})

# Revisamos resultados
print(f"Append con Objetos COmpletjos: {datos}") # [{'nombre': 'Francisco', 'edad': 29}, {'nombre': 'Magdalena', 'edad': 46}, {'nombre': 'Auralia', 'edad': 29}]