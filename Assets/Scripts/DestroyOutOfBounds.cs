using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float lowerBound = -2.0f;

    void Update()
    {
        if (transform.position.y < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
