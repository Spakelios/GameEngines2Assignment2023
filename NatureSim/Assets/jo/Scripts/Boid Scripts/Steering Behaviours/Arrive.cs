using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrive : SteeringBehaviours
{
    public Vector3 targetPosition = Vector3.zero;
    public float slowingDistance = 15.0f;
    public float deceleration = 10;

    public GameObject targetGameObject;
    public List<GameObject> targetGameObjects;
    public List<Transform> targetPositions;

    private Vector3 closestPos;


    private void OnEnable()
    {
        targetGameObject = GameObject.FindWithTag("Target");
        
        targetGameObjects.AddRange(GameObject.FindGameObjectsWithTag("Target"));

        foreach (var t in targetGameObjects)
        {
            targetPositions.Add(t.transform);
        }

        GetClosestPos();
    }

    public override Vector3 Calculate()
    {
        Vector3 force = boid.ArriveForce(targetPosition, slowingDistance, deceleration);
        return force;
    }

    public void Update()
    {
        if (targetGameObject != null)
        {
            //targetPosition = new Vector3(targetGameObject.transform.position.x, transform.position.y, targetGameObject.transform.position.z );
            targetPosition = new Vector3(closestPos.x, transform.position.y, closestPos.z);
        }
    }

    private Vector3 GetClosestPos()
    {
        closestPos = Vector3.zero;
        var closestDistance = Mathf.Infinity;
        var currentPosition = transform.position;
        foreach (Transform t in targetPositions)
        {
            Vector3 directionToTarget = t.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;

            if (dSqrToTarget < closestDistance)
            {
                closestDistance = dSqrToTarget;
                closestPos = t.position;
            }
        }

        return closestPos;
    }
}
