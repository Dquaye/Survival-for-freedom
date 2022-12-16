using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    GameObject hh;
    public void playGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      
    }
    public void playagain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void changesc()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        
    }
}
