import lang.stride.*;
import java.util.*;
import greenfoot.*;

/**
 * 
 */
public class MyWorld extends World
{

    /**
     * Constructor for objects of class MyWorld.
     */
    public MyWorld()
    {
        super(626, 417, 1);// Aquí dimension de la imagen de fondo
        prepare();
    }

    /**
     * Prepare the world for the start of the program.
     * That is: create the initial objects and add them to the world.
     */
    private void prepare()
    {
        /**
         * Preparamos nuestro mundo, agregando nuestra Instancia de león
         * Le asignamos su imagen, sus atributos y su posición en el mundo.
         */
        Animal leon = new Animal("León", 5, 0); // Especie: León, Movimiento en el eje X: 5, Movimiento en el eje Y: 0
        leon.setImage("leon.png"); // Nombre archivo con la imagen del león que usaré (images/leon.png)
        addObject(leon, 34, 315); // Agrega el león en el borde inferior izquierdo del mundo

        /**
         * Agregamos nuestra instancia carne y repetimos, como en el leon
         */
        Alimento trozoCarne = new Alimento("Carne", 2, true); // Tipo de alimento, cantidad de desplazamiento, si es saludable
        trozoCarne.setImage("carne.png");
        addObject(trozoCarne, 424, 387);// coordenadas de posición de la carne en el mundo
    }
}
