using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1 : MonoBehaviour
{
    

    public static Scene1 sc1;
    public Text inp;
    public string score;

    private void Awake()
    {
        if (sc1 == null)
        {
           sc1=this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetScoreandHiSc()
    {
        score = inp.text;
    }
}
