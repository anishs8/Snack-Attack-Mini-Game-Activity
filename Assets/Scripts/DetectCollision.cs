using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public int score = 0;
    public float timeRemaining = 60.0f;
    public bool isGameActive = true;

    void Update()
    {
        if (isGameActive)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                isGameActive = false;
                Debug.Log("TIME'S UP! Final Score: " + score);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isGameActive) return;

        // Check collectible type using If-statements
        if (other.CompareTag("Good"))
        {
            score += 1;
            Debug.Log("Collected Snack! Score: " + score);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Bad"))
        {
            score = 0; // Lose all current progress
            Debug.Log("Hit Bad Item! Score reset to: " + score);
            Destroy(other.gameObject);
        }
    }
}
