using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D rb;

    private int numvidas = 3; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-10, rb.velocity.y);

        if (numvidas <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void vidaEnemigo(int vidas)
    {

        this.numvidas -= vidas;
    }
}
