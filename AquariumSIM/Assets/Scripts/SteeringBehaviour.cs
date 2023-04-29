using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Boid1))]
public abstract class SteeringBehaviour : MonoBehaviour
{
    public float weight = 1.0f;
    public Vector3 force;

    [HideInInspector]
    public Boid1 boid;

    public void Awake()
    {
        boid = GetComponent<Boid1>();
    }

    public abstract Vector3 Calculate();
}
