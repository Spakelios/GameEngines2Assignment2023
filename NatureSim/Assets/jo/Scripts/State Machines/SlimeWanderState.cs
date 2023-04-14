using UnityEngine;
using UnityEngine.AI;

public class SlimeWanderState : StateMachineTest
{
    private NavMeshAgent navAgent;

    private int speed = 5;
    private float walkRadius = 25;

    private Vector3 finalPosition;
    private Vector3 randomPosition;
    
    public override void EnterState(StateManager slime)
    {
        navAgent = slime.GetComponent<NavMeshAgent>();
        navAgent.isStopped = false;

        navAgent.speed = speed;
        navAgent.SetDestination(RandomLocation(slime));
    }

    public override void UpdateState(StateManager slime)
    {
        if (navAgent.remainingDistance <= navAgent.stoppingDistance)
        {
            navAgent.SetDestination(RandomLocation(slime));
        }


        if (!ToggleRain.isRaining) return;
        
        navAgent.isStopped = true;
        slime.SwitchState(slime.HideState);
    }

    private Vector3 RandomLocation(StateManager slime)
    {
        //finalPosition = Vector3.zero;
        randomPosition = Random.insideUnitSphere * walkRadius;
        randomPosition += slime.transform.position;

        if (NavMesh.SamplePosition(randomPosition, out NavMeshHit hit, walkRadius, 1))
        {
            finalPosition = hit.position;
        }
        return finalPosition;
    }
}
