using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] collectiblePrefabs;
    private float spawnRangeX = 4.5f;
    private float spawnPosY = 8.0f;
    private float startDelay = 1.0f;
    private float spawnInterval = 1.2f;

    void Start()
    {
        InvokeRepeating("SpawnRandomCollectible", startDelay, spawnInterval);
    }

    void SpawnRandomCollectible()
    {
        int index = Random.Range(0, collectiblePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, 0);
        Instantiate(collectiblePrefabs[index], spawnPos, collectiblePrefabs[index].transform.rotation);
    }
}
