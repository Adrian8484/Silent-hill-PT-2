using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalllwayManager : MonoBehaviour
{
    // Variables publicas 
    public GameObject[] hallways;

    // Variables privadas 
    private int hallwayindex = 0;

    // Funcion para actiavr un nuevo pasillo 
    public void LoadHallway()
    {
        //  Aumentamos el index en 1 
        hallwayindex ++;    

        // Activamos el siguiente pasillo 
        if (hallwayindex < (hallways.Length - 1))
        {
            hallways[hallwayindex + 1].gameObject.SetActive(true);

        }
    }

    // Funcion para activar el pasillo anterior 
    public void UnloadHallway()
    {
        // Llmamos a la cortina 
        StartCoroutine(UnloadHallwayCoroutine(1.5f));
    }

    // Cortina para desactivar el pasillo 
    IEnumerator UnloadHallwayCoroutine(float _time)
    {
        // Esperen unos segudos 
        yield return new WaitForSeconds(_time);

        //Desactivar el pasiilo anteroir 
        if (hallwayindex < (0))
        {
            hallways[hallwayindex - 1].gameObject.SetActive(false);
        }
    }

}