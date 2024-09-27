using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private readonly float spawnLimitXLeft = -22;
    private readonly float spawnLimitXRight = 7;
    private readonly float spawnPosY = 30;

    private readonly float startDelay = 1.0f;
    private readonly float spawnIntervalMin = 3.0f;
    private readonly float spawnIntervalMax = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomBall), startDelay, Random.Range(spawnIntervalMin, spawnIntervalMax));
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[0], spawnPos, ballPrefabs[0].transform.rotation);
    }

}
