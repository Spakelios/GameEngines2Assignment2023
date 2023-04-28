using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    public abstract void EnterState(StateMachine owner);
    public abstract void ExitState(StateMachine owner);
    public abstract void Think(StateMachine owner);

}

public class StateMachine : MonoBehaviour
{
    public State currentState;
    public State previousState;
    private IEnumerator coroutine;
    
    public int updatesPerSecond = 5;
    
    private void OnEnable()
    {        
        StartCoroutine(Think());
    }
    
    IEnumerator ChangeStateCoRoutine(State newState, float delay)
    {
        yield return new WaitForSeconds(delay);
        ChangeState(newState);
    }
    
    public void RevertToPreviousState()
    {
        ChangeState(previousState);
    }
    
    public void ChangeState(State newState)
    {
        currentState?.ExitState(this);
        if (this.previousState == null || previousState.GetType() != this.previousState.GetType())
        {
            this.previousState = currentState;
        }
        currentState = newState;
        Debug.Log(currentState.GetType());
        currentState.EnterState(this);
    }
    
    private IEnumerator Think()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(0, 0.5f));
        while (true)
        {
            currentState?.Think(this);

            yield return new WaitForSeconds(1.0f / (float)updatesPerSecond);
        }
    }



}
