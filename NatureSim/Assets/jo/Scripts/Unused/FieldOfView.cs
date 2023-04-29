using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    public float radius;
    
    [Range(0, 360)]
    public float angle;
    

    public LayerMask foodMask;
    public LayerMask slimeMask;
    public LayerMask obstacleMask;

    public Vector3 closestPos;

    public bool canSee;


    private void Start()
    {
        StartCoroutine(FOVRoutine());
    }

    private IEnumerator FOVRoutine()
    {
        WaitForSeconds wait = new WaitForSeconds(0.2f);

        while (true)
        {
            yield return wait;
            FOVCheck();
        }
    }

    private void FOVCheck()
    {
        Collider[] rangeChecks = Physics.OverlapSphere(transform.position, radius, foodMask);
        closestPos = Vector3.zero;
        var closestDistance = Mathf.Infinity;
        var currentPosition = transform.position;

        if (rangeChecks.Length != 0)
        {
            foreach (var c in rangeChecks)
            {
                var directionToTarget = c.transform.position - currentPosition;

                if (Vector3.Angle(transform.forward, directionToTarget) < angle / 2)
                {
                    var dSqrToTarget = directionToTarget.sqrMagnitude;

                    if (dSqrToTarget < closestDistance)
                    {
                        closestDistance = dSqrToTarget;
                        closestPos = c.transform.position;
                    }

                    if (!Physics.Raycast(transform.position, directionToTarget, dSqrToTarget, obstacleMask))
                    {
                        canSee = true;
                    }

                    else
                    {
                        canSee = false;
                    }
                }

                else
                {
                    canSee = false;
                }
            }
            
        }
        
        else if (canSee)
        {
            canSee = false;
        }
    }
}

