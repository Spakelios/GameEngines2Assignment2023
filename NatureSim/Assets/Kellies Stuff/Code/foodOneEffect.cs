using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodOneEffect : MonoBehaviour
{
    private SlimeStats slimeStats;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Slime"))
        {
            other.GetComponent<SlimeStats>().foodOne += 1;
            Destroy(gameObject);
        }
    }
}
