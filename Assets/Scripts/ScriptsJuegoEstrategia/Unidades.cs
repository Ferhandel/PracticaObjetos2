using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unidades : MonoBehaviour
{
    protected int vidaTotal;

    protected int vidaActual;

    protected Vector3 dimensiones;

    protected int vision;

    protected bool viva;

    protected string nombre;


    public string SerAtacado(int poderAtaque){
        vidaActual = vidaActual - poderAtaque;
         if (vidaActual <= 0) {
            Morir();
        }
        return "Fui atacado con " + poderAtaque + " puntos";
    }

    public string Nacer(){
        viva = true;
        Debug.Log("He nacido " + nombre);
        return "He nacido";
    }

    // Ejercicio diseñar cómo mueren las unidades
    public void Morir(){
        viva = false;
        Debug.Log("He muerto");
    }  
    // Ejercicio hacer método para saber si la unidad está viva

    public bool getViva(){
        return viva; //por defecto está en true
    }

    
}
