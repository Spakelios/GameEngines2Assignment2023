using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class StartState : SlimeBaseState
{
    public override void EnterState(FoodStates food)
    {
        Debug.Log("your dad");
        GameObject.FindGameObjectWithTag("Slime").GetComponent<Animator>().Play("breathe");
    }

    public override void UpdateState(FoodStates food)
    {
        if (foodOneEffect.eat == 0 && FoodTwoEffect.eat2 == 0)
        {
            GameObject.FindGameObjectWithTag("Slime").GetComponent<Animator>().Play("breathe");
        }
        else if(foodOneEffect.eat >= 3 && FoodTwoEffect.eat2 == 0)
        {
            food.SwitchState(food.dog);
        }
        else if(foodOneEffect.eat == 0 && FoodTwoEffect.eat2 >= 3)
        {
             food.SwitchState(food.human);
        }
    }

    public override void OnCollisionEnter(FoodStates food)
    {
        throw new System.NotImplementedException();
    }
}
