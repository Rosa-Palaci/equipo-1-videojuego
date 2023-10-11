using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoJugador : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject bala;
    public GameObject sonidoDisparoPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            GameObject sonidoDisparo = Instantiate(sonidoDisparoPrefab);

            
            AudioSource audioSource = sonidoDisparo.GetComponent<AudioSource>();

            
            audioSource.Play();

            // Destruir el objeto después de reproducir el sonido 
            Destroy(sonidoDisparo, audioSource.clip.length);
            //disparar
            Disparar();
        }
    }

    private void Disparar()
    {
        // Instancia la bala
        GameObject balaInstanciada = Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);

        // Destruye la bala después de un cierto tiempo 
        float tiempoDeVida = 0.4f; // Cambia esto al tiempo que desees
        Destroy(balaInstanciada, tiempoDeVida);
    }
}
