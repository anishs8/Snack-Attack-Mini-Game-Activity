using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    public float xRange = 5.0f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Keep player in bounds
        if (transform.position.x < -xRange)
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        if (transform.position.x > xRange)
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }
}
