import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class Persona here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Persona extends Actor
{
    String nombre = "Juanito";
    int RUT = 183221118;// rut sin guion y letras (mas adelante se le puede poner complejidad)
    String estadoCivil = "Casado";
    
    public void act()
    {
        move(10);
    }
}
