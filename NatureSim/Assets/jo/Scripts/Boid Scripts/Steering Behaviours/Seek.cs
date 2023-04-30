using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : SteeringBehaviours
{
    //public GameObject targetGameObject = null;
    public Vector3 target = Vector3.zero;
    public NewFOV food;
    public void OnDrawGizmos()
    {
        if (!isActiveAndEnabled || !Application.isPlaying) return;
        Gizmos.color = Color.cyan;
        if (food.food != null)
        {
            target = food.food.transform.position;
        }
        Gizmos.DrawLine(transform.position, target);
    }

    private void OnEnable()
    {
        food = GetComponentInChildren<NewFOV>();
    }

    public override Vector3 Calculate()
    {
        return boid.SeekForce(target);    
    }

    public void Update()
    {
        if (food.food != null)
        {
            target = food.food.transform.position;
        }
    }
    
    
}
