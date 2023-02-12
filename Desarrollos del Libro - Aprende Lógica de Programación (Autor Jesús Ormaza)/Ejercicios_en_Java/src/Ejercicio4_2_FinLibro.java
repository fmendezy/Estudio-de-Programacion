public class Ejercicio4_2 {
    public static void main(String[] args) {
        /*
         Ejercicio 4.2 
         Declarar la siguiente matriz, asignar los valores especificados e imprimirla en pantalla.
            16 | 15 | 14 | 13
            12 | 11 | 10 | 9
            8  | 7 | 6  | 5
            4  | 3 | 4 | 1
         */
        int matriz[][] = new int[4][4];
        int apoyo = 16;
        for(int i = 0; i <= 3; i ++){
            for(int j = 0; j <= 3; j ++){
                matriz[i][j] = apoyo;
                apoyo = apoyo - 1;
                System.out.print(matriz[i][j] + " | ");
            }
        System.out.println("");
        }

    }
}
