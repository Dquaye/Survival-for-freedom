using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidewithshield : MonoBehaviour
{

    public GameObject shield;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

   public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {                 
            
            Destroy(collision.gameObject);
            shield.SetActive(false);

        }
    }

   
}
