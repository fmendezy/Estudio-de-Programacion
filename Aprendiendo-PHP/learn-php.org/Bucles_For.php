<?php
/*
    Bucles For
    https://www.learn-php.org/en/For_Loops
*/

// Ejemplo de bucle for
$odd_numbers = [1,3,5,7,9];
for ($i = 0; $i < count($odd_numbers); $i=$i+1) {
    $odd_number = $odd_numbers[$i];
    echo $odd_number . "\n";// Imprime los numeros impares
}
echo "\n* * * * * * * * * *\n";
// Ejemplo de bucle foreach
$odd_numbers = [1, 3, 5, 7, 9];
foreach ($odd_numbers as $odd_number) {
    echo $odd_number . "\n";
}

// Ejemplo con un array asociativo (claves)
$phone_numbers = [
    "Alex" => "415-235-8573",
    "Jessica" => "415-492-4856",
];

foreach ($phone_numbers as $name => $number) {
    echo "$name's number is $number.\n";
}

/*
Ejercicio
    Imprima todos los números dentro de la matriz, uno por uno,
    Uso de la secuencia de caracteres de nueva línea para separar los resultados.
*/
$even_numbers = [2,4,6,8,10,12,14,16,18,20];

foreach($even_numbers as $veces){
    echo $veces . "\n";
}

?>