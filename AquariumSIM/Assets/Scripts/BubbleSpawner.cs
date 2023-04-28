using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    [Header("Spawn Area")]
    public float spawnRangeX = 5;
    public float spawnRangeY = 2;
    public float spawnRangeZ = 5;

    [Header("")]
    public GameObject bubble;

    public int amount = 5;

    public float spawnRate;

    private bool canSpawn = true;

    void Update()
    {
        if (canSpawn)
        {
            StartCoroutine(Spawn());
        }
    }

    IEnumerator Spawn()
    {
        canSpawn = false;
        float timeToNextSpawn = 1 / spawnRate;

        for (int i = 0; i < amount; i++)
        {
            Vector3 randomSpawnPosition = new Vector3
                (Random.Range(transform.position.x - spawnRangeX / 2, transform.position.x + spawnRangeX / 2),
                Random.Range(transform.position.y - spawnRangeY / 2, transform.position.y + spawnRangeY / 2),
                Random.Range(transform.position.z - spawnRangeZ / 2, transform.position.z + spawnRangeZ / 2));
            GameObject newObj = Instantiate(bubble, randomSpawnPosition, Quaternion.Euler(0f, 0f, 0f));
        }

        yield return new WaitForSeconds(timeToNextSpawn);
        canSpawn = true;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(transform.position, new Vector3(spawnRangeX, spawnRangeY, spawnRangeZ));
    }
}
