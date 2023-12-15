fun main() {
    val notas = mutableListOf<Int>()
    var nombre: String?
    var contador = 0

    println("Ingrese el nombre del estudiante:")
    nombre = readLine()

    while (nombre.isNullOrEmpty()) {
        println("Error: Ingrese un nombre válido.")
        println("Ingrese el nombre del estudiante:")
        nombre = readLine()
    }

    val msg: String = """
    La nota 1, 3, 5 corresponde a las pruebas (15% c/u)
    La nota 2, 4, 6 corresponde a los foros (5% c/u)
    Y la nota 7 corresponde al examen (40%)
    """
    println(msg)

    // Verificación de notas
    while (contador < 7) {
        println("Ingrese la nota ${contador + 1}")
        val notaStr: String? = readLine()

        if (!notaStr.isNullOrEmpty()) {
            if (notaStr.all { it.isDigit() }) {
                val nota: Int = notaStr.toInt()

                if (nota in 1..7) {
                    notas.add(nota)
                    contador++
                } else {
                    println("Formato inválido de Nota, recuerde debe estar entre 1 y 7.")
                }
            } else {
                println("Formato inválido de Nota, ingrese un número entero válido.")
            }
        }
    }

    val promedio = "%.2f".format(notas.average()).replace(',', '.').toFloat()
    val estado: String = if (promedio >= 4.00) "Aprobado" else "Reprobado"

    println("La nota final de $nombre es ${"%.2f".format(promedio).replace('.', ',')} y está $estado")

}
