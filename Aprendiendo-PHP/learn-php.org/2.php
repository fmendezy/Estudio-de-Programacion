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
$numeros_array = [1,3,5,7,9,11]; // Define the $numeros_array variable
$primer_elemento = $numeros_array[0];
echo $primer_elemento . "\n";// (3) es el primer elemento



/* ***************************************************
    3° Funciones
*/


?>