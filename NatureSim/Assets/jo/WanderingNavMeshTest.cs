using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class WanderingNavMeshTest : MonoBehaviour
{
    public NavMeshAgent navAgent;

    public int speed;
    public float walkRadius;

    private Vector3 finalPosition;
    private Vector3 randomPosition;
    
    


    private void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();

        navAgent.speed = speed;
        navAgent.SetDestination(RandomLocation());
    }

    private void Update()
    {
        if (navAgent.remainingDistance <= navAgent.stoppingDistance)
        {
            navAgent.SetDestination(RandomLocation());
        }
    }

    private Vector3 RandomLocation()
    {
        finalPosition = Vector3.zero;
        randomPosition = Random.insideUnitSphere * walkRadius;
        randomPosition += transform.position;

        if (NavMesh.SamplePosition(randomPosition, out NavMeshHit hit, walkRadius, 1))
        {
            finalPosition = hit.position;
        }

        return finalPosition;

    }


}
