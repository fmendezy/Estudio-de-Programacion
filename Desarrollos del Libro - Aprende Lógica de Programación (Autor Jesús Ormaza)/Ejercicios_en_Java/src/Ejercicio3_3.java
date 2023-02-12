public class Ejercicio3_3 {
    public static void main(String[] args) {
        /*
        Ejercicio 3.3 
        Guardar los siguientes valores en un vector, realizar
        la operación accediendo a sus posiciones y guardar el resultado
        en la última posición.
        ➢ A = 24.89
        ➢ B = 38.67
        ➢ C = 45.21
        ➢ Operación: A{√B[A + C^3]}
        */  
        double[] vector = new double[4];// Asignacion de 4 espacios
        vector[0] = 24.89;
        vector[1] = 38.67;
        vector[2] = 45.21;
        vector[3] = vector[0]*(Math.sqrt(vector[1])*(vector[0] + Math.pow(vector[2], 3)));
        System.out.println("-- Ejercicio 3.3");
        System.out.println("El resultado es: "+vector[3]);
    }
}
