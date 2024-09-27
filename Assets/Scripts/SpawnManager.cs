using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private int RandomAnimalIndex
    {
        get => Random.Range(0, animalPrefabs.Length);
    }
    private readonly float spawnHorizontalRange = 20;
    private readonly float spawnPosZ = 20;
    private readonly float spawnInterval = 1.5f;
    private readonly float startDelay = 2;

    private void Start() => InvokeRepeating(nameof(SpawnRandomAnimalHandler), startDelay, spawnInterval);

    private void SpawnRandomAnimalHandler()
    {
        GameObject animal = animalPrefabs[RandomAnimalIndex];
        Instantiate(animal, GetRandomSpawnPosition(), animal.transform.rotation);
    }

    private Vector3 GetRandomSpawnPosition()
    {
        return new Vector3(Random.Range(-spawnHorizontalRange, spawnHorizontalRange), 0, spawnPosZ);
    }
}
