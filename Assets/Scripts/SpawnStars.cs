using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStars : MonoBehaviour
{
    public GameObject[] starprefab;
    private float spawnRangeX = 4.05f;
    private float spawnPosZ = 20;
    private float spawnsdelay = 5.0f;

    private float spawnintervals = 3.0f;

    // private float spawnPostiveZ = 2.0f;
    // private float spawnPosX = 23.5f;
    private float spawnY = 0.5f;





    // Start is called before the first frame update
    void Start()
    {
        // calling the function
        InvokeRepeating("SpawnRandomStar", spawnsdelay, spawnintervals);



    }

    // Update is called once per frame
    void Update()
    {



    }

    void SpawnRandomStar()
    {


        // Automaticall Randomly generating gold index and random gold spawning

        Vector3 spawnposX = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnY, spawnPosZ);

        Instantiate(starprefab[0], spawnposX, starprefab[0].transform.rotation);


    }
}
