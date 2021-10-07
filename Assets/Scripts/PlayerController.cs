using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
   private SpriteRenderer _renderer;
    private Animator _animator;
    private Rigidbody2D _rigidbody;

    public GameObject smallShot;
    public GameObject bigShot;
    public GameObject enemy;

    private int planeando = 0;
    void Start()
    {
        _animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        setIdleAnimation();
        
        // if (Input.GetKeyDown(KeyCode.X))
        // {
        //    //setRunShotingAnimation();
        //     Instantiate(smallShot, transform.position, smallShot.transform.rotation);
        // }

        
        _rigidbody.velocity = new Vector2(0,_rigidbody.velocity.y);
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _renderer.flipX= false;
            setRunAnimation();
            _rigidbody.velocity = new Vector2(20,_rigidbody.velocity.y);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _renderer.flipX = true;
            setRunAnimation();
            _rigidbody.velocity = new Vector2(-20,_rigidbody.velocity.y);
        }
        
        if (Input.GetKeyUp(KeyCode.C))
        {
            var position = new Vector2(transform.position.x,transform.position.y);
            var roation = smallShot.transform.rotation;
            Instantiate(smallShot, position, roation);
        }
        
        if (Input.GetKeyUp(KeyCode.V))
        {
            var position = new Vector2(transform.position.x,transform.position.y);
            var roation = bigShot.transform.rotation;
            Instantiate(bigShot, position, roation);
        }
        
        
        if (Input.GetKeyDown(KeyCode.UpArrow) )
        {
            setJumpAnimation();
            var upSpeed = 35f;
            _rigidbody.velocity = Vector2.up * upSpeed;

            
        }
        
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            setSlideAnimation();

        }

    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Key")
        {
            SceneManager.LoadScene("Scene 2");
        }
    }

    private void setIdleAnimation(){
        _animator.SetInteger("Estado",0);
    }
    
    private void setRunAnimation(){
        _animator.SetInteger("Estado",1);
    }
    
    private void setJumpAnimation(){
        _animator.SetInteger("Estado",2);
    }
    
    private void setSlideAnimation(){
        _animator.SetInteger("Estado",3);
    }
    
    // private void setGlidAnimation(){
    //     _animator.SetInteger("Estado",3);
    // }
    //
    // private void setClimbAnimation(){
    //     _animator.SetInteger("Estado",4);
    // }

}