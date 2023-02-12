public class Ejercicio3_10 {
    public static void main(String[] args) {
        /*
        Ejercicio 3.10 
        Declarar en código la matriz tridimensional de la
        figura 3.10 pero con las posiciones de las matrices simples
        cambiadas, es decir, la matriz verde delante y la matriz amarilla
        detrás.
        */
        int ejericio3_10[][][] = new int[2][2][2];
        // Verde en primera dimension
        ejericio3_10[0][0][0] = 50;
        ejericio3_10[0][1][0] = 78; 
        ejericio3_10[1][0][0] = 89;
        ejericio3_10[1][1][0] = 96;

        // Amarillo en segunda simentsion
        ejericio3_10[0][0][1] = 4;
        ejericio3_10[0][1][1] = 6;
        ejericio3_10[1][0][1] = 8;
        ejericio3_10[1][1][1] = 7;

    }
}
