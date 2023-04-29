using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewFOV : MonoBehaviour
{
    public static GameObject food;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FoodOne") || other.CompareTag("FoodTwo"))
        {
            food = other.gameObject;
        }
    }
}
