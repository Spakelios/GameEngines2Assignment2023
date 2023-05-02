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
        food.tag = "Humanoid";
        food.GetComponent<Animator>().Play("Grow2Legs");
        // food.GetComponent<Material>().color = Color.yellow;

    }

    public override void UpdateState(FoodStates food)
    {
        if (food.GetComponent<SlimeStats>().foodOne >= 2)
        {
           // GameObject.FindGameObjectWithTag("Slime").GetComponent<Animator>().Play("Nose");
           food.GetComponent<Animator>().Play("Nose");
        }

        if (food.GetComponent<SlimeStats>().foodOne >= 3 && food.GetComponent<SlimeStats>().foodTwo >= 2)
        {
            food.GetComponent<Animator>().Play("GrowArms");
        }
        
    }

    public override void OnCollisionEnter(FoodStates food)
    {
        
    }
}