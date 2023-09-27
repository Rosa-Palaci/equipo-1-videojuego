using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionMeteorito : MonoBehaviour
{
    public float rotationSpeed = 20f; // Velocidad de rotación en grados por segundo
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
