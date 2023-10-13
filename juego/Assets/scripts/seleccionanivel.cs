using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class seleccionanivel : MonoBehaviour
{
    public Button boton; // Asigna el botón en el Inspector

    void Awake()
    {
        if (!boton.interactable)
        {
            DesactivarBoton();
        }
    }

    public void SeleccionaNivel(string nombre)
    {
        SceneManager.LoadScene(nombre);
        DesactivarBoton();
    }

    public void DesactivarBoton()
    {
        boton.interactable = false;
    }
}
