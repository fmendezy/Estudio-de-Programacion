<?php

/* ***************************************************
    1° Variables con NULL y concatenación más simple
*/
$nombre = "Pancho";
$apellido = NULL;// Valor numero

echo "Hola $nombre tu apellido es $apellido\n";// concatenación dentro de un echo

/* ***************************************************
    2° Matrices - Arrays - Listas
*/
$numeros_array = [1,3,5,7,9,11];
$primer_numero = $numeros_array[0];// Obtiene el primer valor del array.
$ultimo_numero = $numeros_array[count($numeros_array)-1];// Obtiene el ultimo valor del array, importante el -1
echo "El primer numero del array es '$primer_numero' y el último es '$ultimo_numero'.\n";

// Agregando variables al array usando su indice
$numeros_array[6] = 13;// Agrego al slot numero 6, el valor 13.
print_r($numeros_array[6]);// Imprimo para verificar.

// Eliminando variables en un array especificando desde el indice.
unset($numeros_array[0]);// Eliminamos el valor "1" que se encuentra en la posición "0" del array.
print_r($numeros_array);// Imprimimos todo el array para verificar

// Funciones útiles

// count() - Cuenta el numero de elementos dentro del array
echo count($numeros_array) . "\n";// (6) - 3,5,7,9,11,13 (recordemos que el 13 se agrego en linea 20)

// reset() - Establece el indice del primer elemento del array
$primer_elemento = reset($numeros_array);
echo $primer_elemento . "\n";// (3) es el primer elemento

// También se puede obtener así:
$numeros_array = [1,3,5,7,9,11]; // define los numeros
$primer_elemento = $numeros_array[0];
echo $primer_elemento . "\n";// (1) es el primer elemento

// end() obtiene el ultimo elemento del array
$numeros_array = [1,3,5,7,9,11]; // define los numeros
$ultimo_item = end($numeros_array);
echo $ultimo_item . "\n";// (11) es el ultimo item

// también se puede obtener así
$numeros_array = [1,3,5,7,9,11]; // define los numeros
$ultimo_item = count($numeros_array) - 1;
$ultimo_item = $numeros_array[$ultimo_item];
echo $ultimo_item . "\n";// (11) es el ultimo item

// array_push() - Agrega un elemento al final del array
$numeros_array = [1,2,3]; // define los numeros
array_push($numeros_array, 4);// agregamos el numero 4 en el ultimo espacio, es decir el slot 3.
print_r($numeros_array);

// array_pop() - Elimina un elemento al final del array
$numeros_array = [1,2,3,4,5,6]; // define los numeros
array_pop($numeros_array);
print_r($numeros_array);// muestra hasta el 5.

// array_unshift() Agrega un elemento al comienzo del array
$numeros_array = [1,2,3,4,5,6];
array_unshift($numeros_array, 0);// Agregamos un 0 al comienzo, slot 0
print_r($numeros_array);// muestra que se inicia con 0

// Ahora lo contrario, para ELIMINAR el primer elemento de la lista
// array_shift()
$numeros_array = [1,2,3];
array_shift($numeros_array);
print_r($numeros_array);// muestra solo 2 y 3


// CONCATENACIÓN DE MATRICES
// array_merge(array1, array2) - Concatena dos arrays
$primer_array = ['a','b','c'];
$segundo_array = ['d','e','f'];
$array_concatenado = array_merge($primer_array, $segundo_array);
print_r($array_concatenado);// Muestra a, b, c, d, e, f en un solo array

/*
    ORDEN DE MATRICES
    sort() reOrdena todos los elementos dentro del array.
    Caso con numeros: De menor a mayor
    Caso con palabras: Alfabeticamente de la A a la Z
*/
$numeros = [4,2,3,1,5];// Lista desordenada
sort($numeros);
print_r($numeros);// Devuelve "1,2,3,4,5" (ordenado)

$palabras = ["Burro", "Arbol", "Casa", "Dedo"];// Lista desordenada
sort($palabras);
print_r($palabras);// Devuelve "Arbol, Burro, Casa, Dedo" (ordenado)

// Funciones avanzadas de matrices
// array_slice() - Muestra en pantalla, como seria eliminando los primeros x elementos, y los que quedan les ajusta el indice.
$numeros = [1,2,3,4,5,6];
print_r(array_slice($numeros, 3));// elimina el 1,2,3 (es decir 3 elementos) y muestra en posición [0], el 4, en [1] el 5 y asi.
//print_r($numeros); // Demostración que no genera cambios permanente en el array


// otra forma, 
$numeros_array = [1,2,3,4,5,6];
print_r(array_slice($numeros_array, 3,2));// resultado 4 [3] y 5 [4]

/* 
Ejercicio:
1.- Cree una nueva matriz que contenga los números pares 2, 4, 6, 8 y 10.
El nombre de la nueva matriz debe ser $even_numbers
2.- Concatene las matrices y para crear la matriz.
$male_names
$female_names
*/

// Ejercicio 1
$even_numbers = [2, 4, 6, 8, 10];

// Ejercicio 2
$male_names = ["Francisco", "Carlos", "Pablo"];
$female_names = ["Auralia","Karla","Natalia"];
$resultado = array_merge($male_names,$female_names);
print_r($resultado);

?>