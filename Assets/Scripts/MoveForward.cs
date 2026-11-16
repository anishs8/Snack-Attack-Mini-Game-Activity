using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float fallSpeed = 5.0f;

    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * fallSpeed, Space.World);
    }
}
