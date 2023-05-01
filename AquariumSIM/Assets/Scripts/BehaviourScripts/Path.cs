using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public List<Vector3> waypoints = new List<Vector3>();

    public int current = 0;

    public bool isLooped = true;

    [Header("Path Area")]
    public float pathRangeX = 10;
    public float pathRangeY = 10;
    public float pathRangeZ = 10;

    public void OnDrawGizmos()
    {
        //PopulatePath();
        Gizmos.color = Color.cyan;
        for (int i = 1; i < waypoints.Count; i++)
        {
            Gizmos.DrawLine(waypoints[i - 1], waypoints[i]);
            Gizmos.DrawWireSphere(waypoints[i - 1], 1);
            Gizmos.DrawWireSphere(waypoints[i], 1);
        }

        if (isLooped)
        {
            Gizmos.DrawLine(waypoints[waypoints.Count - 1], waypoints[0]);
        }

        Gizmos.color = Color.magenta;
        Gizmos.DrawWireCube(transform.position, new Vector3(pathRangeX, pathRangeY, pathRangeZ));
    }

    private void Start()
    {

        for (int i = 0; i < waypoints.Count; i++)
        {
            Vector3 point = waypoints[i];

            Vector3 randomPoint = new Vector3
                (Random.Range(transform.position.x - pathRangeX / 2, transform.position.x + pathRangeX / 2),
                Random.Range(transform.position.y - pathRangeY / 2, transform.position.y + pathRangeY / 2),
                Random.Range(transform.position.z - pathRangeZ / 2, transform.position.z + pathRangeZ / 2));

            point = randomPoint;

            waypoints[i] = point;
            
        }
    }

    public Vector3 Next()
    {
        return waypoints[current];
    }

    public bool IsLast()
    {
        return (current == waypoints.Count - 1);
    }

    public void AdvanceToNext()
    {
        if (!isLooped)
        {
            if (!IsLast())
            {
                current++;
            }
        }
        else
        {
            current = (current + 1) % waypoints.Count;
        }
    }
}
