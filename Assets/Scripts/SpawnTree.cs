using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTree : MonoBehaviour
{
    [SerializeField] GameObject objectToSpawn;
    public float spawnDelay = 5f;
    private float lastSpawnTime;

    void Start()
    {

    }


    void Update()
    {
        if (Time.time > lastSpawnTime + spawnDelay)
        {
            GameObject tree = Instantiate(objectToSpawn, transform.position, Quaternion.identity);
            lastSpawnTime = Time.time;
        }
    }

}
