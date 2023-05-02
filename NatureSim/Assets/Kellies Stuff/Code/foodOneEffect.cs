using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodOneEffect : MonoBehaviour
{
    private SlimeStats slimeStats;
    private void OnTriggerEnter(Collider other)
    {
        if ((other.CompareTag("Slime") || other.CompareTag("Quad") || other.CompareTag("Humanoid") || other.CompareTag("Snake")))
        {
            other.GetComponent<SlimeStats>().foodOne += 1;
            Destroy(gameObject);
        }
    }
}
