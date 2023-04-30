using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Humanoid : SlimeBaseState
{
    // private SlimeStats slimeStats = new SlimeStats();


    public override void EnterState(FoodStates food)
    {
        Debug.Log("Look hes fleshy!");
        // GameObject.FindGameObjectWithTag("Slime").GetComponent<Animator>().Play("Grow2Legs");
        food.GetComponent<Animator>().Play("Grow2Legs");

    }

    public override void UpdateState(FoodStates food)
    {
        if (food.GetComponent<SlimeStats>().foodOne >= 10)
        {
           // GameObject.FindGameObjectWithTag("Slime").GetComponent<Animator>().Play("Nose");
           food.GetComponent<Animator>().Play("Nose");
        }
        
    }

    public override void OnCollisionEnter(FoodStates food)
    {
        
    }
}