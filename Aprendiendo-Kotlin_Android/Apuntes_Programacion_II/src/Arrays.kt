fun main() {
    val numeros = arrayOf(1, 2, 3)
    val nombres = arrayOf("Pedro", "Juan", "Diego")
    val numeros2 = IntArray(4)
    numeros2[0] = 4 // [4, 0, 0, 0]
    val nombres2 = arrayOfNulls<String>(3) // nombres2: Array<String?>
    nombres2[1] = "Juan" // [null, Juan, null]

    // El método contentToString() se utiliza para imprimir el contenido completo de un arreglo.
    println(numeros.contentToString())
    println(nombres.contentToString())
    println(numeros2.contentToString())
    println(nombres2.contentToString())
}