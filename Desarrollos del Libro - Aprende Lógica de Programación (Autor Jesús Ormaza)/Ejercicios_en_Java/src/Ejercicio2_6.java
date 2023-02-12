public class Ejercicio2_6 {
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
        }
    }
