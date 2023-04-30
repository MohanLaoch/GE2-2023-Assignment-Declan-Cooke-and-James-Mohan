using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Seek : SteeringBehaviour
{
    public List<GameObject> targetGameObject = new List<GameObject>();
    //public GameObject[] targetGameObject = null;
    public Vector3 target = Vector3.zero;

    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            foreach (GameObject targetObject in targetGameObject)
            {
                Gizmos.color = Color.cyan;
                if (targetGameObject != null)
                {
                    target = targetObject.transform.position;
                }
                Gizmos.DrawLine(transform.position, target);
            }
        }
    }

    public override Vector3 Calculate()
    {
        return boid.SeekForce(target);
    }

    public void Update()
    {
        foreach (GameObject targetObject in targetGameObject)
        {
            if (targetGameObject != null)
            {
                target = targetObject.transform.position;
            }
        }
    }
}
