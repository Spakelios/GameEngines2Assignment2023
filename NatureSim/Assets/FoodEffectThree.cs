using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodEffectThree : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Slime") || other.CompareTag("Quad") || other.CompareTag("Humanoid") || other.CompareTag("Snake"))
        {
            other.GetComponent<SlimeStats>().foodThree += 1;
            Destroy(gameObject);
        }
    }
}