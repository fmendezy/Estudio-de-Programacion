package cl.mendezy.curso_androidmaster.sintaxis

fun main(){
    ifBoolean()
}

fun ifBasico(){
    val name = "Francisco"

    if(name == "Pepe"){
        println("Oye, la variable name es Francisco")
    }else{
        println("Este no es Pepe")
    }

}

fun ifAnidado(){
    val animal = "Pikachu"
    if(animal == "dog"){
        println("Es un perrito")
    }else if(animal == "cat"){
        println("Es un gato")
    }else if(animal == "bird"){
        println("Es un pajaro")
    }else{
        println("No es uno de los animales esperados.")
    }
}

fun ifBoolean(){
    var soyFeliz:Boolean = false

    // Con la exclamación define el valor contrario, entonces seria true
    if(!soyFeliz){
        println("Estoy triste :(")
    }
}

fun ifInt(){
    var age = 29

    if(age >= 18){
        println("Beber cerveza, eres mayor de edad")
    }else{
        println("Beber jugo, eres menor de edad.")
    }
}

fun ifMultiple() {
    var age = 18
    var parentPermission = false
    var imHappy = true

    /*
    // Lo que no se debe hacer
    if(age >= 18){
        if(parentPermission){
            if(imHappy) {
                println("Puedo beber")
            }
        }
    }
}
*/
    // Forma correcta
    if(age >= 18 && parentPermission && imHappy){
        println("Puedo beber cerveza")
    }
}

fun ifMUltipleOR(){
    var pet = "dog"
    var isHappy = true
    if(pet == "dog" || pet == "cat" && isHappy){
        println("Es un gato o un perro")
    }
}