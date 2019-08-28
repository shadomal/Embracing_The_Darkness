using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Controle : MonoBehaviour
{
    Rigidbody2D fisica;
    public float velocidade = 5;


    void Start()
    {
        fisica = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        fisica.velocity = new Vector2(velocidade * moveY, fisica.velocity.y);
        fisica.velocity = new Vector2(velocidade * moveX, fisica.velocity.x);

    }
}