using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    DetectCollision dt;
    public GameObject player;
    private float lives = 3;
    private float score = 0;
    
    private GameManager gameManager;

    // Start is called before the first frame update
    void Awake()
    {
        dt = player.GetComponent<DetectCollision>();
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    public void AddLives(int value)
    {
        lives += value;
        if (lives <= 0)
        {
            Debug.Log("Game Over");
            lives = 0;
        }
        Debug.Log("Lives = " + lives);
    }
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }

}
