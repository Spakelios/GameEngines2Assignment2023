using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeCheck : MonoBehaviour
{

    public static bool slimeInRange;
    public bool isInteracting;

    private void Start()
    {
        isInteracting = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Slime") || isInteracting) return;
        slimeInRange = true;
        isInteracting = true;
    }
}
