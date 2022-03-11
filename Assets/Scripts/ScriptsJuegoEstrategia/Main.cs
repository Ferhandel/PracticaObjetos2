using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour

{  
    // = asignacion     == comparación
    //hay clases que no queremos instanciar o hacer objetos porque no tendría sentido, como no tendría sentido instanciar un objeto Persona
    //pero si un objecto Aldeano que deriba de este

    //necesitas un constructor para instanciar un objeto
    // una clase ABSTRACTA es una clase que no se puede instanciar (no se puede hacer objeto)


        
      /*Aldeano aldeano1 = new Aldeano(" n");
        aldeano1.Trabajar();
        aldeano1.MovimientoTierra();
        */

    // Ejercicio crear 10 aldeanos y ponerlos a trabajar

        /*List<Aldeano> listaAldeanos = new List<Aldeano>(); //se crea la lista para que no se borren los aldeanos que creemos

        for (int i = 0; i < 10; i++) {
            Aldeano aldeanoTemporal = new Aldeano();
            aldeanoTemporal.Trabajar(); 
            listaAldeanos.Add(aldeanoTemporal); //para que quede añadido en la lista

        
        }

        foreach (Aldeano aldeanoTemporal in listaAldeanos){ 
            aldeanoTemporal.Trabajar();         

        }
        */

       // Ejercicio crear 3 aldeanos y ponerles nombre
       
        /* List<Aldeano> listaAldeanos = new List<Aldeano>(); 
        
        for (int i = 0; i<3; i++) {
            string nombreAleatorio =  Persona.listaNombres[Random.Range(0, Persona.listaNombres.Count)];
            //Aldeano aldeanoTemporal = new Aldeano(Persona.listaNombres[i]); forma sucia para hacer que no se repitan los nombres
            Aldeano aldeanoTemporal = new Aldeano(nombreAleatorio);
            listaAldeanos.Add(aldeanoTemporal); //para que quede añadido en la lista
            
        }
        */

        // Ejercicio crear militar, aldeano y que el militar ataque al aldeano
        
       /* Militar verdugo = new Militar(" Namjoon");
        
        Aldeano victima = new Aldeano(" Jin");

        Debug.Log(victima.ToString());

        //int puntosAtaque = verdugo.Atacar();
        //victima.SerAtacado(puntosAtaque);
        for (int i = 0; i<11; i++){
            victima.SerAtacado(verdugo.Atacar());  
            if (! victima.getViva()) {
                victima = null;
                Debug.Log("Destruimos victima");
                break; //se sale del bucle para que no siga atacando a un obsjeto que ya está null
            }
        }
    

       // Ejercicio hacer método toString() para aldeano y militar que devuelvan un string con todos los atributos del objeto

       Debug.Log(victima.ToString());
       Debug.Log(verdugo.ToString()); 
    */

       //si pones un objeto = null es lo mismo que destruirlo solo se puede destruir una unidad en el main
       //Creamos las funciones de vivir y morir y destruímos el objeto si no está vivo 
       /*if (! victima.getViva()) {
           victima = null;
           Debug.Log("Destruimos victima");
       }*/

       // Ejercicio crear equipo rojo y equipo azul, con 1 aldeano (será el únco atacado) y 3 militares que atacan con 10, 20 y 30 respectivamente 
       // ataca un militar aleatoriamente cada vez. Primero ataca el equipo rojo y luego el azul.
       // Gana el primer equipo que consiga matar al aldeano del otro equipo.
       // Que ataquen los militares con 10, 20, 30(en el constructor le añadimos un int para ponerles los puntos de ataque)

       
        //List<Aldeano> AldeanosAzules = new List<Aldeano>(){new Aldeano(" Aldeano Azul") };

        //List<Militar> MilitaresAzules = new List<Militar>(){new Militar(" Militar Azul 1", 10), new Militar(" Militar Azul 2", 20), new Militar(" Militar Azul 3", 30)};

        //List<Aldeano> AldeanosRojos = new List<Aldeano>(); 

        //AldeanosRojos.Add(new Aldeano("Aldeano Rojo"));

        //List<Militar> MilitaresRojos = new List<Militar>();
       /* int puntosAtaqueTemporal = 10;
        for (int i=0; i<3; i++){
            MilitaresRojos.Add(new Militar(Persona.listaNombres[Random.Range(0, Persona.listaNombres.Count)], puntosAtaqueTemporal ));
            puntosAtaqueTemporal += 10;
        }
        */
        //Otra forma de hacerlo sería usando la i en vez de puntosAtaqueTemporal
        //for (int i=0; i<3; i++){
            //MilitaresRojos.Add(new Militar(Persona.listaNombres[Random.Range(0, Persona.listaNombres.Count)], (i + 1) * 10 )); // también valdría (1*10) +10
            
        //}

        
        //si sabemos el numero exacto de repeticiones o elementos usamos un for, si no sabemos el numero de veces que necesitamos repetir el bucle(en este caso atacar) usamos un bucle while
        // Que empiece a atacar inicialmente aleatoriamente uno de los dos equipos
        /* FORMA SUCIA
        int opcion = Random.Range(0, 2);//que la opcion sea 0 o 1 aleatoriamente (pq el 2 es exclusivo nunca va a salir)
        while (AldeanosAzules[0].getViva() && AldeanosRojos[0].getViva()){

            if(opcion==1){
                AldeanosAzules[0].SerAtacado(MilitaresAzules[Random.Range(0, 3)].Atacar());
                    if( ! AldeanosAzules[0].getViva()){
                        Debug.Log("Ganó el Rojo");
                        break;
                    }

                AldeanosRojos[0].SerAtacado(MilitaresRojos[Random.Range(0, 3)].Atacar());
                if( ! AldeanosRojos[0].getViva()){
                        Debug.Log("Ganó el Azul");
                        break; //este break no es necesario porque se comprueba si están vivos los aldeanos al principio del bucle 
                    }
            }

            else{
                
            AldeanosRojos[0].SerAtacado(MilitaresRojos[Random.Range(0, 3)].Atacar());
              if( ! AldeanosRojos[0].getViva()){
                    Debug.Log("Ganó el Azul");
                    break; 
                }
            AldeanosAzules[0].SerAtacado(MilitaresAzules[Random.Range(0, 3)].Atacar());
                if( ! AldeanosAzules[0].getViva()){
                    Debug.Log("Ganó el Rojo");
                    break;
                }
        
            }
        }
        */


        //Creadas dos listas nuevas.
        //Aldeanos con posicion 0 y 1. 
        //En la 0 están los azules y en la 1 los rojos
        //Y la lista de Militares
        //Con los azules en la 0 y los rojos en la 1.
        /*int atacante = Random.Range(0,2);
        int defensor;
        if(atacante == 0){
            defensor = 1;
        } else{
            defensor = 0;
        }

        //Lista de listas
        //De aldeanos
        List<List<Aldeano>> aldeanos = new List<List<Aldeano>>();
        aldeanos.Add(AldeanosAzules);
        aldeanos.Add(AldeanosRojos);

        //De Militares
        List<List<Militar>> militares = new List<List<Militar>>();
        militares.Add(MilitaresAzules);
        militares.Add(MilitaresRojos);

        //Condición 
        //while, mientras lo de dentro del while se cumple, se sigue haciendo en bucle
        while (AldeanosAzules[0].getViva() && AldeanosRojos[0].getViva()){
            if( ! MilitarAtacaAldeano(militares[atacante][Random.Range(0,3)], AldeanosRojos[0])){
                        Debug.Log("Ganó alguén");
                        break;
                    }
                    atacante = defensor;
                    if(atacante == 0){
                    defensor = 1;
                    } else{
                    defensor = 0;
                }
        }
      
    

    //metodo para el conflicto belico de grandes proporciones
    private bool MilitarAtacaAldeano( Militar m, Aldeano a){

        //El Aldeano es atacado por el Militar (mala vibra el pive).
        a.SerAtacado(m.Atacar());

        //Para saber si ha muerto o no un aldeano
        return a.getViva();
       
    } 


 /*
    Exercicio final: Crea dúas listas, unha do equipo vermello, e un do equipo azul.
    As listas contendran todas as unidades de cada equipo.
    Crea as clases guerreiro e arqueiro.    
    Crea dous aldeanos para cada equipo. 
    Crea un edificio para cada equipo.
    Crea un guerreiro e un arqueiro por equipo. O guerreiro ataca 10 e o arqueiro 5.
    Fai que un dos dous aleatoriamente ataque a unha das catro unidades aleatoriamente (asumimos que estan en rango de ataque).
    Se unha unidade xa morreu, debe notificarse, pero se a atacan, pásase o turno.
    En cada unidade de tempo, atacará un dos dous equipos aleatoriamente.
    Imprime por pantalla o que pasa e quen gaña.
 */

    // Start is called before the first frame update 
    int pelea;
    void Start()
    {
        //Equipo rojo
        //Creamos una lista de listas para el equipo rojo: listaEquipoRojo 
        List<Unidades> listaVermellos = new List<Unidades>(); 
        //Creamos a los 2 aldeanos rojos:
        Aldeano aldeanoRojo1 = new Aldeano("AldeanoRojo1");
        Aldeano aldeanoRojo2 = new Aldeano("AldeanoRojo2");
        //Creamos a guerreroRojo
        Guerreiro guerreiroRojo = new Guerreiro("GuerreiroRojo");
        //Creamos a arquieroRojo
        Arqueiro arqueiroRojo = new Arqueiro("ArqueiroRojo");
        //Creamos a edificioRojo
        Edificios edificioRojo = new Edificios("EdificioRojo");
        //Añadimos los integrantes del equipo Vermellos a la lista
        //aldeanosRojos1y2
        listaVermellos.Add(aldeanoRojo1);
        listaVermellos.Add(aldeanoRojo2);
        //guerreroRojo
        listaVermellos.Add(guerreiroRojo);
        //arquieroRojo
        listaVermellos.Add(arqueiroRojo);
        //edificioRojo
        listaVermellos.Add(edificioRojo);

        //Equipo azul
        //Creamos una lista de listas para el equipo azul: listaAzul:
        List<Unidades> listaAzul = new List<Unidades>(); 
        //Creamos a los 2 aldeanos azules:
        Aldeano aldeanoAzul1 = new Aldeano("AldeanoAzul1");
        Aldeano aldeanoAzul2 = new Aldeano("AldeanoAzul2");
        //Creamos a guerreiroAzul:
        Guerreiro guerreiroAzul = new Guerreiro("GuerreiroAzul");
        //Creamos a arquieroAzul:
        Arqueiro arqueiroAzul = new Arqueiro("ArqueiroAzul");
        //Creamos a edificioAzul:
        Edificios edificioAzul = new Edificios("EdificioAzul");
        //Añadimos los integrantes del equipo Azul a listaAzul:
        //aldeanosAzules1y2:
        listaAzul.Add(aldeanoAzul1);
        listaAzul.Add(aldeanoAzul2);
        //guerreroAzul:
        listaAzul.Add(guerreiroAzul);
        //arquieroAzul
        listaAzul.Add(arqueiroAzul);
        //edificioAzul
        listaAzul.Add(edificioAzul);   

        //Pelea
        //Usamos todosMortos aqui y nos ahorramos codego jeje 
        while (! todosMortos(listaVermellos) || ! todosMortos(listaAzul)){
                pelea = Random.Range(0,2);
                int valorListaDefensa = Random.Range(0,5);
                int valorListaAtaque = Random.Range(2,4);

                if(pelea == 1){
                    if(listaAzul[valorListaDefensa].getViva() && listaVermellos[valorListaAtaque].getViva()){
                        listaAzul[valorListaDefensa].SerAtacado(((Militar)listaVermellos[valorListaAtaque]).Atacar());                   
                    }
                    if(todosMortos(listaAzul) || ! listaAzul[2].getViva() && ! listaAzul[3].getViva() ){
                        Debug.Log("GANA EL EQUIPO ROJO");
                        break;
                    }
                } else if (pelea == 0) {   
                    if(listaVermellos[valorListaDefensa].getViva() && listaAzul[valorListaAtaque].getViva()){
                        listaVermellos[valorListaDefensa].SerAtacado(((Militar)listaAzul[valorListaAtaque]).Atacar());
                    }                                        
                    if(todosMortos(listaVermellos) || ! listaVermellos[2].getViva() && ! listaVermellos[3].getViva()){
                        Debug.Log("GANA EL EQUIPO AZUL");
                        break;                     
                }       
        } 
            
       }  
    }
   
    //para comprobar si estan todos vivos o muertos: 
    private bool todosMortos(List<Unidades> equipo){
            foreach(Unidades unidad in equipo){
                    if(unidad.getViva()){
                        return false;
                    }
                 }
                 return true; 
            }
}
