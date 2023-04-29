using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodOneEffect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FoodOne"))
        {
            DataStorage.FoodOne += 1;
            Destroy(other.gameObject);
        }
    }
}
