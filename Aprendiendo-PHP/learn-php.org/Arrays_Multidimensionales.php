<?php
/*
    Arrays Multidimensionales
    https://www.learn-php.org/en/Multidimensional_Arrays
*/

// Ejemplo de array multidimensional
$multiArray = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9],
];

print_r($multiArray[0]); // Imprime el primer array

print_r($multiArray[0][0]); // 1
print_r($multiArray[0][1]); // 2
print_r($multiArray[0][2] . "\n"); // 3


// Matriz Muldimensional asociativa
$persona = [
    "Francisco Mendez" => [
        "edad" => 30,
        "ocupacion" => "Desarrollador",
        "lenguajes" => ["Python", "PHP", "JavaScript"]
    ],
    "Alicia" => [
        "edad" => 9,
        "ocupacion" => "Diseñadora",
        "lenguajes" => ["Photoshop", "Illustrator"]
    ]
];

print_r($persona);
print_r($persona['Francisco Mendez']['ocupacion'] . "\n");// Devuelve Desarrollador

echo "* * * * * * * * * * SIGUIENTE EJERCICIO * * * * * * * * * *\n";
/*
    Ejercicio 1
    Complete el código a continuación para sumar todos los números en todas las matrices
    internas e imprima el resultado en una nueva línea.
*/

$matrix = [ 
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9],
];

foreach ($matrix as $numbers) {// matriz completa
    $sum = 0;

    // TODO: Write you'r code here.
    foreach ($numbers as $number) {// matriz interna, cada fila
        $sum += $number;
    }
    echo "{$sum}\n";
}

echo "* * * * * * * * * * SIGUIENTE EJERCICIO * * * * * * * * * *\n";
/*
    Ejercicio 2 
    Dado el siguiente array bidimensional de precios de productos en diferentes tiendas,
    completa el código para calcular y mostrar el precio promedio de los productos en cada tienda.
*/
$precios = [
    [10.5, 20.3, 30.2],  // Tienda 1
    [15.2, 25.6, 35.7],  // Tienda 2
    [12.5, 22.4, 32.1],  // Tienda 3
];
    $tienda = 0;

foreach ($precios as $preciosTienda) {
    $suma = 0;
    $cantidad = 0;

    // TODO: Escribe tu código aquí.
    foreach ($preciosTienda as $numero){// array interno por cada producto de la tienda
        $suma += $numero;
        $cantidad++; // Solo necesitamos contar los elementos, no sumar el valor.
    }

    // Calcula el precio promedio
    $promedio = $suma / $cantidad;
    $promedio_formateado = number_format($promedio, 2,".","");// 2 Decimales, Punto para separador de miles y coma para decimales.
    $tienda++;

    echo "Precio promedio en la tienda Nº{$tienda}: {$promedio_formateado}\n";
}

echo "* * * * * * * * * * SIGUIENTE EJERCICIO * * * * * * * * * *\n";
/*
    Ejercicio 3
    Dado el siguiente array bidimensional de ventas semanales de diferentes vendedores,
    completa el código para calcular y mostrar la venta total y la venta promedio por vendedor.
*/

$ventas = [
    [200, 340, 560],  // Vendedor 1
    [450, 620, 780],  // Vendedor 2
    [300, 400, 700],  // Vendedor 3
];
    $vendedor = 0;


foreach ($ventas as $ventasVendedor) {
    $total = 0;
    $cantidad = 0;

    // TODO: Escribe tu código aquí.
    foreach ($ventasVendedor as $numero){
        $total += $numero;
        $cantidad++;
    }

    // Calcula la venta promedio
    $promedio = $total / $cantidad;
    $promedio_formateado = number_format($promedio, 2);
    $vendedor++;

    echo "Vendedor Nº{$vendedor}\n";
    echo "Venta total: {$total}\n";
    echo "Venta promedio: {$promedio_formateado}\n ---\n";
}

/*
    Ejercicio Nº4
    Dado el siguiente array bidimensional de calificaciones de estudiantes en diferentes asignaturas,
    completa el código para calcular y mostrar la calificación total y la calificación promedio por estudiante.
*/
$calificaciones = [
    [85, 90, 78],  // Estudiante 1
    [88, 92, 95],  // Estudiante 2
    [70, 80, 85],  // Estudiante 3
];

    $estudiante = 0;

foreach ($calificaciones as $calificacionesEstudiante) {
    $total = 0;
    $cantidad = 0;

    // TODO: Escribe tu código aquí.
    foreach ($calificacionesEstudiante as $numero){
        $total += $numero;
        $cantidad++;
    }

    // Calcula la calificación promedio
    $promedio = $total / $cantidad;
    $promedio_formateado = number_format($promedio, 2);
    $estudiante++;

    echo "Estudiante {$estudiante}\n";
    echo "Calificación total: {$total}\n";
    echo "Calificación promedio: {$promedio_formateado}\n---\n";
}

?>