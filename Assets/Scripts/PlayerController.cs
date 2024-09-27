using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float horizontalRange = 10.0f;

    public GameObject projectilePrefab;
    public float HorizontalInput
    {
        get => Input.GetAxis("Horizontal");
    }

    bool CanShoot
    {
        get => Input.GetKeyDown(KeyCode.Space);
    }


    void Update()
    {
        transform.Translate(HorizontalInput * speed * Time.deltaTime * Vector3.right);
        CheckBoundary();
        ShootHandler();
    }

    void ShootHandler()
    {
        if (!CanShoot) return;
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }


    void CheckBoundary()
    {
        if (transform.position.x < -horizontalRange)
        {
            SetBoundary(-horizontalRange);
            return;
        }

        if (transform.position.x > horizontalRange)
        {
            SetBoundary(horizontalRange);
        }
    }

    void SetBoundary(float value)
    {
        transform.position = new Vector3(value, transform.position.y, transform.position.z);
    }
}
