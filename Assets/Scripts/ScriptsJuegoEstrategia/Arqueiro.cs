using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arqueiro : Militar
{
        public Arqueiro (string n){ 
         Nacer();
         vidaTotal = vidaActual;
         vidaActual = 50;
         attackPower = 5;
         nombre = n;
         Debug.Log("Creado " + nombre);
         if(!getViva()){
             Debug.Log("Ha muerto un arqueiro");
         }

         
         
    }
}
