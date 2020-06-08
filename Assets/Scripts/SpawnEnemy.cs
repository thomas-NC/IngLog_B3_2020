using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [Header("Spawn attributes")]
    public Transform spawnLocation;
    public Transform target;
    public GameObject Enemy;

    [Header("Wave attributes")]
    public int waveIncrement = 1;
    public float startTime = 3f;
    public float timeBetweenWaves = 5f;
    public float timeBetweenEnemies = 1f;

    void Start()
    {
        InvokeRepeating("SpawnIncrement", startTime, timeBetweenWaves);
        //SpawnIncrement();
    }

    void SpawnIncrement()
    {
        StartCoroutine(wait(timeBetweenEnemies));
        
    }

    IEnumerator wait(float timePause)
    {
        for (int i = 0; i < waveIncrement; i++)
        {
            GameObject enemy = (GameObject)Instantiate(Enemy, spawnLocation.position, spawnLocation.rotation);
            EnemyIA pathfinder = enemy.GetComponent<EnemyIA>();

            if (pathfinder != null)
            {
                pathfinder.target = this.target;
            }

            yield return new WaitForSeconds(timePause);

        }
        waveIncrement++;
        
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
