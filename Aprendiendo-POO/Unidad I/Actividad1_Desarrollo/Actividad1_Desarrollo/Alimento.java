import lang.stride.*;
import java.util.*;
import greenfoot.*;

/**
 * Clase Alimento
 */
public class Alimento extends Actor {
    private String tipoAlimento;
    private int cantidadDesplazamiento;
    private boolean saludable;

    /**
     * Constructor vacio
     */
    public Alimento() {
    }

    public Alimento(String tipoAlimento, int cantidadDesplazamiento, boolean saludable) {
        this.tipoAlimento = tipoAlimento;
        this.cantidadDesplazamiento = cantidadDesplazamiento;
        this.saludable = saludable;
    }

    /**
     * los getters and setters para los atributos
     */
    public String getTipoAlimento() {
        return tipoAlimento;
    }

    public void setTipoAlimento(String tipoAlimento) {
        this.tipoAlimento = tipoAlimento;
    }

    public int getCantidadDesplazamiento() {
        return cantidadDesplazamiento;
    }

    public void setCantidadDesplazamiento(int cantidadDesplazamiento) {
        this.cantidadDesplazamiento = cantidadDesplazamiento;
    }

    public boolean esSaludable() {
        return saludable;
    }

    public void setSaludable(boolean saludable) {
        this.saludable = saludable;
    }

    public void desplazar() {
        int nuevaX = getX() + cantidadDesplazamiento;
        int nuevaY = getY();
        setLocation(nuevaX, nuevaY);
          if(nuevaX >= getWorld().getWidth()) {
            getWorld().removeObject(this); // Eliminamos el alimento cuando sale del mundo
        }
    }

    public void act() {
        desplazar();
    }
}
