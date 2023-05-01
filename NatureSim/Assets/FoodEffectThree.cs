using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodEffectThree : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Slime"))
        {
            other.GetComponent<SlimeStats>().foodThree += 1;
            Destroy(gameObject);
        }
    }
}