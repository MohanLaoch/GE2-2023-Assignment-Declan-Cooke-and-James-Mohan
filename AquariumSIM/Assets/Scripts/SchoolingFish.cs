using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolingFish : SteeringBehaviour
{
    public Boid leader;
    Vector3 targetPos;
    Vector3 worldTarget;
    Vector3 offset;

    
    void Start()
    {
        offset = transform.position - leader.transform.position;

        offset = Quaternion.Inverse(leader.transform.rotation) * offset;
    }

    
    public override Vector3 Calculate()
    {
        worldTarget = leader.transform.TransformPoint(offset);
        float dist = Vector3.Distance(transform.position, worldTarget);
        float time = dist / boid.maxSpeed;

        targetPos = worldTarget + (leader.velocity * time);
        return boid.ArriveForce(targetPos);
    }
}
