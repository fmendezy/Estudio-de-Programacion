<?php
/* 
    Arrays Asociativos (En Python: diccioanrios) - MATRICES CON CLAVE
    https://www.learn-php.org/en/Arrays_with_keys
*/

// Ejemplos
$numeros_telefonicos = [
    "Francisco" => "+569 11223344",
    "Alicia" => "+569 55667788",
];

print_r($numeros_telefonicos);// Imprimimos el array asociativo
echo "Francisco tiene el numero " . $numeros_telefonicos["Francisco"] . "\n";

// Agregando un elemento en el array con clave (usamos array anterior)
$numeros_telefonicos["Dagger"] = "+52 11223344";// Agregamos nuevo elemento usando clave-valor
print_r($numeros_telefonicos);


/*
    array_key_exists() 
    Comprobación de la existencia de una clave (nombre de la persona) en un array
 */
if (array_key_exists("Francisco", $numeros_telefonicos)) {
    echo "El numero telefonico de Francisco es " . $numeros_telefonicos["Francisco"] . "\n";
} else {
    echo "El numero de Francisco no está en el listado";
}

if(array_key_exists("Alicia", $numeros_telefonicos)){
    echo "El numero de Alicia es " . $numeros_telefonicos["Alicia"] . "\n";
}else{
    echo "El numero de Alicia no está en el listado";
}

// array_values() - Extrae solo los valores del array (los numeros de telefono
print_r(array_values($numeros_telefonicos));// Solo muestra los valores

/*  
Ejercicio
Agregue un número a la guía telefónica de Eric, con el número 415-874-7659,
ya sea agregándolo a la definición de matriz o como una línea de código separada.
*/
$numeros_telefonicos["Eric"] = "415-874-7659";// Agregamos nuevo elemento usando clave-valor
print_r($numeros_telefonicos);

?>