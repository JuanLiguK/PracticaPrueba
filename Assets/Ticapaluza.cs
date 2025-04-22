using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticapaluza : MonoBehaviour
{

    public int entradas_campo;
    public int entradas_platea;

    int entradas_final;


    // Start is called before the first frame update
    void Start()
    {

        if (entradas_campo > 20400 || entradas_platea > 16200 && entradas_campo <= 0 || entradas_platea <= 0) 
        {
            Debug.Log("Cantidad no disponible.");
            return;
        }
        else
        {
            entradas_campo = entradas_campo * 1200;
            entradas_platea = entradas_platea * 2000;
            entradas_final = entradas_campo + entradas_platea;
            Debug.Log("Las entradas del campo son " + entradas_campo + " y las entradas de la platea son " + entradas_platea + " el total es de " + entradas_final + " entradas");
        }

        entradas_final = entradas_campo + entradas_platea;
        if (entradas_final == 24000)
        {
            Debug.Log("Sold out!");
        }
      
        if (entradas_final >= 12000)
        {
            Debug.Log("¡El festival fue un exito!");
        }
        else
        {
            Debug.Log("Debemos mejorar la convocatoria.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
