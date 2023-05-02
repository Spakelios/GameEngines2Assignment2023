using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flee : SteeringBehaviours
{
    public GameObject targetGameObject = null;
    public Vector3 target = Vector3.zero;

    public NewFOV fov;
    
    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            Gizmos.color = Color.cyan;
            if (fov.slime != null)
            {
                target = fov.slime.transform.position;
            }
            Gizmos.DrawLine(transform.position, target);
        }
    }

    private void OnEnable()
    {
        fov = GetComponentInChildren<NewFOV>();
    }

    public override Vector3 Calculate()
    {
        return - boid.SeekForce(target);
    }

    public void Update()
    {
        if (targetGameObject != null)
        {
            target = fov.slime.transform.position;
        }
    }
}
