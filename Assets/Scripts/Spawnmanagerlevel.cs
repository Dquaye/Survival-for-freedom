using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanagerlevel : MonoBehaviour
{
    public GameObject[] animalprefab;
    private float spawnRangeX = 4.05f;
    private float spawnPosZ = 20;
    private float spawnsdelay = 2;
    private float spawnintervals = 10.0f;
    // private float spawnPostiveZ = 2.0f;
    // private float spawnPosX = 23.5f;
    private float spawnY = 0.5f;

     



    // Start is called before the first frame update
    void Start()
    {
        // calling the function
       InvokeRepeating("SpawnRandomAnimal", spawnsdelay, spawnintervals);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {

        int animalIndex = Random.Range(0, animalprefab.Length);
        // Automaticall Randomly generating animal index and random animal spawning

        Vector3 spawnposX = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnY, spawnPosZ);

        Instantiate(animalprefab[animalIndex], spawnposX, animalprefab[animalIndex].transform.rotation);


    }
    
}