/*Libraries and documentation*/
using UnityEngine;

public class Spawner : MonoBehaviour
{
    

    private float timeBetweenSpawn; // startTimeBetweenSpawn - decreaseTime = timeBetweenSpawn
    public float startTimeBetweenSpawn; // Variable will set time between spawn
    public float decreaseTime; // decrease time value 
    public float minTime = 0.65f; // minimum value of spawntime

    public GameObject[] enemySpawning; // Array of objects

    private void Update()
    {
       if (timeBetweenSpawn <= 0) // Will check if timeBetweenSpawn is greater or equal to 0
        {
            int rand = Random.Range(0, enemySpawning.Length); // Will randomize between 0 to 3(or 4 in last level)
            Instantiate(enemySpawning[rand], transform.position, Quaternion.identity);
            timeBetweenSpawn = startTimeBetweenSpawn;
            if (startTimeBetweenSpawn > minTime)
            {
                startTimeBetweenSpawn -= decreaseTime;
            }
            
        }
       else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
    }
}