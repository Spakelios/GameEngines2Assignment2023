using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SlimeBaseState
{
  public abstract void EnterState(FoodStates food);

  public abstract void UpdateState(FoodStates food);

  public abstract void OnCollisionEnter(FoodStates food);
}
