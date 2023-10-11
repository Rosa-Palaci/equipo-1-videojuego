using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bala : MonoBehaviour
{
    public textos text;
    public score Score;
    public GameObject explosion;
    [SerializeField] private float velocidad; //velocidad de la bala
    [SerializeField] private float retrasoEntreEscenas = 3.0f; // retraso entre cada escena
    public GameObject sonidoMeteoritoExplosionPrefab;



    // Start is called before the first frame update
    void Start()
    {

    }

    private void Awake()
    {
        // Busca el objeto con el script textos y el objeto con el script score en tiempo de ejecución.
        text = FindObjectOfType<textos>();
        Score = FindObjectOfType<score>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.tag == "correcta")
        {
            Instantiate(explosion, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), transform.rotation);
            GameObject explosionMeteorito = Instantiate(sonidoMeteoritoExplosionPrefab);
            AudioSource audioSource = explosionMeteorito.GetComponent<AudioSource>();
            audioSource.Play();
            Debug.Log("ganaste");
            DestruirObjetosPorEtiqueta("correcta");
            DestruirObjetosPorEtiqueta("incorrecta");
            // Destruir el objeto después de reproducir el sonido 
            Destroy(explosionMeteorito, audioSource.clip.length);

            int topicActual = text.topic;
            Debug.Log("topic " + topicActual);

            // Suma 1 punto en la asignatura correspondiente según el "topic"
            switch (topicActual)
            {
                case 0: // Química
                    Debug.Log("sumo quimica");
                    Score.puntosQuimica++;
                    break;
                case 1: // Física
                    Debug.Log("sumo fisica");
                    Score.puntosFisica++;
                    break;
                case 2: // Matemáticas
                    Debug.Log("sumo matematicas");
                    Score.puntosMatematicas++;
                    break;
                case 3: // Biología
                    Debug.Log("sumo biologia");
                    Score.puntosBiologia++;
                    break;
            }
        }

        if (obj.tag == "incorrecta")
        {
            Instantiate(explosion,new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z),transform.rotation);
            GameObject explosionMeteorito = Instantiate(sonidoMeteoritoExplosionPrefab);
            AudioSource audioSource = explosionMeteorito.GetComponent<AudioSource>();
            audioSource.Play();
            Debug.Log("perdiste");
            DestruirObjetosPorEtiqueta("correcta");
            DestruirObjetosPorEtiqueta("incorrecta");
            // Destruir el objeto después de reproducir el sonido 
            Destroy(explosionMeteorito, audioSource.clip.length);
            
        }
    }

    void DestruirObjetosPorEtiqueta(string etiqueta)
    {
        // Encuentra todos los objetos en la escena con la etiqueta especificada
        GameObject[] objetosConEtiqueta = GameObject.FindGameObjectsWithTag(etiqueta);

        // Itera a través de los objetos y los destruye
        foreach (GameObject objeto in objetosConEtiqueta)
        {
            Destroy(objeto);
        }
    }
}
