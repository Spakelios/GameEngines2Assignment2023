using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewFOV : MonoBehaviour
{
    public  GameObject food;
    public GameObject slime;
    public bool preySpotted;
    public bool predatorSpotted;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FoodOne") || other.CompareTag("FoodTwo") || other.CompareTag("FoodThree"))
        {
            food = other.gameObject;
        }

        if (transform.parent.tag == "Quad")
        {
            if (other.CompareTag("Quad"))
            {
                Debug.Log("Friend :)");
            }
            
            else if (other.CompareTag("Snake"))
            {
                predatorSpotted = true;
                slime = other.gameObject;
            }
            
            else if (other.CompareTag("Humanoid"))
            {
                preySpotted = true;
                slime = other.gameObject;
            }
        }
        
        else if (transform.parent.tag == "Humanoid")
        {
            if (other.CompareTag("Humanoid"))
            {
                Debug.Log("Friend :)");
            }
            
            else if (other.CompareTag("Quad"))
            {
                predatorSpotted = true;
                slime = other.gameObject;
            }
            
            else if (other.CompareTag("Snake"))
            {
                preySpotted = true;
                slime = other.gameObject;
            }
        }
        
        else if (transform.parent.tag == "Snake")
        {
            if (other.CompareTag("Snake"))
            {
                Debug.Log("Friend :)");
            }
            
            else if (other.CompareTag("Humanoid"))
            {
                predatorSpotted = true;
                slime = other.gameObject;
            }
            
            else if (other.CompareTag("Quad"))
            {
                preySpotted = true;
                slime = other.gameObject;
            }
        }
    }
}
