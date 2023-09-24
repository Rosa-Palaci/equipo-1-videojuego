using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textos1 : MonoBehaviour
{

   

    public TMP_Text pregunta;

    public TMP_Text op3;
    public TMP_Text op1;
    public TMP_Text op2;
    [SerializeField]
    public int Types = 0; //matematicas


    // Start is called before the first frame update
    void Start()
    {
        pregunta.text = "Cual es el planeta mas grande?"; // p1q
        op1.text = "f"; //corecta
        op2.text = "g";
        op3.text = "h";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
