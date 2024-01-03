fun main() {
    println("Perimetro Rectángulo")
    println("====================")

    println("Ingresa la base en cm:")
    val baseStr = readln()
    println("Ingresa la altura en cm:")
    val alturaStr = readln()

    val base = baseStr.toIntOrNull() ?: 0
    val altura =alturaStr.toIntOrNull() ?: 0

    val rectangulo = Rectangulo(base, altura)
    val perimetro = rectangulo.calcularPerimetro()
    println("El perimetro del rectángulo es: ${perimetro}")
}
