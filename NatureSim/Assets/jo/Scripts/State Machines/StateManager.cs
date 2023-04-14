using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    private StateMachineTest currentState;
    public readonly SlimeWanderState WanderState = new SlimeWanderState();
    public readonly SlimeHideState HideState = new SlimeHideState();
    public readonly SlimesInteractState InteractState = new SlimesInteractState();
    

    private void Start()
    {
        currentState = WanderState;
        
        currentState.EnterState(this);
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(StateMachineTest state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
