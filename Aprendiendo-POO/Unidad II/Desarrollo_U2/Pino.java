import greenfoot.*;
import java.util.Scanner;

public class Pino extends Arbol 
{
    private boolean hojasCaen;

    public Pino(double altura, int añosVida, boolean hojasCaen) {
        super(altura, añosVida);
        this.hojasCaen = hojasCaen;
    }

    // Getter y Setter
    public boolean getHojasCaen() {
         return this.hojasCaen;
    }

    public void setHojasCaen(boolean hojasCaen) {
        this.hojasCaen = hojasCaen;
    }

    @Override
    public String crecer() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Ingresa un numero decimal para aumentar la altura: ");
        double valor = scanner.nextDouble();// solicito valor decimal por teclado
        setAltura(getAltura() + valor);// Sumo altura actual + valor recibido
        scanner.close();
        return Double.toString(getAltura());// Convierto la altura al tipo String antes de retornarla
    }

    @Override
    public void cambiar() {
        int x = Greenfoot.getRandomNumber(getWorld().getWidth());
        int y = Greenfoot.getRandomNumber(getWorld().getHeight());
        setLocation( x, y );// establezco nueva posicion en el mundo.
    }

    public void act() {
        cambiar();
    }
}