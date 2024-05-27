<?php
/*
    Bucles While
    https://www.learn-php.org/en/While_Loops
*/

// Ejemplo de bucle while
$counter = 0;

while ($counter < 10) {// mientras el contador sea menor a 10
    $counter += 1;
    echo "Ejecutando - el contador es $counter.\n";
}

echo "\n* * * * * * * * * *\n";
/*
    La principal diferencia entre los bucles for y while es que los bucles for se utilizan para
    iterar sobre un array o un objeto, mientras que un bucle while se ejecutará un número desconocido de veces,
    dependiendo de las condiciones de las variables (por ejemplo, hasta que un usuario haya ingresado la entrada correcta).
*/

/*
Declaraciones de Flujo
Los bucles pueden ser controlados usando las declaraciones de flujo break y continue.
*/

//Declaración continue
$counter = 0;
while ($counter < 10) {
    $counter += 1;

    if ($counter % 2 == 0) {
        echo "Saltando el número $counter porque es par.\n";
        continue;
    }
    echo "Ejecutando - el contador es $counter.\n";
}

echo "\n* * * * * * * * * *\n";
// Declaración break
$counter = 0;

while ($counter < 10) {
    $counter += 1;

    if ($counter > 8) {
        echo "El contador es mayor que 8, deteniendo el bucle.\n";
        break;
    }

    if ($counter % 2 == 0) {
        echo "Saltando el número $counter porque es par.\n";
        continue;
    }

    echo "Ejecutando - el contador es $counter.\n";
}
echo "\n* * * * * * * * * *\n";

/*
Ejercicio
Usa un bucle while para imprimir todos los números impares en un array. 
Usa la declaración continue para evitar imprimir números pares. 
Recuerda usar la secuencia de caracteres \n al final de la declaración echo para continuar en la siguiente línea.

Tip: para verificar si un número es par, verifica si el número módulo 2 es igual a cero ($number % 2 == 0).
*/
// TODO: Imprimir solo números impares
$numbers = [56, 65, 26, 86, 66, 34, 78, 74, 67, 18, 34, 73, 45, 67, 75, 10, 60, 80, 74, 16, 86, 34, 12, 23, 42, 72, 36, 3, 73, 9, 92, 81, 94, 54, 97, 74, 45, 55, 70, 94, 96, 81, 86, 86, 84, 4, 32, 8, 96, 86, 87, 18, 84, 87, 59, 48, 32, 90, 17, 22, 82, 79, 66, 28, 17, 14, 80, 83, 66, 36, 21, 89, 68, 2, 51, 65, 20, 87, 48, 5, 1, 16, 60, 53, 84, 90, 16, 2, 37, 73, 57, 70, 57, 69, 68, 1, 24, 40, 72, 97];

$contador = 0;
while($contador < count($numbers)){
    if($numbers[$contador] % 2 == 0){
        echo $numbers[$contador] . "\n";
    }
    $contador++;
}


?>