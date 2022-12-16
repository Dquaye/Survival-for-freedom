using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loading : MonoBehaviour
{
    float time, seconds;
    public Image fillimage;
    [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        seconds = 5;
        Invoke("LoadGame", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (time < 5)
        {
            time += Time.deltaTime;
            fillimage.fillAmount = time / seconds;
        }
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
}
