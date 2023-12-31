package cl.mendezy.curso_androidmaster

fun main(){

    val weekDays = arrayOf("Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo")

    println(weekDays.size)

    if(weekDays.size >= 8){
        println(weekDays[7])
    }else{
        println("No hay mas valores en el array")
    }

    // Bucles para Arrays
    for(position in weekDays.indices){
        println(weekDays[position])
    }

    // For para conocer la posición y el valor
    for((position, value) in weekDays.withIndex()){
        println("La posicion $position, contiene $value")
    }

    // Simple forma para mostrar el dia de la semana.
    for(weekDay in weekDays){
        println("Ahora es $weekDay")
    }
}