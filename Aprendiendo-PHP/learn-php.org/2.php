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

// ORDEN DE MATRICES
// sort() Ordena a la inversa la matriz (el utimo pasa a ser el primero)



?>