using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTwoEffect : MonoBehaviour

{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Slime"))
        {
          other.GetComponent<SlimeStats>().foodTwo += 1;
            Destroy(gameObject);
        }
    }

}
