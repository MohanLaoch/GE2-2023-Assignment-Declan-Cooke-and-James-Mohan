using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour
{
    public List<SteeringBehaviour> behaviours = new List<SteeringBehaviour>();

    public Vector3 force = Vector3.zero;
    public Vector3 acceleration = Vector3.zero;
    public Vector3 velocity = Vector3.zero;
    public float mass = 1;

    [Range(0.0f, 10.0f)]
    public float damping = 0.01f;

    public float maxSpeed = 5.0f;
    public float maxForce = 10.0f;

    private void Start()
    {
        SteeringBehaviour[] behaviours = GetComponents<SteeringBehaviour>();

        foreach (SteeringBehaviour b in behaviours)
        {
            this.behaviours.Add(b);
        }
    }

    public Vector3 SeekForce(Vector3 target)
    {
        Vector3 desired = target - transform.position;
        desired.Normalize();
        desired *= maxSpeed;
        return desired - velocity;
    }

    public Vector3 ArriveForce(Vector3 target, float slowingDistance = 10.0f, float decelleration = 3)
    {
        Vector3 toTarget = target - transform.position;

        float distance = toTarget.magnitude;
        Vector3 desired;
        if (distance < slowingDistance)
        {
            desired = maxSpeed * (distance / slowingDistance) * (toTarget / distance);
        }
        else
        {
            desired = maxSpeed * (toTarget / distance);
            decelleration = 1;
        }

        return desired - velocity * decelleration;
    }


    Vector3 Calculate()
    {
        force = Vector3.zero;

        foreach (SteeringBehaviour b in behaviours)
        {
            if (b.isActiveAndEnabled)
            {
                force += b.Calculate() * b.weight;
                float f = force.magnitude;
                if (f > maxForce)
                {
                    force = Vector3.ClampMagnitude(force, maxForce);
                    break;
                }
            }
        }
        return force;
    }

    void Update()
    {
        force = Calculate();
        acceleration = force / mass;
        velocity += acceleration * Time.deltaTime;

        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

        if (velocity.magnitude > 0)
        {
            Vector3 tempUp = Vector3.Lerp(transform.up, Vector3.up + acceleration, Time.deltaTime * 3.0f);
            transform.LookAt(transform.position + velocity, tempUp);

            transform.position += velocity * Time.deltaTime;
            velocity *= (1.0f - (damping * Time.deltaTime));
        }
    }
}
