using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TICPalooza : MonoBehaviour
{
    public int campo;

    int campo_entradas;
    int platea_entradas;
    int entradas_totales;

    public int platea;
    int plata_final;

    // Start is called before the first frame update
    void Start()
    {
        if (campo > 20400 || platea > 16200 || campo == 0 || platea == 0)
        {
            Debug.Log("Cantidad de entradas vendidas no valida");
            return;
        }

        campo = campo + campo_entradas;
        platea = campo + platea_entradas;

        campo = campo * 1200;
        platea = platea * 2000;

        Debug.Log("De campo sacamos " + campo + " pesos");
        Debug.Log("De platea sacamos " + platea + " pesos");

        plata_final = platea + campo;
        Debug.Log("Entonces en total ganamos " + plata_final);

        entradas_totales = campo_entradas + platea_entradas;

        if (entradas_totales > 18300)
        {
            Debug.Log("El festival fue un éxito!");
        }

        else
        {
            Debug.Log("Debemos mejorar la convocatoria");
        };

        campo_entradas = 20200 - campo_entradas;
        platea_entradas = 16400 - platea_entradas;

        if (campo_entradas == 20200)
        {
            Debug.Log("Quedan " + campo_entradas + " Disponibles");
            Debug.Log("Sold Out");

        }

        else if (platea_entradas == 0)
            {
            Debug.Log("Quedan " + platea_entradas + " Disponibles");
            Debug.Log("Sold Out");
        }

        else 
        {
            Debug.Log("Quedan " + platea_entradas + " Disponibles");
            Debug.Log("Quedan " + campo_entradas + " Disponibles");
        };

        
    }

       
            
    // Update is called once per frame
    void Update()
    {
        
    }
}
