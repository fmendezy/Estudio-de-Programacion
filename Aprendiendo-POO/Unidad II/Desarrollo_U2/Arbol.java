import greenfoot.*;

public class Arbol extends Actor implements Acciones
{
    private double altura;
    private int añosVida;

    public Arbol(double altura, int añosVida) {
        this.altura = altura;
        this.añosVida = añosVida;   
    }

    // Getters y Setters para los atributos
    public double getAltura() {
        return this.altura;
    }

    public void setAltura(double altura) {
        this.altura = altura;
    }

    public int getAñosVida() {
        return this.añosVida;
    }

    public void setAñosVida(int añosVida) {
        this.añosVida = añosVida;
    }

    // Metodos implementados provenientes de la interface "Acciones": crecer() y cambiar() 
    public String crecer() {
        this.altura += 0.1;
        return "Altura actual es de: "+ this.altura + " metros";
    }

    public void cambiar() {
    this.setLocation(this.getX()+ 10, this.getY() + 20);
    }
    
    // Acto
    public void act() {
        this.crecer();
        this.cambiar();
    }
}