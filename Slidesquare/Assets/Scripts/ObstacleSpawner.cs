using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject obstacle;
    public GameObject movingObstacle;
    public float timeBetweenWaves = 1f;
    public float timeToSpawn = 0f;

    void Update()
    {
        if(Time.time >= timeToSpawn)
        {
            SpawnObstacle();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    /*
    void SpawnObstacles()
    {
        int randomBlockCount = Random.Range(0, spawnPoints.Length - 1);
        int randomPos;
        for (int i = 0; i < randomBlockCount; i++)
        {
            randomPos = Random.Range(0, spawnPoints.Length);
            Instantiate(obstacle, spawnPoints[randomPos].position + transform.position, Quaternion.identity);

        }
    }
    */
    void SpawnObstacle()
    {
        int randomPos = Random.Range(0, spawnPoints.Length);
        int randomObstacle = Random.Range(0, 10);
        //10% chance to spawn a movingObstacle
        if(randomObstacle == 9)
        {
            Instantiate(movingObstacle, spawnPoints[randomPos].position + transform.position, Quaternion.identity);
        } else
        {
            Instantiate(obstacle, spawnPoints[randomPos].position + transform.position, Quaternion.identity);
        }
        
    }

    
}
