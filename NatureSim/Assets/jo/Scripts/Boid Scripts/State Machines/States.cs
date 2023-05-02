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

        else if (owner.GetComponentInChildren<NewFOV>().food != null)
        {
            owner.GetComponent<StateMachine>().ChangeState(new SeekState());
        }

        else if (owner.GetComponentInChildren<NewFOV>().predatorSpotted)
        {
            owner.GetComponent<StateMachine>().ChangeState(new FleeState());
        }
        
        else if (owner.GetComponentInChildren<NewFOV>().preySpotted)
        {
            owner.GetComponent<StateMachine>().ChangeState(new PursueState());
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
        if (owner.GetComponentInChildren<NewFOV>().food == null)
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

public class PursueState : State
{
    public override void EnterState(StateMachine owner)
    {
        owner.GetComponent<Pursue>().enabled = true;
    }

    public override void ExitState(StateMachine owner)
    {
        owner.GetComponentInChildren<NewFOV>().preySpotted = false;
        owner.GetComponent<Pursue>().enabled = false;
    }

    public override void Think(StateMachine owner)
    {
        if (Vector3.Distance(owner.GetComponentInChildren<NewFOV>().slime.transform.position,
            owner.transform.position) > 50)
        {
            owner.ChangeState(new WanderState());
        }
    }
}

public class FleeState: State
{
    public override void EnterState(StateMachine owner)
    {
        owner.GetComponent<Flee>().enabled = true;
    }

    public override void ExitState(StateMachine owner)
    {
        owner.GetComponentInChildren<NewFOV>().predatorSpotted = false;
        owner.GetComponent<Flee>().enabled = false;
    }

    public override void Think(StateMachine owner)
    {
        if (Vector3.Distance(owner.GetComponentInChildren<NewFOV>().slime.transform.position,
            owner.transform.position) > 50)
            
            owner.ChangeState(new WanderState());
        }
    }

