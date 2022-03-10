using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerreiro : Militar
{
    //Constructor
    public Guerreiro (string n){ 
         Nacer();
         vidaTotal = vidaActual;
         vidaActual = 100;
         attackPower = 10;
         nombre = n;
         Debug.Log("Creado " + nombre);
         if(!getViva()){
             Debug.Log("Ha muerto un guerrero");
         }
         

         
    }
}
