import lang.stride.*;
import java.util.*;
import greenfoot.*;

/**
 * Clase Animal para la actividad evaluada
 */
public class Animal extends Actor
{
    private String especie;
    private int movimientoX;
    private int movimientoY;

    /**
     * Constructor vacio
     */
    public Animal(){
        
    }
    
    public Animal(String especie, int movimientoX, int movimientoY){
        this.especie = especie;
        this.movimientoX = movimientoX;
        this.movimientoY = movimientoY;
    }
    
    /**
     * los getters and setters para los atributos
     */
    public String getEspecie() {
        return especie;
    }

    public void setEspecie(String especie) {
        this.especie = especie;
    }

    public int getMovimientoX() {
        return movimientoX;
    }

    public void setMovimientoX(int movimientoX) {
        this.movimientoX = movimientoX;
    }

    public int getMovimientoY() {
        return movimientoY;
    }

    public void setMovimientoY(int movimientoY) {
        this.movimientoY = movimientoY;
    }

    public void avanzar() {
        int nuevaX = getX() + movimientoX;
        int nuevaY = getY() + movimientoY;
        setLocation(nuevaX, nuevaY);
    }

    public void act() {
        avanzar();
    }
}
