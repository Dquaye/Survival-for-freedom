using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeground : MonoBehaviour
{
    public Material [] Materials;
    Renderer rend;

    int baselevelscore = 0, addscore = 1000, score =0;
     int multiplier = 1, materialno = 0;
    [SerializeField] public GameObject pausePanel;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = Materials[materialno];
    }

    // Update is called once per frame
    void Update()
    {
        if(!pausePanel.activeSelf)
        {
            Changgg();
        }

    }

    void Changgg()
    {
        score += 1;
        baselevelscore = score;
        if (baselevelscore == multiplier * addscore)
        {

            multiplier++;
           
            materialno++;
            if (materialno > 3)
            {
                materialno = materialno - 4;
                rend.sharedMaterial = Materials[materialno];
            }
            rend.sharedMaterial = Materials[materialno];
        }
    }
}
