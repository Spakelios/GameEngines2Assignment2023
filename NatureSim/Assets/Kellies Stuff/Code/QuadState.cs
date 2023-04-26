using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class QuadState : SlimeBaseState
{
    public override void EnterState(FoodStates food)
    {
      Debug.Log("your mom");
      GameObject.FindGameObjectWithTag("Slime").GetComponent<Animator>().Play("GrowLegs");
    }

    public override void UpdateState(FoodStates food)
    {
        throw new System.NotImplementedException();
    }

    public override void OnCollisionEnter(FoodStates food)
    {
        throw new System.NotImplementedException();
    }
}
