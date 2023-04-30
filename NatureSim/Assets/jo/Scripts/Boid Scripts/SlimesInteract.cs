using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimesInteract : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Slime"))
        {
            Debug.Log("Hi!");
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Slime"))
        {
            Debug.Log("Bye!");
        }
    }
}
