using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodStates : MonoBehaviour
{ 
  SlimeBaseState currentState;
  public QuadState dog = new QuadState();
  public StartState start = new StartState();

 void Start()
  {
    currentState = start;
    currentState.EnterState(this);
  }

 private void Update()
 {
     currentState.UpdateState(this);
 }

public void SwitchState(SlimeBaseState state)
 {
     currentState = state;
     state.EnterState(this);
 }
}
