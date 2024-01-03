/*
Ver codigo con argumentos incluidos en Kotlin playground:
https://pl.kotl.in/a7RIprBn_

class Rectangulo(val base:Int, val altura:Int){
    fun calcularArea():Int = base * altura
}

fun main(args:Array<String>) {
    val base = args[0].toIntOrNull() ?: 0
    val altura = args[1].toIntOrNull() ?: 0

    val rect = Rectangulo(base,altura)
    val area = rect.calcularArea()
    println("El área del rectángulo es ${area}")
}

*/
