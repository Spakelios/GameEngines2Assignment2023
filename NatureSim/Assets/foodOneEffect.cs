using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodOneEffect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SlimeChanges.foodEffect2 -= 0.2f;
            Destroy(gameObject);
        }
    }
}
