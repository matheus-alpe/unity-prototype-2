using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private readonly float topBound = 30;
    private readonly float lowerBound = -10;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound || transform.position.z < lowerBound)
        {
            Destroy(gameObject);

            if (transform.position.z < lowerBound)
            {
                Debug.Log("Game over!");
            }
        }
    }
}
