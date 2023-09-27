using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class textos : MonoBehaviour
{

    public TMP_Text pregunta;

    public TMP_Text op3;
    public TMP_Text op1;
    public TMP_Text op2;
    


    // Start is called before the first frame update
    void Start()
    {

        string nombreDeEscenaActual = SceneManager.GetActiveScene().name;
        
        if(nombreDeEscenaActual == "principal")
        {
            pregunta.text = "Cual es el planeta mas grande?"; // p1q
            op1.text = "respuesta 1"; //corecta
            op2.text = "respuesta 2";
            op3.text = "respeusta 3"; 
            
        }
        if (nombreDeEscenaActual == "uno")
        {
            pregunta.text = "Cual es el planeta mas grande?"; // p2q
            op1.text = "uno"; 
            op2.text = "uno"; //corecta
            op3.text = "uno";
        }
        if (nombreDeEscenaActual == "dos")
        {
            pregunta.text = "Cual es el planeta mas grande?"; // p3q
            op1.text = "dos"; 
            op2.text = "dos";
            op3.text = "dos";
        }
        if (nombreDeEscenaActual == "tres")
        {
            pregunta.text = "Cual es el planeta mas grande?"; // p4q
            op1.text = "tres"; 
            op2.text = "tres";
            op3.text = "tres";
        }


    }

    // Update is called once per frame
    void Update()
    {
     
}
}
