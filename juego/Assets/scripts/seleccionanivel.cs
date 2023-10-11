using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class seleccionanivel : MonoBehaviour
{

    public void SeleccionaNivel(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}
