using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeState : SlimeBaseState
{
    public override void EnterState(FoodStates food)
    {
        Debug.Log("Solid Snake");
        food.tag = "Snake";
        food.GetComponent<Animator>().Play("Snaaaaaaaaaakkkeeee!");
    }

    public override void UpdateState(FoodStates food)
    {
        if (food.GetComponent<SlimeStats>().foodThree >= 3)
        {
            food.GetComponent<Animator>().Play("SnakeLegs");
        }
    }

    public override void OnCollisionEnter(FoodStates food)
    {
        /// isdjscnfjk
    }
}

