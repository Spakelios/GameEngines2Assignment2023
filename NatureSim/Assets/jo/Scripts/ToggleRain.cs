using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleRain : MonoBehaviour
{
    public GameObject rain;
    public static bool isRaining = false;

    public void RainSwitch()
    {
        if (rain.activeInHierarchy)
        {
            rain.SetActive(false);
            isRaining = false;
        }

        else
        {
            rain.SetActive(true);
            isRaining = true;
        }
    }
}
