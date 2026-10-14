using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float leftLimit = 50;
    private float bottomLimit = -50;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x > leftLimit)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < bottomLimit)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

    }
}
