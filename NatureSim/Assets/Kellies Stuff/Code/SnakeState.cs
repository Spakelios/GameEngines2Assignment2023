using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeState : SlimeBaseState
{
    public override void EnterState(FoodStates food)
    {
      Debug.Log("Solid Snake");
      food.tag = "Snake";
    }

    public override void UpdateState(FoodStates food)
    {
       
    }

    public override void OnCollisionEnter(FoodStates food)
    {
        /// isdjscnfjk
    }
}

