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
        if (foodOneEffect.eat >= 10)
        {
            GameObject.FindGameObjectWithTag("Slime").GetComponent<Animator>().Play("Tail#");
            Debug.Log("you 0_0");
            GameObject.FindGameObjectWithTag("Slime").GetComponent<Animator>().Play("TailWag");
        }

        if (FoodTwoEffect.eat2 >= 6)
        {
            SlimeChanges.growLegs = true;
            SlimeChanges.foodEffect1 += 0.2f;
        }
    }

    public override void OnCollisionEnter(FoodStates food)
    {
        throw new System.NotImplementedException();
    }
}
