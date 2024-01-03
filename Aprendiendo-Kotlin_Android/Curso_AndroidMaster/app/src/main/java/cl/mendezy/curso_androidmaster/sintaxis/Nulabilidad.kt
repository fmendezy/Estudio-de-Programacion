package cl.mendezy.curso_androidmaster.sintaxis


/*
 * el signo "?" acompañando el tipo de dato significa que se permite que sea nulo.
 * Ej:
 * var name:String? = null
 *
 * También cuando se ponene dos signos de exclamación: !! al lado de una variable con condición
 * significa que estamos SEGUROS SEGUROS (sí, dos veces) que el valor no será nulo.
 *
 * Ej:
 * println(name!![3])
 */
fun main(){
    var name:String? = "Francisco"

    println(name?.get(3) ?: "Es nulo")
}


