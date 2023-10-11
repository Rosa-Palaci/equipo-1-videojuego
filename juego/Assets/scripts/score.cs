using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{


    
    public int puntosFisica = 0;
    public int puntosMatematicas = 0;
    public int puntosBiologia = 0;
    public int puntosQuimica = 0;
    public int total;


    private static score _instance;

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        total = puntosFisica + puntosMatematicas + puntosBiologia + puntosQuimica;
    }

    
}


