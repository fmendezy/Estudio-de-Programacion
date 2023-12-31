package cl.mendezy.curso_androidmaster

fun main(){
    // Probando ejercicio de getSemester2
    val resultado = getSemester2(6)
    println(resultado)
}

fun getMonth(month:Int){
    when(month){
        1 -> print("Enero")
        2 -> print("Febrero")
        3 -> print("Marzo")
        4 -> print("Abril")
        5 -> print("Mayo")
        6 -> print("Junio")
        7 -> print("Julio")
        8 -> print("Agosto")
        9 -> print("Septiembre")
        10 -> print("Octubre")
        11 -> {
            print("Noviembre")
            print("Ejemplo multilinea 1")
            print("Ejemplo multilinea 2")
        }
        12 -> print("Diciembre")
        else -> println("No es un mes válido")
    }
}

fun getTrimester(month:Int){
    when(month){
        1, 2, 3 -> print("Primer trimestre")
        4, 5, 6 -> print("Segundo trimestre")
        7, 8, 9 -> print("Tercer trimestre")
        10, 11, 12 -> print("Cuarto trimestre")
        else -> println("No es un trimestre válido")
    }
}

fun getSemester(month:Int){

    when(month){
        in 1..6 -> print("Primer semestre")
        in 7..12 -> print("Segundo semestre")
        !in 1..12 -> print("Semestre no válido")
    }
}

// value:Any permite recibir todo tipo de datos
fun result(value:Any){
    when(value){
        is Int -> value + value
        is String -> println(value)
        is Boolean -> if(value) print ("Hola!")
    }
}

// Versión con return del tipo string
fun getSemester2(month:Int) = when(month){
        in 1..6 -> "Primer semestre"
        in 7..12 -> "Segundo semestre"
        !in 1..12 -> "Semestre no válido"
        else -> "Nada"
}