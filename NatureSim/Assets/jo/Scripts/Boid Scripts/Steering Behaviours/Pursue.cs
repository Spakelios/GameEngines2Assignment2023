using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursue : SteeringBehaviours
{
    public Boid target;
    private NewFOV fov;

    Vector3 targetPos;

    private void OnEnable()
    {
        fov = GetComponentInChildren<NewFOV>();
        target = fov.GetComponentInParent<Boid>();
    }

    public void OnDrawGizmos()
    {
        if (Application.isPlaying && isActiveAndEnabled)
        {
            Gizmos.color = Color.black;
            Gizmos.DrawLine(transform.position, targetPos);
        }
    }

    public override Vector3 Calculate()
    {
        float dist = Vector3.Distance(target.transform.position, transform.position);
        float time = dist / boid.maxSpeed;

        targetPos = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z) + (target.velocity * time);

        return boid.SeekForce(targetPos);
    }
}
