using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderState: State
{
    public override void EnterState(StateMachine owner)
    {
        owner.GetComponent<JitterWander>().enabled = true;
    }

    public override void ExitState(StateMachine owner)
    {
        owner.GetComponent<JitterWander>().enabled = false;
    }

    public override void Think(StateMachine owner)
    {
        if (ToggleRain.isRaining)
        {
            owner.ChangeState(new ArriveState());
        }
    }
}

public class ArriveState : State
{
    public override void EnterState(StateMachine owner)
    {
        owner.GetComponent<Arrive>().enabled = true;
    }

    public override void ExitState(StateMachine owner)
    {
        owner.GetComponent<Arrive>().enabled = false;
    }

    public override void Think(StateMachine owner)
    {
        if (!ToggleRain.isRaining)
        {
            owner.ChangeState(new WanderState());
        }
    }
}
