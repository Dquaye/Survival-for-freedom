using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeMenu : MonoBehaviour
{
    /*public bool pasdd = true;
    public static PauseMenu ps;
    public static ResumeMenu rm;
    public int resume;*/
    [SerializeField] public GameObject pausePanel;

    public void Resume()
    {
        /*ps.pasd = false;
        pasdd = true;*/
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        
    }
}
