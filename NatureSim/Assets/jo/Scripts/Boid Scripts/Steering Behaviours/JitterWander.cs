using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JitterWander : SteeringBehaviours
{
    public float distance = 20;
    public float radius = 10;
    public float jitter = 100;

    public Vector3 target;
    public Vector3 worldTarget;

    public Vector3 disp;

    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            Vector3 localCP = Vector3.forward * distance;
            Vector3 worldCP = transform.TransformPoint(localCP);
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(worldCP, radius);
            Gizmos.DrawSphere(worldTarget, 0.1f);
            Gizmos.color = Color.magenta;
            Gizmos.DrawLine(transform.position, worldTarget);
        }
    }


    public override Vector3 Calculate()
    {
        disp = Random.insideUnitSphere * (jitter * Time.deltaTime); //calculates the offset
        target += disp;

        target = Vector3.ClampMagnitude(target, radius);

        Vector3 localTarget = (Vector3.forward * distance) + target;

        worldTarget = transform.TransformPoint(localTarget);
        worldTarget.y = 1f;
        target.y = 1f;

        return worldTarget - transform.position;
    }

    // Start is called before the first frame update
    private void OnEnable()
    {
        target = Random.insideUnitSphere * radius; //calculates a random point on a sphere of the specified radius 
    }
}
