using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;

    int zEnemySpawn = -11;
    int xSpawnRange = 10;
    float ySpawn = 0.75f;
    int zSpawnRange = 8;

    int startDelay = 1;
    int enemyRepeating = 2;
    int powerupRepeating = 5;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, enemyRepeating);
        InvokeRepeating("SpawnPowerup", startDelay, powerupRepeating);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SpawnRandomEnemy()
    {
        float randomX = Random.Range(xSpawnRange, -xSpawnRange);
        int randomIndex = Random.Range(0, enemies.Length);
        Instantiate(enemies[randomIndex], new Vector3(randomX, ySpawn, zEnemySpawn), enemies[randomIndex].gameObject.transform.rotation);
    }
    void SpawnPowerup()
    {
        float randomX = Random.Range(xSpawnRange, -xSpawnRange);
        float randomZ = Random.Range(zSpawnRange, -zSpawnRange);
        Instantiate(powerup, new Vector3(randomX, ySpawn, randomZ), powerup.gameObject.transform.rotation);
    }
}
