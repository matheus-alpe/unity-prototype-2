using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastFired;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && lastFired - Time.time < -1)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Debug.Log(Time.realtimeSinceStartup);
            lastFired = Time.time;
        }
    }
}
