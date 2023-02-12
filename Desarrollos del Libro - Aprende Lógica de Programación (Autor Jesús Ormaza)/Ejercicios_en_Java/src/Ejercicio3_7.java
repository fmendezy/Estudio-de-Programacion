public class Ejercicio3_7 {
    public static void main(String[] args) {
        /*
        Ejercicio 3.7 
        Dada la siguiente matriz, realizar la operación
        indicada en la última posición de las columnas.
        | A = 79  | D = 56   | G = 120      |
        | B = 698 | E = 487  | H = 37       |
        |C = A+B  | F=D(D-E) | I = H{G(√H)} |
        */
        double[][] matriz = new double[3][3];// Declarar nueva matriz 3x3
        matriz[0][0] = 79;// A
        matriz[0][1] = 56;// D
        matriz[0][2] = 120;// G
        matriz[1][0] = 698;// B
        matriz[1][1] = 487;// E
        matriz[1][2] = 37;// H
        matriz[2][0] = matriz[0][0]+matriz[1][0];// C
        matriz[2][1] =  matriz[0][1] * ( matriz[0][1] - matriz[1][1]);// F
        matriz[2][2] =  matriz[1][2] * (matriz[0][2] * (Math.sqrt(matriz[1][2])));// I
        System.out.println("\n-- Ejercicio 3.7");
        System.out.println("Matriz C = "+matriz[2][0]+"\nMatriz F = "+matriz[2][1]+"\nMatriz I = "+matriz[2][2]);
    }
}
