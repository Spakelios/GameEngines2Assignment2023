using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class StartState : SlimeBaseState
{
   
    public override void EnterState(FoodStates food)
    {
        Debug.Log("your dad");
        // GameObject.FindGameObjectWithTag("Slime").GetComponent<Animator>().Play("breathe");
        food.GetComponent<Animator>().Play("breathe");
    }

    public override void UpdateState(FoodStates food)
    {
        if (DataStorage.FoodOne == 0 && DataStorage.FoodTwo == 0)
        {
            food.GetComponent<Animator>().Play("breathe");
        }
        else if(DataStorage.FoodOne >= 3 && DataStorage.FoodTwo == 0)
        {
            food.SwitchState(food.dog);
        }
        else if(DataStorage.FoodOne == 0 && DataStorage.FoodTwo >= 3)
        {
             food.SwitchState(food.human);
        }
    }

    public override void OnCollisionEnter(FoodStates food)
    {
       /// isdjscnfjk
    }
}
