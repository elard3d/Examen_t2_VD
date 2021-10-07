using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleController : MonoBehaviour
{

    private Rigidbody2D _rigidbody;
    private EnemyController enemigo; 
    private ScoreController _scoreController;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _scoreController = FindObjectOfType<ScoreController>();
        Destroy(this.gameObject, 3);
        enemigo = FindObjectOfType<EnemyController>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = new Vector2(10f, _rigidbody.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {enemigo.vidaEnemigo(1);




            //Que le pasara al enemigo AQUI
        }
    }
}
