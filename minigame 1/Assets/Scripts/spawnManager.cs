using UnityEngine;

/*-------------------------------------------------
#   File Name: spawnManager.cs
#   Date: 10/3/2025
#   Author: Guilherme Oliveira
#
#   Desc: Spawns in a random item every 
#   few seconds for the player to collect or dodge
-------------------------------------------------*/
public class spawnManager : MonoBehaviour
{
    //----Variables----
    public GameObject goodSpawnable;
    public GameObject badSpawnable;

    private float spawnPosZ = 40;
    private float minSpawnPosY = 1;
    private float maxSpawnPosY = 8;
    private float minSpawnPosX = -8;
    private float maxSpawnPosX = 8;

    private float startDelay = 3f;
    private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Runs "HoleInWallSpawn" every few seconds after waitng
        InvokeRepeating("goodSpawnItem", startDelay, spawnInterval);
        InvokeRepeating("badSpawnItem", startDelay, spawnInterval);
    }

    /*-----------------------------------------
    # Author: Guilherme Oliveira
    # Date: 10/3/25
    # Desc: Both spawn Items for the player to 
    # Collect or avoid durring the time of the game
    -----------------------------------------*/
    void goodSpawnItem()
    {
        Vector3 spawnPos = new Vector3(Random.Range(minSpawnPosX,maxSpawnPosX), Random.Range(minSpawnPosY, maxSpawnPosY), spawnPosZ);

        Instantiate(goodSpawnable, spawnPos, goodSpawnable.transform.rotation);
    }

    void badSpawnItem()
    {
        Vector3 spawnPos = new Vector3(Random.Range(minSpawnPosX, maxSpawnPosX), Random.Range(minSpawnPosY, maxSpawnPosY), spawnPosZ);

        Instantiate(badSpawnable, spawnPos, badSpawnable.transform.rotation);
    }
}
