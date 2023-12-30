package cl.mendezy.curso_androidmaster

fun main() {
    showMyName(name = "Francisco")
    showMyAge(29)
    add(25, 76)
    val mySubtract = subtract(10, 5)
    println(mySubtract)
}
fun variablesNumericas(){
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
}
fun variablesBooleanas(){
    // Boolean
    val booleanExample:Boolean = true
    val booleanExample2:Boolean = false
    val booleanExample3:Boolean = false
}
fun  variablesAlfanumericas(){
    val age: Int = 30 // Ejemplo de "val" constante.
    val floatExample:Float = 30.5f

    // Char
    val charExample1:Char = 'e'
    val charExample2:Char = '@'
    val charExample3:Char = '2'

    // String
    val stringExample:String = "Francisco Mendezy"
    val stringExample2 = "Francisco Mendezy" // Ejemplo de simplicidad en sintaxis.

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

    var string1:String = "4"
    var string2:String = "2"
    var conversion =  string1.toInt() + string2.toInt() // convertimos a numero 2 strings.
    //println(conversion)

    // Uso de contactenación en string
    //println("Si concatenamos $string1 y $string2 el resultado será ${string1+string2}")

    // Declaración de variable con conversion de tipo de dato distinto
    val exampleNumero:String = age.toString()
}

// Introducción a las funciones y parametros
fun showMyName(name:String){
    println("Me llamo $name")
}

// el 29 es un valor por defecto en caso que no le entre parametro
fun showMyAge(currentAge: Int = 29){
    println("Tengo $currentAge años")
}

fun add(firstNumber: Int, secondNumber: Int){
    println(firstNumber + secondNumber)
}

// El ultimo int representa el tipo de dato que retornará (salida)
fun subtract(firstNumber:Int, secondNumber:Int):Int{
    return firstNumber - secondNumber
    println("Adios :(")// el amarillo significa que esto no se va a usar ya que termina en el return.
}

// Funciones pequeñas y ŕapidas, ideal cuando tienes claro el tipo de dato que devolverá y la acción a realizar.
fun subtractCool(firstNumber:Int, secondNumber:Int) = firstNumber - secondNumber
