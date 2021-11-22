using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnE : MonoBehaviour
{
    public GameObject enemy;
    public Transform spawnPoint;
    public float maxX;
    public float maxZ;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnEnemy", .5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        float randomX = Random.Range(-maxX, maxX);
        float randomZ = Random.Range(-maxZ, maxZ);
        
        Vector3 randomSpawnPos = new Vector3(randomX, 10f, randomZ);
        Instantiate(enemy, randomSpawnPos, Quaternion.identity);
        
    }
}
