using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        // Get input from WASD or Arrow keys (-1 to 1)
        float moveHorizontal = Input.GetAxis("Horizontal"); // Left / Right (A/D)
        float moveVertical = Input.GetAxis("Vertical");     // Forward / Back (W/S)

        // Create a movement vector
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Move the sphere
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}
