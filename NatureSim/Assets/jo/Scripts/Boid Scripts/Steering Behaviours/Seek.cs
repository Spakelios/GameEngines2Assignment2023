using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : SteeringBehaviours
{
    //public GameObject targetGameObject = null;
    public Vector3 target = Vector3.zero;
    public void OnDrawGizmos()
    {
        if (!isActiveAndEnabled || !Application.isPlaying) return;
        Gizmos.color = Color.cyan;
        if (NewFOV.food != null)
        {
            target = NewFOV.food.transform.position;
        }
        Gizmos.DrawLine(transform.position, target);
    }
    
    public override Vector3 Calculate()
    {
        return boid.SeekForce(target);    
    }

    public void Update()
    {
        if (NewFOV.food != null)
        {
            target = NewFOV.food.transform.position;
        }
    }
    
    
}
