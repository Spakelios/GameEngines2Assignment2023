using System.Collections;
using System.Collections.Generic;
using TMPro;
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

        if (NewFOV.food != null)
        {
            owner.GetComponent<StateMachine>().ChangeState(new SeekState());
        }

        if (SlimeCheck.slimeInRange)
        {
            owner.GetComponent<StateMachine>().ChangeState(new InteractState());
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
            owner.RevertToPreviousState();
        }
    }
}

public class SeekState : State
{
    public override void EnterState(StateMachine owner)
    {
        owner.GetComponent<Seek>().enabled = true;
    }

    public override void ExitState(StateMachine owner)
    {
        owner.GetComponent<Seek>().enabled = false;
    }

    public override void Think(StateMachine owner)
    {
        if (NewFOV.food == null)
        {
            owner.ChangeState(new WanderState());
        }
        
        if (ToggleRain.isRaining)
        {
            owner.ChangeState(new ArriveState());
        }
    }
}

public class InteractState : State
{
    public override void EnterState(StateMachine owner)
    {
        owner.GetComponentInChildren<TextMeshPro>().text = "Hi!";
    }

    public override void ExitState(StateMachine owner)
    {
        owner.GetComponentInChildren<TextMeshPro>().text = "";
    }

    public override void Think(StateMachine owner)
    {
        if (ToggleRain.isRaining)
        {
            owner.ChangeState(new ArriveState());
        }
    }
}
