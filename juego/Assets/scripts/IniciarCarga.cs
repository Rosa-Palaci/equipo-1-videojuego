using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarCarga : MonoBehaviour
{
    public string nombreDeLaEscenaDeCarga = "Carga";

    void Start()
    {
        SceneManager.LoadScene(nombreDeLaEscenaDeCarga);
    }
}
