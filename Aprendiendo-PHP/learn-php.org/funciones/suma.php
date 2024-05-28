<?php
/*
    Función de Suma
*/
// Define una función llamada `sum` que recibirá una lista de números como argumento.
function suma($numeros) {
    // Inicializa la variable que vamos a devolver
    $suma = 0;

    // Suma los números
    foreach ($numeros as $valor) {
        $suma += $valor;
    }

    // Devuelve la suma al usuario
    return $suma;
}


/*
    Ejercicio:
    Funcion que suma todos los numeros enteros de la matriz al cuadrado.
*/
function squared_sum($numeros){
    $squared_sum = 0;

    // Suma los números y los eleva al cuadrado
    foreach ($numeros as $valor) {
        $squared_sum += $valor**2;
    }
    return $squared_sum;
}

?>