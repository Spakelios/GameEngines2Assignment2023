using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewFOV : MonoBehaviour
{
    public  GameObject food;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FoodOne") || other.CompareTag("FoodTwo") || other.CompareTag("FoodThree"))
        {
            food = other.gameObject;
        }

        switch (transform.parent.tag)
        {
            case "Quad" when other.CompareTag("Quad"):
                Debug.Log("Friend :)");
                break;
            case "Quad" when other.CompareTag("Humanoid"):
                Debug.Log("Prey >:)");
                break;
            case "Quad":
            {
                if (other.CompareTag("Snake"))
                {
                    Debug.Log("Predator :(");
                }

                break;
            }
            case "Humanoid" when other.CompareTag("Quad"):
                Debug.Log("Predator :(");
                break;
            case "Humanoid" when other.CompareTag("Humanoid"):
                Debug.Log("Friend :)");
                break;
            case "Humanoid":
            {
                if (other.CompareTag("Snake"))
                {
                    Debug.Log("Prey >:)");
                }

                break;
            }
            case "Snake" when other.CompareTag("Quad"):
                Debug.Log("Prey >:)");
                break;
            case "Snake" when other.CompareTag("Humanoid"):
                Debug.Log("Predator :(");
                break;
            case "Snake":
            {
                if (other.CompareTag("Snake"))
                {
                    Debug.Log("Friend :)");
                }

                break;
            }
        }
    }
}
