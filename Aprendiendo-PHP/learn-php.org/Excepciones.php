<?php
/*
    Excepciones
    https://www.learn-php.org/en/Exceptions
*/

function lanzar_excepcion() {
    throw new Exception("¡Excepción general!");
}

try {
    // Esto lanzará un DivisionByZeroError
    echo 2 / 0;
} catch (DivisionByZeroError $e) {
    echo "¡Excepción atrapada: División por cero!";
} catch (Exception $e) {
    echo "¡Excepción atrapada: " . $e->getMessage() . "!";
} finally {
    echo "¡Hecho!";
}


?>