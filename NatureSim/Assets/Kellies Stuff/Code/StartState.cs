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
        if (foodOneEffect.eat <= 1 && FoodTwoEffect.eat2 <= 1)
        {
            GameObject.FindGameObjectWithTag("Slime").GetComponent<Animator>().Play("breathe");
        }
        else
        {
            food.SwitchState(food.dog);
        }
        if (FoodTwoEffect.eat2 > 1 && foodOneEffect.eat <= 1)
        {
            food.SwitchState(food.human);
        }
        else
        {
            GameObject.FindGameObjectWithTag("Slime").GetComponent<Animator>().Play("breathe");
        }
    }

    public override void OnCollisionEnter(FoodStates food)
    {
        throw new System.NotImplementedException();
    }
}
