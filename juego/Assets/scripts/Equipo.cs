using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Equipo : MonoBehaviour
{
    void Start()
    {
        // Llama al método CambiarEscena después de 5 segundos
        Invoke("CambiarEscena", 5.0f);
    }

    void CambiarEscena()
    {
        // Cambia a la siguiente escena
        SceneManager.LoadScene("Inicio");
    }
}