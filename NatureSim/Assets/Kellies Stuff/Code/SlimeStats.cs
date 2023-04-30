using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeStats : MonoBehaviour
{
    public float foodOne = 0;
    public float foodTwo = 0;
    public static float foodEffect1 = 0;

    public static bool Growlegs;

    private void Update()
    {
       if(Growlegs)
       {
            Vector3 scale = transform.localScale;

            scale.Set(0.1f, foodEffect1, 0.1f);

            transform.localScale = scale;

            if (foodEffect1 >= 0.5f)
            {
                foodEffect1 = 0.5f;
            }
       }
    }

}