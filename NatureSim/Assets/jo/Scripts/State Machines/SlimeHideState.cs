using UnityEngine;
using UnityEngine.AI;

public class SlimeHideState : StateMachineTest
{
    private Transform shelterSpot;
    private NavMeshAgent navAgent;
    private int speed = 10;


    public override void EnterState(StateManager slime)
    {
        navAgent = slime.GetComponent<NavMeshAgent>();
        navAgent.isStopped = false;
        shelterSpot = GameObject.Find("Shelter Spot").GetComponent<Transform>();
        navAgent.speed = speed;

        navAgent.SetDestination(shelterSpot.position);


    }

    public override void UpdateState(StateManager slime)
    {
        if (!ToggleRain.isRaining)
        {
            slime.SwitchState(slime.WanderState);
        }
    }
}
