<?php
/*
    Objetos
    https://www.learn-php.org/en/Objects

    Estas son algunas definiciones importantes relacionadas con los objetos:
    1.Las clases definen cómo se comportan los objetos. Las clases no contienen datos.
    2.Los objetos son instancias de clases que contienen datos.
    3.Los miembros son variables que pertenecen a un objeto.
    4.Los métodos son funciones que pertenecen a un objeto y tienen acceso a sus miembros.
    5.Constructor es un método especial que se ejecuta cuando se crea un objeto.
*/

class Estudiante {
    // Constructor
    public function __construct($nombre, $apellido, $profesion){
        $this->nombre = $nombre;
        $this->apellido = $apellido;
        $this->profesion = $profesion;
    }

    public function dime_nombre(){
        echo "Mi nombre es " . $this->nombre . " " . $this->apellido . " y soy " . $this->profesion  ."\n";
    }
}
// Creo un objeto de la clase Estudiante
$francisco = new Estudiante("Francisco", "Mendezy", "Programador");
$francisco->dime_nombre();

// Herencia
echo "---\n";
class EstudianteMatematicas extends Estudiante {
    function sumar_numeros($primer_numero, $segundo_numero){
        $sumar = $primer_numero + $segundo_numero;
        echo $this->nombre . " dice que la suma de " . $primer_numero . " y " . $segundo_numero . " es " . $sumar . "\n";
    }
}

// Creo un objeto de la clase EstudianteMatematicas
$alicia = new EstudianteMatematicas("Alicia", "Mendez", "Estudiante de 4º Básico");
$alicia->dime_nombre();
$alicia->sumar_numeros(3, 5);
echo "---\n";

// Ejemplo 2 con funciones privadas
class Trabajador {
    public function __construct($nombre, $apellido){
        $this->nombre = $nombre;
        $this->apellido = $apellido;
    }

    // Para uso externo
    public function dime_nombre(){
        echo "Mi nombre es " . $this->nombre . " " . $this->apellido . "\n";
    }

    // Para uso interno (privado)
    private function nombre_completo(){
        return $this->nombre ." ". $this->apellido ."";
    }
}

$francisco = new Trabajador("Francisco", "Mendez");
$francisco->dime_nombre();

echo "---\n";
/*
    Ejercicio
    Crear una clase llamada Coche con un constructor que reciba la marca y el año de fabricación del coche,
    y Una función llamada que imprime los detalles del coche.

    Por ejemplo, para un automóvil Toyota 2006, se imprimiría la siguiente línea:
    This car is a 2006 Toyota.
*/

class Coche {
    public function __construct ($marca, $anio){
        $this->marca = $marca;
        $this->anio = $anio;
    }

    public function detalles_coche(){
        echo "Este coche es un " . $this->marca. " " . $this->anio . ".\n";
    }
}
$auto = new Coche("Toyota","2006");
$auto->detalles_coche();
?>