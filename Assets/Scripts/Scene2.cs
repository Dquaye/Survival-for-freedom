using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene2 : MonoBehaviour
{
    public static Scene2 s2;
    public static ScoreManager scoremanager;

    public Text displayscore;
    public Text displayhighscore;
    public Text gold;
    public Text star;
    public string gld;

    public void Awake()
    {
        displayscore.text = DetectCollision.dt.sco;
        displayhighscore.text = DetectCollision.dt.hsco;
        gold.text = DetectCollision.dt.ngold;
        star.text = DetectCollision.dt.nstar;
        gld = gold.text;
    }
}
