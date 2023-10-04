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

    void CambiarEscena()
    {
        // Coloca aquí el código para cambiar de escena
        // Por ejemplo, puedes cargar la siguiente escena de la siguiente manera:
        int indiceDeSiguienteEscena = (SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(indiceDeSiguienteEscena);
    }

    private IEnumerator CambiarEscenaConRetraso()
    {

        // Espera el retraso antes de cambiar de escena
        yield return new WaitForSeconds(retrasoEntreEscenas);
        Debug.Log("Cambiando de escena...");
        // Obtén el índice de la escena actual
        int indiceDeEscenaActual = SceneManager.GetActiveScene().buildIndex;

        // Calcula el índice de la siguiente escena
        int indiceDeSiguienteEscena = (indiceDeEscenaActual + 1) % SceneManager.sceneCountInBuildSettings;

        // Carga la siguiente escena
        SceneManager.LoadScene(indiceDeSiguienteEscena);
    }

}