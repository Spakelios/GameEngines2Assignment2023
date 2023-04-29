using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTwoEffect : MonoBehaviour
{
    public static float eat2 =  0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FoodTwo"))
        { 
            eat2 += 1;
            Destroy(other.gameObject);
        }
    }


}
