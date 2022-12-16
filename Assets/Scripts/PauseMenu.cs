using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public bool pasd = false;
    //public UnityEvent GamePaused;
    //public UnityEvent GameResumed;
    [SerializeField] public GameObject pausePanel;
    public GameObject score;

    public static PauseMenu pauseMenu;
    ResumeMenu rm;
    //public Text onnn;
   // public Text scoretxt;
    //public bool ispaused;
    public int on = 0;
    
    
    
    public int score1 = 0;
   /* private void Start()
    {
        *//*score1 = PlayerPrefs.GetInt("score1", 0);
        score1 = 0;
        scoretxt.text = score1.ToString();

        // ispaused = false;
        on = 0;*//*
       // rm = FindObjectOfType<ResumeMenu>();
    }
    *//*void Update()
    {*//*


        score1 += 1;
        
        scoretxt.text = score1.ToString();
        
            PlayerPrefs.SetInt("score1", score1);
            score1 = PlayerPrefs.GetInt("score1", 0);
            scoretxt.text = score1.ToString();
        

        
    }*/

    public void Pause()
    {

        //onnn.text = "1";
        Time.timeScale = 0;
        //GamePaused.Invoke();
        pausePanel.SetActive(true);
       // pasd = true;
        //rm.pasdd = true;
        //Debug.Log(on);
       // pasdimgbtn.SetActive(true);
        /* score1 = PlayerPrefs.GetInt("score", 0);
         PlayerPrefs.SetInt("score", score1);
         scoretxt.text = score1.ToString();
         score.SetActive(false);*/
        //ispaused = true;

        /*if (on == 0)
        {
            on = 1;
            Time.timeScale = 0;
            //GamePaused.Invoke();
            pausePanel.SetActive(true);
            Debug.Log(on);
            pasdimgbtn.SetActive(true);
            
        }*/
        /*else if (on == 1)
        {
            on = 2;
            Time.timeScale = 1f;
            // GameResumed.Invoke();
            pausePanel.SetActive(false);
            Debug.Log(on);
        }
        else if (on == 2)
        {
            on = 1;
            Time.timeScale = 0;
            //GamePaused.Invoke();
            pausePanel.SetActive(true);
            Debug.Log(on);
            pasdimgbtn.SetActive(true);
        }*/





        /* pausePanel.SetActive(true);
         score.SetActive(false);
         Time.timeScale = 0f;
         GamePaused.Invoke();*/
    }


    /*public void Resume()
    {
        //onnn.text = "0";
        Time.timeScale = 1;
        //GamePaused.Invoke();
        pausePanel.SetActive(false);
       // Debug.Log(on);
       // pasdimgbtn.SetActive(true);

        *//*score.SetActive(true);
        score1 = PlayerPrefs.GetInt("score", 0);
        PlayerPrefs.SetInt("score", score1);
        scoretxt.text = score1.ToString();
        //ispaused = false;
        if (on == 1)
        {
            on = 2;
            Time.timeScale = 1f;
            // GameResumed.Invoke();
            pausePanel.SetActive(false);
            Debug.Log(on);
        }



        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        score.SetActive(true);*//*

    }*/
}
