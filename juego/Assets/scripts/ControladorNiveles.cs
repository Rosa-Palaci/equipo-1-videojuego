using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class ControladorNiveles : MonoBehaviour
{
    public GameObject[] objetosParaDetectar; // Lista de objetos a detectar
    [SerializeField] private float retrasoEntreEscenas = 3.0f; // retraso entre cada escena

    void Update()
    {
        foreach (var objeto in objetosParaDetectar)
        {
            if (objeto == null)
            {
                // Uno de los objetos fue destruido, cambia de escena
                StartCoroutine(CambiarEscenaConRetraso());
                return;
            }
        }
    }







    private IEnumerator CambiarEscenaConRetraso()
    {

        // Espera el retraso antes de cambiar de escena
        yield return new WaitForSeconds(retrasoEntreEscenas);
        // Obtiene el nombre de la escena actual
        string nombreDeEscenaActual = SceneManager.GetActiveScene().name;

        // Lista de nombres de escenas que deben llevar a la escena 0
        List<string> escenasEspeciales = new List<string> { "M10", "q10", "f10", "b10" };

        // Verifica si el nombre de la escena actual está en la lista de escenas especiales
        if (escenasEspeciales.Contains(nombreDeEscenaActual))
        {
            // Carga la escena 0
            SceneManager.LoadScene(1);
        }
        else
        {
            // Si no es una escena especial, carga la siguiente escena como lo hacías antes
            int indiceDeSiguienteEscena = (SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCountInBuildSettings;
            SceneManager.LoadScene(indiceDeSiguienteEscena);
        }

    }
}