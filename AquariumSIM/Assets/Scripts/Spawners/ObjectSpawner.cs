using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [Header("Spawn Area")]
    public float spawnRangeX = 10;
    public float spawnRangeY = 10;
    public float spawnRangeZ = 10;

    [Header("")]
    public GameObject[] objects;

    public int amount = 50;

    void Start()
    {
        for (int i = 0; i < amount; i++)
        {
            int randomIndex = Random.Range(0, objects.Length);
            Vector3 randomSpawnPosition = new Vector3
                (Random.Range(transform.position.x-spawnRangeX / 2, transform.position.x+spawnRangeX / 2), 
                Random.Range(transform.position.y-spawnRangeY / 2, transform.position.y+spawnRangeY / 2), 
                Random.Range(transform.position.z-spawnRangeZ / 2, transform.position.z+spawnRangeZ / 2));
            GameObject newObj = Instantiate(objects[randomIndex], randomSpawnPosition, Quaternion.Euler(0f, 0f, 0f));
        }
    }


    void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireCube(transform.position, new Vector3(spawnRangeX, spawnRangeY, spawnRangeZ));
    }
}