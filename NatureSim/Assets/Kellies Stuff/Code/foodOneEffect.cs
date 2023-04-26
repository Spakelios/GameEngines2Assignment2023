using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodOneEffect : MonoBehaviour
{
    public static bool Eaten = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Slime"))
        {
            Eaten = true;
            Destroy(gameObject);
        }
    }
}
