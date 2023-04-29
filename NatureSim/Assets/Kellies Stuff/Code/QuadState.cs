using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class QuadState : SlimeBaseState
{

    public override void EnterState(FoodStates food)
    {
      Debug.Log("your mom");
      // GameObject.FindGameObjectWithTag("Slime").GetComponent<Animator>().Play("GrowLegs");
      food.GetComponent<Animator>().Play("GrowLegs");
    }

    public override void UpdateState(FoodStates food)
    {
        if (DataStorage.FoodTwo >= 10)
        {
            // GameObject.FindGameObjectWithTag("Slime").GetComponent<Animator>().Play("Tail#");
            food.GetComponent<Animator>().Play("Tail#");
            Debug.Log("you 0_0");
            // GameObject.FindGameObjectWithTag("Slime").GetComponent<Animator>().Play("TailWag");
            food.GetComponent<Animator>().Play("TailWag");
        }

        if (DataStorage.FoodTwo >= 6)
        {
            SlimeChanges.growLegs = true;
            SlimeChanges.foodEffect1 += 0.02f;
        }
    }

    public override void OnCollisionEnter(FoodStates food)
    {
        throw new System.NotImplementedException();
    }
}
