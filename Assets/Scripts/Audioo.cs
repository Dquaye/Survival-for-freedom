using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioo : MonoBehaviour
{
    public int num = 0;

    public void Onclick()
    {
        if (num == 0)
        {
            // Destroy(GameObject.Find("AudioListener").GetComponent<AudioListener>());
            AudioListener.pause = true;
            num = 1;
        }
        else
        {
            // GameObject.Find("AudioListener").AddComponent<AudioListener>();
            AudioListener.pause = false;
            num = 0;
        }
    }
}
