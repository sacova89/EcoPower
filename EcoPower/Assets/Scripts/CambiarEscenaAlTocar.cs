using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaAlTocar : MonoBehaviour
{
    public string nombreDeLaEscenaAContinuar; // El nombre de la escena a la que quieres cambiar.

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Verifica si el objeto que colisionó tiene la etiqueta "Player" (puedes personalizar esto).
            CambiarEscena();
        }
    }

    private void CambiarEscena()
    {
        SceneManager.LoadScene(nombreDeLaEscenaAContinuar);
    }
}
