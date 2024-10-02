using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    // Variables publicas
    public float interactionDistance;

    // Funcion de interacion
    public void Interaction()
    {
        // Si apretamos la tecla E
        if (Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonDown(0))
        {
            // Creamos un rayo desde la camara hacia el frente de ella
            RaycastHit _hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out _hit, interactionDistance))
            {
                // Si el rayo colisionó con un objeto interactuable entonces interactuamos
                if (_hit.collider.gameObject.GetComponent<InteractableObject>() != null)
                {
                    _hit.collider.gameObject.GetComponent<InteractableObject>().Interact();
                }
            }
        }
    }
}
