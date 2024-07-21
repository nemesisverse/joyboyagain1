using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // The enemy prefab to instantiate
    public Transform[] spawnPoints; // An array to hold the 5 spawn points
    public float spawnInterval = 10f; // Time interval between spawns in seconds

    private float timer;

    void Start()
    {
        if (spawnPoints.Length != 5)
        {
            Debug.LogError("You must assign exactly 5 spawn points.");
            return;
        }

        timer = spawnInterval;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            SpawnEnemies();
            timer = spawnInterval;
        }
    }

    void SpawnEnemies()
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
