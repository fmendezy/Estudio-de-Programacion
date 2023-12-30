package cl.mendezy.curso_androidmaster

fun main() {

    /*
     *   VARIABLES GENERALES
     */
    val name = "Francisco"

    // Variable con definición del tipo int
    val age: Int = 30 // Ejemplo de "val" constante.
    var age2: Int = 29 // Ejemplo de "var" variable.
    //println(age2)
    age2 = 31
    //println(age2)

    // Long
    val ejemplo:Long = 30

    // Float - Usando CamelCase
    // Se debe poner la "f" al final para que sea considerado float correctamente.
    val floatExample:Float = 30.5f

    // Double
    // Soportan hasta 14 decimales
    val doubleExample:Double = 3241.3131223

    /*
     *  VARIABLES ALFANÚMERICAS
     */

    // Char
    val charExample1:Char = 'e'
    val charExample2:Char = '@'
    val charExample3:Char = '2'


    // String
    val stringExample:String = "Francisco Mendezy"
    val stringExample2 = "Francisco Mendezy" // Ejemplo de simplicidad en sintaxis.

    /*
    *   VARIABLES BOOLEANAS
     */

    // Boolean
    val booleanExample:Boolean = true
    val booleanExample2:Boolean = false
    val booleanExample3:Boolean = false

    // Ejecutamos el contenido de la variable que deseemos
    //println(stringExample)

    // Ejemplo de uso de variables en operación básica
    /*
    println("Sumar: ${age+age2}")
    println("Restar: ${age-age2}")
    println("Multiplicar: ${age*age2}")
    println("División: ${age/age2}")
    println("Módulo: ${age%age2}")
    */

    // Conversión de variables a otro tipo de dato
    var exampleSUma: Int = age + floatExample.toInt()

    var string1 = "4"
    var string2 = "2"
    var conversion =  string1.toInt() + string2.toInt() // convertimos a numero 2 strings.
    //println(conversion)

    // Uso de contactenación en string
    //println("Si concatenamos $string1 y $string2 el resultado será ${string1+string2}")

    // Declaración de variable con conversion de tipo de dato distinto
    val exampleNUmero:String = age.toString()
}