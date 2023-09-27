using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionpreguntas : MonoBehaviour
{
    public float rotationSpeed = 30f; // Velocidad de rotación en grados por segundo


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotar el objeto alrededor del eje Y (vertical) a la velocidad especificada
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
