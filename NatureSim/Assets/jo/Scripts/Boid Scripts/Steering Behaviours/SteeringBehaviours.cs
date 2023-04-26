using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Boid))]
public abstract class SteeringBehaviours : MonoBehaviour
{
    public float weight = 1.0f;
    public Vector3 force;

    [HideInInspector]
    public Boid boid;

    public void Awake()
    {
        boid = GetComponent<Boid>();
    }

    public abstract Vector3 Calculate(); //every steering behaviour class has to have this, as it's part of the base class
}
