import greenfoot.*;
import java.util.Scanner;

public class Manzano extends Arbol
{
    private int cantidadFrutos;
    
    public Manzano(double altura, int añosVida, int cantidadFrutos) {
        super(altura, añosVida);
        this.cantidadFrutos = cantidadFrutos;
    }
    
    // Getters y setters
    public int getCantidadFrutos() {
        return this.cantidadFrutos;
    }

    public void setCantidadFrutos(int cantidadFrutos) {
        this.cantidadFrutos = cantidadFrutos;
    }

    // Metodos
    @Override
    public String crecer() {
        double valorAleatorio = Math.random();// Valor aleatorio entre 0 y 1
        if (valorAleatorio < 0.5) {
            double alturaActual = getAltura();
            setAltura(alturaActual + valorAleatorio);
        }
        return String.valueOf(getAltura());// Me aseguro de devolver como String de getAltura()
    }
    
    @Override
    public void cambiar() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Ingresa la cantidad de frutos a quitar: ");
        int cantidadFrutosQuitar = scanner.nextInt();// scanner del tipo entero
        if (cantidadFrutosQuitar <= cantidadFrutos) {
            cantidadFrutos -= cantidadFrutosQuitar;
        } else {
            cantidadFrutos = 0;
        }
        scanner.close();
    }

    public void act() {
        crecer();
    }
}