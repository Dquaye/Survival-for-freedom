using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawngold : MonoBehaviour
{
    public GameObject[] goldprefab;
    private float spawnRangeX = 4.05f;
    private float spawnPosZ = 20;
    private float spawnsdelay = 4;
    
    private float spawnintervals = 2.0f;
    
    // private float spawnPostiveZ = 2.0f;
    // private float spawnPosX = 23.5f;
    private float spawnY = 0.5f;





    // Start is called before the first frame update
    void Start()
    {
        // calling the function
        InvokeRepeating("SpawnRandomGold", spawnsdelay, spawnintervals);
        


    }

    // Update is called once per frame
    void Update()
    {



    }

    void SpawnRandomGold()
    {

        
        // Automaticall Randomly generating gold index and random gold spawning

        Vector3 spawnposX = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnY, spawnPosZ);

        Instantiate(goldprefab[0], spawnposX, goldprefab[0].transform.rotation);


    }
}
