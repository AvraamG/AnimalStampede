using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawnManager : MonoBehaviour
{

    [SerializeField] private GameObject[] animalPrefabs;
    [SerializeField] private SpawnSpot[] spawnSpots;

    private void SpawnRandomAnimal()
    {
        
        SpawnSpot randomSpawnSpot = spawnSpots[GetRandomIndex()];
    
    }

    private int GetRandomIndex()
    {
        return Random.Range(0, animalPrefabs.Length);
    }

    SpawnSpot GetAvailableRandomSpawnSpot()
    {

        return null;
    }
}
