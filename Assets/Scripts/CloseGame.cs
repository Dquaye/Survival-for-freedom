using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CloseGame : MonoBehaviour
{

    [SerializeField] public GameObject pausePanel;

    public void Exit() 
    {
        Application.Quit();
    }

    public void ShowUpgradePanel()
    {
        pausePanel.SetActive(true);
    }

    public void HideUpgradePanel()
    {
        pausePanel.SetActive(false);
    }
}
