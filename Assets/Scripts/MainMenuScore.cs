using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScore : MonoBehaviour
{

    public int gold = 0, hscore = 0, starnum=0;
    public Text gs, hs, star;
    

    public GameObject pl;
   // public static DetectCollision detectCollision;
    public void Awake()
    {
        
        // detectCollision = FindObjectOfType<DetectCollision>();
        //gs.text = DetectCollision.dt.ngold;
        gold = PlayerPrefs.GetInt("gold", 0);
        gs.text = gold.ToString();
        hscore = PlayerPrefs.GetInt("highscore", 0);
        hs.text = hscore.ToString();
        starnum = PlayerPrefs.GetInt("star", 0);
        star.text = starnum.ToString();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
