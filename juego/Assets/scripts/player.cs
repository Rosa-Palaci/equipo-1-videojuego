using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player : MonoBehaviour
{
    public score Score;
    public GameObject jugador1; // El primer objeto de jugador
    public GameObject jugador2; // El segundo objeto de jugador

    public Rigidbody2D ribiBody2D;
    private float inputValue;
    public float moveSpeed = 25;
    private Vector2 direction;
    // Start is called before the first frame update

    private GameObject resultadoTexto;
   

    void Awake() {
        

    }



   

    // Update is called once per frame
    void Update()
    {
        Score = FindObjectOfType<score>();
        if (Score.total < 2)
        {
            jugador1.SetActive(true); // si total < 10 jugador 1
            jugador2.SetActive(false);
        }
        else
        {
            jugador2.SetActive(true); // si total > 10 jugador 2
            jugador1.SetActive(false);
        }

        inputValue = Input.GetAxisRaw("Horizontal");

        if(inputValue == 1)
        {
            direction = Vector2.right;
        }
        else if(inputValue == -1)
        {
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.zero;
        }

        ribiBody2D.AddForce(direction * moveSpeed * Time.deltaTime * 100);
    }
}
