<?php

// Variables distintas
$nombre = "Pancho";
$apellido = NULL;// Valor numero

echo "Hola $nombre tu apellido es $apellido\n";// concatenación dentro de un echo

// Matrices
$numeros_array = [1,3,5,7,9];
$primer_numero = $numeros_array[0];// Obtiene el primer valor del array.
$ultimo_numero = $numeros_array[count($numeros_array)-1];// Obtiene el ultimo valor del array, importante el -1
echo "El primer numero del array es '$primer_numero' y el último es '$ultimo_numero'.";


?>