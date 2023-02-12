public class Ejercicios2_6_al_9 {
    public static void main(String[] args) {
        /*
        Ejercicio 2.6 Escribir un programa que reemplace las letras
        indicadas.
        ➢ “Lorem ipsum dolor sit amet”, reemplaza ‘o’ por ‘n’
        ➢ “Sed ut perspiciatis unde omnis” eliminar ‘u’
        */
        String Ejer2_6_a = "Lorem ipsum dolor sit amet";
        String Ejer2_6_b = "Sed ut perspiciatis unde omnis";
        System.out.println("-- Ejercicio 2.6");
        System.out.println("a) Reemplaza 'o' por 'n'");
        System.out.println("Original: '"+Ejer2_6_a+"' - Resultado: '"+Ejer2_6_a.replace("o","n"));
        System.out.println("\nb)  eliminar 'u'");
        System.out.println("Original: '"+Ejer2_6_b+"' - Resultado: '"+Ejer2_6_b.replace("u",""));

        /*
        Ejercicio 2.7 Escribir un programa que convierta a minúsculas las
        siguientes oraciones
        ➢ “NTEGER A FACILISIS NEQUE NUNC QUAM LIGULA”
        ➢ “ALIQUAM GRAVIDA ARCU UT SOLLICITUDIN ORNARE IN.”
         */
        String Ejer2_7_a = "NTEGER A FACILISIS NEQUE NUNC QUAM LIGULA";
        String Ejer2_7_b = "ALIQUAM GRAVIDA ARCU UT SOLLICITUDIN ORNARE IN.";
        System.out.println("\n-- Ejercicio 2.7");
        System.out.println("Escribir un programa que convierta en minúsculas las siguientes oraciones:");
        System.out.println("Original: '"+Ejer2_7_a+"' - Resultado: '"+Ejer2_7_a.toLowerCase());
        System.out.println("Original: '"+Ejer2_7_b+"' - Resultado: '"+Ejer2_7_b.toLowerCase());

        /*
         Ejercicio 2.8 Escribir un programa que convierta a mayusculas
        las siguientes oraciones
        ➢ “nam ornare ultricies lorem eget dictum velit”
        ➢ “praesent feugiat neque vulputate turpis volutpat placerat”
         */
        String Ejer2_8_a = "am ornare ultricies lorem eget dictum velit";
        String Ejer2_8_b = "praesent feugiat neque vulputate turpis volutpat placerat";
        System.out.println("\n-- Ejercicio 2.8");
        System.out.println("Escribir un programa que convierta en mayúsculas las siguientes oraciones:");
        System.out.println("Original: '"+Ejer2_8_a+"' - Resultado: '"+Ejer2_8_a.toUpperCase());
        System.out.println("Original: '"+Ejer2_8_b+"' - Resultado: '"+Ejer2_8_b.toUpperCase());

         /*
         Ejercicio 2.9 Escribir un programa que concatene los dos
         primeros literales de los ejercicios 2.7 y 2.8 e imprimirlo en
         pantalla.
          */
          System.out.println("\n-- Ejercicio 2.9");
          System.out.println("Escribir un programa que concatene los dos primeros literales de los ejercicios 2.7 y 2.8 e imprimirlo en pantalla.");
          System.out.println("Resultado:\n"+Ejer2_7_a.concat(Ejer2_8_a));
        }
    }
