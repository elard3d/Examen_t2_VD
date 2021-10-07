using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{

    private int Score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public int GetScore(int score)
    {
        return this.Score;
    }
    // Update is called once per frame
    void Update()
    {
        this.Score += Score;
    }
}
