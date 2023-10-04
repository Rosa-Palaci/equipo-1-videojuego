using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class bala : MonoBehaviour
{
    public textos1 t1;
    public score Score;
    [SerializeField] private float velocidad; //velocidad de la bala
    public float retrasoEntreEscenas = 1000f; // retraso entre cada escena
    public bool completado = false;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {

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
            CambiarEscenaConRetraso();
            Debug.Log("ganaste");
            
            //obj.GetComponent<textos>().opcion1.text = "a";
            DestruirObjetosPorEtiqueta("correcta");
            DestruirObjetosPorEtiqueta("incorrecta");
            StartCoroutine(CambiarEscenaConRetraso());





        }

        if (obj.tag == "incorrecta")
        {
            CambiarEscenaConRetraso();
            Debug.Log("perdiste");
            retrasoEntreEscenas = 10f;
            //obj.GetComponent<textos>().opcion1.text = "a";

            DestruirObjetosPorEtiqueta("correcta");
            DestruirObjetosPorEtiqueta("incorrecta");
            StartCoroutine(CambiarEscenaConRetraso());




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

    private IEnumerator CambiarEscenaConRetraso()
    {
        // Espera el retraso antes de cambiar de escena
        yield return new WaitForSeconds(retrasoEntreEscenas);

        // Obtén el índice de la escena actual
        int indiceDeEscenaActual = SceneManager.GetActiveScene().buildIndex;

        // Calcula el índice de la siguiente escena
        int indiceDeSiguienteEscena = (indiceDeEscenaActual + 1) % SceneManager.sceneCountInBuildSettings;

        // Carga la siguiente escena
        SceneManager.LoadScene(indiceDeSiguienteEscena);
    }

    private void DesactivarBala()
    {
        // Desactivar el renderizador de la bala para hacerla invisible
        spriteRenderer.enabled = false;
    }

}
