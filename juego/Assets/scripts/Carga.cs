using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Carga : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public float duracionCarga = 2.0f; // Duración de la carga en segundos

    IEnumerator Start()
    {
        AsyncOperation operacionCarga = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        operacionCarga.allowSceneActivation = false;  // Evita la activación automática de la escena

        float tiempoInicio = Time.time;
        float progreso = 0f;

        while (progreso < 1.0f)
        {
            progreso = Mathf.Clamp01((Time.time - tiempoInicio) / duracionCarga);
            texto.text = "Cargando: " + (progreso * 100).ToString("F0") + "%";
            yield return null;
        }

        // Espera 3 segundos antes de permitir la activación de la siguiente escena
        yield return new WaitForSeconds(3.0f);

        operacionCarga.allowSceneActivation = true;

        while (!operacionCarga.isDone)
        {
            yield return null;
        }
    }
}
