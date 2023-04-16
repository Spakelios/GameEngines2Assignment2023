using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SlimeHideState : StateMachineTest
{
    private List<Transform> shelterSpots = new List<Transform>();
    private List<GameObject> shelters = new List<GameObject>();
    private NavMeshAgent navAgent;
    private int speed = 10;
    


    public override void EnterState(StateManager slime)
    {
        navAgent = slime.GetComponent<NavMeshAgent>();
        
        shelters.AddRange(GameObject.FindGameObjectsWithTag("Shelter"));

        foreach (var t in shelters)
        {
            shelterSpots.Add(t.transform);
        }
        


        navAgent.isStopped = false;
        navAgent.speed = speed;


        navAgent.SetDestination(GetClosestShelter(slime));


    }

    public override void UpdateState(StateManager slime)
    {
        if (!ToggleRain.isRaining)
        {
            slime.SwitchState(slime.WanderState);
        }
    }

    private Vector3 GetClosestShelter(StateManager slime)
    {
        Vector3 closestShelter = Vector3.zero;
        float closestDistance = Mathf.Infinity;
        Vector3 currentPosition = slime.transform.position;

        foreach (Transform t in shelterSpots)
        {
            Vector3 directionToTarget = t.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;

            if (dSqrToTarget < closestDistance)
            {
                closestDistance = dSqrToTarget;
                closestShelter = t.position;
            }
        }

        return closestShelter;
    }
}
