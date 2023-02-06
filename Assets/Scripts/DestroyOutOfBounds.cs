using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float rightBound = 27;
    private float leftBound = -27;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the player's view, remove that object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }   else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        } 

        if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }   else if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        } 
    }
}
