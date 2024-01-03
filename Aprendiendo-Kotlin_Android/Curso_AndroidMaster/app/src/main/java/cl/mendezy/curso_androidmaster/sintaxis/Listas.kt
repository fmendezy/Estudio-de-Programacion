package cl.mendezy.curso_androidmaster.sintaxis

fun main() {
    mutableList()
}

fun inmutableList(){
    val readOnly: List<String> = listOf("Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo")

    println(readOnly.size)
    println(readOnly)
    println(readOnly[0])
    println(readOnly.last())
    println(readOnly.first())

    // Ejemplo con filtros en arrays
    val example = readOnly.filter { it.contains("a") }
    println(example)

    readOnly.forEach{ weekDay -> println(weekDay) }
}


fun mutableList(){
    var weekDays:MutableList<String> = mutableListOf("Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo")
    weekDays.add(0,"DiaFrancisco")
    println(weekDays)


    if(weekDays.isEmpty()) {
        // nada
    }else{
        weekDays.forEach{ println(it) }
    }

    if(weekDays.isNotEmpty()){
        weekDays.forEach{ println(it) }
    }

    weekDays.last()

}
