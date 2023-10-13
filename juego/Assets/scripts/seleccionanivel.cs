using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class seleccionanivel : MonoBehaviour
{
    bool botonesDesactivados = false;

    void Awake()
    {
        if (botonesDesactivados)
        {
            DesactivarBotonesGuardados();
        }
    }

    public void SeleccionaNivel(string nombre)
    {
        SceneManager.LoadScene(nombre);
        botonesDesactivados = true;
    }

    public void DesactivarBoton(Button button)
    {
        button.interactable = false;
        string botonKey = button.name + "Desactivado";
        PlayerPrefs.SetInt(botonKey, 1);
    }

    public void DesactivarBotonesGuardados()
    {
        Button[] buttons = FindObjectsOfType<Button>();
        foreach (Button button in buttons)
        {
            string botonKey = button.name + "Desactivado";
            int botonDesactivado = PlayerPrefs.GetInt(botonKey, 0);
            if (botonDesactivado == 1)
            {
                DesactivarBoton(button);
            }
        }
    }
}
