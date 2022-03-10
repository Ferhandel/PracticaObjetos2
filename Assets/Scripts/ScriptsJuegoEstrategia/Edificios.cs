using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edificios : PlayableCharacter
{
    public Edificios(string n){
       Nacer();
       nombre = n;
       Debug.Log("Creado " + nombre);
       vidaTotal = vidaActual;
       vidaActual = 150;
       if (!getViva()){
           Debug.Log("Edificio Rojo destruido");
       }    
    }
}
//poner los enumerados fuera de la clase para que todas las clases puedan usarlos
/*public enum tipoEdificio { 
        Granja,
        Casa,
        Cuartel,
        Iglesia,
        Castillo
    }
*/