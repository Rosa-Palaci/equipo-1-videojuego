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
    public int topic;

    // 0: Química
    // 1: Física
    // 2: Matemáticas
    // 3: Biología

    // Start is called before the first frame update
    void Start()
    {
        topic = 0;
        string nombreDeEscenaActual = SceneManager.GetActiveScene().name;
        
        if(nombreDeEscenaActual == "principal")
        {
            pregunta.text = "Cual es el planeta mas grande?"; // p1q
            op1.text = "respuesta 1"; //corecta
            op2.text = "respuesta 2";
            op3.text = "respeusta 3";
            topic = 0;
            
            // PREGUNTAS DE MATEMATICAS
        }
        if (nombreDeEscenaActual == "M1")
        {
            pregunta.text = "M1"; // p2q
            op1.text = "correcta"; 
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 2;
        }
        if (nombreDeEscenaActual == "M2")
        {
            pregunta.text = "M2"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 2;
        }
        if (nombreDeEscenaActual == "M3")
        {
            pregunta.text = "M3"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 2;
        }
        if (nombreDeEscenaActual == "M4")
        {
            pregunta.text = "M4"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 2;
        }
        if (nombreDeEscenaActual == "M5")
        {
            pregunta.text = "M5"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 2;
        }

        //PREGUNTAS DE FISICA

        if (nombreDeEscenaActual == "F1")
        {
            pregunta.text = "F1"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 1;
        }
        if (nombreDeEscenaActual == "F2")
        {
            pregunta.text = "F2"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 1;
        }
        if (nombreDeEscenaActual == "F3")
        {
            pregunta.text = "F3"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 1;
        }
        if (nombreDeEscenaActual == "F4")
        {
            pregunta.text = "F4"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 1;
        }
        if (nombreDeEscenaActual == "F5")
        {
            pregunta.text = "F5"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 1;
        }

        // PREGUNTAS DE BIOLOGIA

        if (nombreDeEscenaActual == "B1")
        {
            pregunta.text = "B1"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 1;
        }
        if (nombreDeEscenaActual == "B2")
        {
            pregunta.text = "B2"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 1;
        }
        if (nombreDeEscenaActual == "B3")
        {
            pregunta.text = "B3"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 1;
        }
        if (nombreDeEscenaActual == "B4")
        {
            pregunta.text = "B4"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 1;
        }
        if (nombreDeEscenaActual == "B5")
        {
            pregunta.text = "B5"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 1;
        }


        // PREGUNTAS DE QUIMICA

        if (nombreDeEscenaActual == "Q1")
        {
            pregunta.text = "Q1"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 1;
        }
        if (nombreDeEscenaActual == "Q2")
        {
            pregunta.text = "Q2"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 1;
        }
        if (nombreDeEscenaActual == "Q3")
        {
            pregunta.text = "Q3"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 1;
        }
        if (nombreDeEscenaActual == "Q4")
        {
            pregunta.text = "Q4"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 1;
        }
        if (nombreDeEscenaActual == "Q5")
        {
            pregunta.text = "Q5"; // p2q
            op1.text = "correcta";
            op2.text = "uno"; //corecta
            op3.text = "uno";
            topic = 1;
        }









        if (nombreDeEscenaActual == "dos")
        {
            pregunta.text = "Cual es el planeta mas grande?"; // p3q
            op1.text = "correcta"; 
            op2.text = "dos";
            op3.text = "dos";
            topic = 2;
        }
        if (nombreDeEscenaActual == "tres")
        {
            pregunta.text = "Cual es el planeta mas grande?"; // p4q
            op1.text = "correcta"; 
            op2.text = "tres";
            op3.text = "tres";
            topic = 3;
        }


    }

    // Update is called once per frame
    void Update()
    {
     
}
}
