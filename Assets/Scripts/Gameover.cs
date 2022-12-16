using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{

    public static Gameover gameover;
    public static DetectCollision detectCollision;
    public static SimpleCollectibleScript simpleCollectibleScript;
    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        scoreText.text = score.ToString();
        highscoreText.text = highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   /* public void ScoreandHighscore(int sc, int hsc)
    {
        score = sc;
        highscore = hsc;
    }*/

}
