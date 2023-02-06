using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    //public GameObject[] animalPrefabsTwo;
    
    //private float spawnPosX = 26;

    public GameObject[] animalPrefabsThree;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
        InvokeRepeating("SpawnRandomAnimalTwo", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
/*
    void SpawnRandomAnimalTwo()
    {
       
        Vector3 spawnPosTwo = new Vector3(spawnPosX, 0, Random.Range(-9, 5));
        
        Instantiate(animalPrefabs[0], spawnPosTwo, animalPrefabs[0].transform.rotation);
    }*/
}
