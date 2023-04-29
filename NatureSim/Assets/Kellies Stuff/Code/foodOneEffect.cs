using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodOneEffect : MonoBehaviour
{
    [SerializeField] public static float eat;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FoodOne"))
        {
            eat += 1;
            Destroy(other.gameObject);
        }
    }
}
