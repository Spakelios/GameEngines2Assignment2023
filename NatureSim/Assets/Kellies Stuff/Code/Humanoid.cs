using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humanoid : SlimeBaseState
{

    public override void EnterState(FoodStates food)
    {
        Debug.Log("Look hes fleshy!");
        GameObject.FindGameObjectWithTag("nose").GetComponent<Animator>().Play("animation");
    }

    public override void UpdateState(FoodStates food)
    {
        if (foodOneEffect.eat > 6)
        {
            GameObject.FindGameObjectWithTag("Slime").GetComponent<Animator>().Play("Grow2Legs");
        }
        
    }

    public override void OnCollisionEnter(FoodStates food)
    {
        throw new System.NotImplementedException();
    }
}