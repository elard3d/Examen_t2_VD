using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public GameObject player;
    public Transform Background;

    void Start()
    {
        
    }

    void Update()
    {
        var x = player.transform.position.x;
        var y = player.transform.position.y;
        transform.position = new Vector3(x, y, transform.position.z);
        
        Background.position = new Vector3(transform.position.x, transform.position.y, Background.position.z);


    }
}
