using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrive : SteeringBehaviours
{
    public Vector3 targetPosition = Vector3.zero;
    public float slowingDistance = 15.0f;
    public float deceleration = 10;

    public GameObject targetGameObject;
    

    public override Vector3 Calculate()
    {
        Vector3 force = boid.ArriveForce(targetPosition, slowingDistance, deceleration);
        return force;
    }

    public void Update()
    {
        if (targetGameObject != null)
        {
            targetPosition = new Vector3(targetGameObject.transform.position.x, transform.position.y, targetGameObject.transform.position.z );
        }
    }
}
