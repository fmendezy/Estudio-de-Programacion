<?php
/*
    Manejo de Strings - Medio
    https://learn-php.org/en/Strings
*/

// strlen() - Mide la longitud de un string
$palabra = "Erase una vez un hombre que soñaba con ser programador y darle estabilidad a su familia.\n";
echo strlen($palabra) . "\n";// 89

// substr() - Sirve para cortar una parte de una cadena y devolverla como una nueva cadena
$nombreArchivo = "documento.pdf";
$extension = substr($nombreArchivo, strlen($nombreArchivo) - 3);
// Nota: el strlen obtiene el total de caracteres de la cadena, y se le resta 3 para obtener la extensión
// Va hacia atrás por lo que todo lo que este desde el caracter 8 en adelante, se elimina.
echo "La extensión del archivo es '$extension'." . "\n";

// explode() - Para dividir cadenas mediante ","
$frutas = "manzana,pera,platano,kiwi,piña";
$listado_frutas = explode(",", $frutas);
echo "La tercera fruta en la lista es $listado_frutas[2]" . "\n";// Platano

// implode() -
// en PHP toma un array de elementos y los une en una sola cadena de texto,
// utilizando un delimitador específico entre cada elemento.
$listado_frutas = ["manzana","pera","platano","kiwi","piña"];
$frutas = implode(" - ", $listado_frutas);// NOTESE: Que se defina el separador:" - "
echo "Las frutas son: '$frutas'" . "\n";// 

// strpos() - Encuentra la posición de la primera aparición de una subcadena en una cadena
$palabra = "Hola mundo";
$posicion = strpos($palabra, "mundo");
echo "La palabra 'mundo' comienza en la posición $posicion" . "\n";

echo "* * * * * * * * * * EJERCICIO * * * * * * * * * *\n";
/*
    Ejercicio de la Web
    Cadena dividida que contiene la lista de números en una nueva matriz llamada number_list.
*/
$numbers = "38,42,58,48,33,59,87,17,20,8,98,14,62,66,14,62,97,66,74,78,66,2,79,29,72,6,3,71,46,68,48,4,12,52,66,48,14,39,63,69,81,61,21,77,10,44,39,82,19,77,100,98,53,95,30,17,30,96,68,47,81,52,82,11,13,83,10,14,49,96,27,73,42,76,71,15,81,36,77,38,17,2,29,100,26,86,22,18,38,64,82,51,39,7,88,53,82,30,98,86";
$number_list =explode(",", $numbers);
print_r($number_list) . "\n";

echo "\n* * * * * * * * * * SIGUIENTE EJERCICIO * * * * * * * * * *\n";
/*
Ejercicio 1: Contar Caracteres
Dada una cadena, cuenta cuántas veces aparece un carácter específico en la cadena.
*/
$cadena = "Hola mundo, hola programación.";
$caracter = "l";
$conteo = 0;
for ($i = 0; $i < strlen($cadena); $i++) {
    if($cadena[$i] == $caracter){
        $conteo++;
    }
}
echo "El caracter '$caracter' aparece '$conteo' veces.". "\n";

echo "\n* * * * * * * * * * SIGUIENTE EJERCICIO * * * * * * * * * *\n";
/*
Ejercicio 2: Obtener el Nombre de un Archivo
Dada una ruta de archivo completa, extrae solo el nombre del archivo sin la extensión.
*/
$rutaArchivo = "/var/www/html/index.php";
$nombreArchivo = basename($rutaArchivo);// index.php
$posicion = strpos($nombreArchivo, ".");// obitene la posición del punto
$nombreArchivo = substr($nombreArchivo, 0, $posicion);// index
echo "El nombre del archivo es '{$nombreArchivo}'.". "\n";

echo "\n* * * * * * * * * * SIGUIENTE EJERCICIO * * * * * * * * * *\n";
/*
Ejercicio 3: Dividir y Unir Nombres
Dada una cadena de nombres completos separados por comas,
divídelos en un array y luego únelos de nuevo en una cadena, pero separados por punto y coma.
*/

$nombres = "Juan Perez,Maria Gomez,Carlos Sanchez,Ana Ruiz";
$listado = explode(",", $nombres);
$nombres_ok = implode(";", $listado);
echo $nombres_ok. "\n";

echo "\n* * * * * * * * * * SIGUIENTE EJERCICIO * * * * * * * * * *\n";
/*
Ejercicio 4: Obtener Subcadenas
Dada una cadena, extrae varias subcadenas utilizando diferentes posiciones de inicio y longitud.
*/
$cadena = "Bienvenidos al curso de programación en PHP";
$palabras = ["Bienvenidos", "curso", "en PHP"];

for ($i = 0; $i < count($palabras); $i++) {
    $posicion = strpos($cadena, $palabras[$i]);// Para que entre en cada palabra
    $longitud = strlen($palabras[$i]);
    $resultado = substr($cadena, $posicion, $longitud);
    echo $resultado . "\n";
    
}

echo "\n* * * * * * * * * * SIGUIENTE EJERCICIO * * * * * * * * * *\n";
/*
Ejercicio 5: Crear una Lista de Productos
Dada una cadena con nombres de productos separados por comas, divídelos en un array,
luego une los nombres de productos en una cadena separada por guiones.
*/
$productos = "mesa,silla,escritorio,lampara,estante";

$listado = explode(",", $productos);
$resultado = implode("-", $listado);
echo $resultado. "\n";

?>