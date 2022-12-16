using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveforwardlevel : MonoBehaviour
{

   private int speed = 18;
    int baselevelscore = 0, addscore = 1000, score = 0;
    int multiplier = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
     void Countsc()
    {

        score++;
        baselevelscore = score;
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (baselevelscore == multiplier * addscore)
        {            
            multiplier++;
            speed +=6;
            Debug.Log(speed);

            //rend.sharedMaterial = material[Random.Range(0, 3)];

        }
    }
}
