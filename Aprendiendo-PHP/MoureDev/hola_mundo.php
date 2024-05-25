<?php

/*
    1º Sintaxis y comentarios
*/
echo "Hola, PHP\n";

/*
Este
es
un
comentario
*/

/*
    2º Variables y tipado dinamico
*/
$my_string = "Esto es una cadena de texto";// Variable con un String
//$my_string = 1;
//$my_string = true;
//$my_string = 1.5;
echo $my_string . "\n";
echo gettype($my_string) . "\n";// Revisión de tipos de datos de en la variable


//$my_string = 5;// tipado dinamico - Cambio la variable a un entero.
echo $my_string . "\n";
echo gettype($my_string) . "\n";

// Enteros - intiger
$my_int = 7;
$my_int = $my_int + 3;
echo $my_int -1 . "\n";// el resultado se restó 1 (queda en 9) pero no cambia en la variable
echo $my_int . "\n";// el valor de la variable no cambia vuelve al original. (10)

// Decimales 
/* 
   En PHP, no hay una distinción entre double y float. 
   Ambos son usados para representar números con punto flotante. 
   La precisión de estos números es plataforma-dependiente,
   aunque un número de punto flotante comúnmente ocupa un espacio de 64 bits,
   lo que proporciona una precisión significativa. En la mayoría de los casos,
   puedes usar float y double de manera intercambiable en PHP.
*/
$my_double = 6.5;
echo gettype($my_double) . "\n";
echo $my_int + $my_double . "\n";// my_int es 10 y my_double es 6.5, el resultado es 16.5
//echo $my_int + $my_double + $my_string . "\n";// esto deberia dar error

// booleanos
$my_bool = true;
echo $my_bool . "\n";// Resultado "1" porque es un booleano
$my_bool = false;
echo $my_bool . "\n";// Resultado no muestra nada (vacio) por que es false.
echo gettype($my_bool) . "\n";
$my_bool = true;// para que quede en 1

// Uso de If
if($my_bool==false){
    $resultado = "falso";
} else {
    $resultado = "verdadero";
}
echo "El valor de mi integer es ". $my_int ." y el de mi boolean es ". $resultado ."\n";

// Constante
const MY_CONSTANT = "Valor de la constante";
echo MY_CONSTANT . "\n";
//const MY_CONSTANT = "sss";// Esto dará error ya que la constante esta ocupada

/*
    3º Listas
*/

$my_array = [$my_string, $my_int, $my_double];// Lista
echo gettype($my_array) . "\n";// array - list
echo $my_array[2] . "\n";

array_push($my_array, $my_bool);// Agregar un elemento al array
print_r($my_array);// Imprimir el array completo
//echo $my_array[4] . "\n";// error porque no hay un 4 elemento en el array

echo "-------------". "\n";
// Juego del gato mostrado en arrays
$gato = [0,1];
echo $gato[0] . " " . $gato[0] . " " . $gato[1] . "\n";
echo $gato[0] . " " . $gato[1] . " " . $gato[0] . "\n";
echo $gato[1] . " " . $gato[0] . " " . $gato[0] . "\n";

echo "-------------". "\n";
// Diccionarios

$my_dict = array("string" => $my_string, "int" => $my_int, "bool" => $my_bool);
echo gettype($my_dict) . "\n";
print_r($my_dict);
echo $my_dict["int"] . "\n";// Acceder a un elemento del diccionario


// Estructura de tipo Set
array_push($my_array, "Frank");
array_push($my_array, "Frank");
print_r($my_array);
print_r (array_unique($my_array)) . "\n";// Muestra los elementos unicos del array


/*
    4º Bucles
*/

for ($index = 0; $index <10; $index++){
    echo $index . "\n";
}


foreach ($my_array as $my_item){
    echo $my_item . "\n";
}

$index = 0;
while ($index < sizeof($my_array) - 1){
    echo $my_array[$index] . "\n";
    $index++;
}


if ($my_int == 10 && $my_string == "hola"){
    echo "El valor de my_int es 10\n";
} else if ($my_int == 11 && $my_string == "hola"){
    echo "El valor de my_int es 11\n";
} else {
    echo "El valor de my_int no es 10\n";
}


/*
    5º Funciones
*/

function print_number(int $my_number){
    echo $my_number . "\n";
}

print_number(1);
//print_number("hola");// error por que se definio como int 

/*
    6º Programación orientada a objetos (POO)
    CLASES
*/

class MyClass {
    public $name;
    public $age;

    function __construct($name, $age){
        $this->name = $name;
        $this->age = $age;
    }
}

$my_class = new MyClass("Frank", 30);
print_r($my_class);

echo $my_class->name . "\n";
$my_class->name = "Pancho";// esto cambia el valor de la variable name
echo $my_class->name . "\n";

echo gettype($my_class) . "\n";// object

// FIN
?>
