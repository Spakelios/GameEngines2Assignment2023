using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class SlimeChanges : MonoBehaviour
{
    public static float foodEffect1 = 0;

    public static bool growLegs;

    public void Update()
    {
        if (growLegs)
        {
            Vector3 scale = transform.localScale;

            scale.Set(0.1f, foodEffect1, 0.1f);

            transform.localScale = scale;

            if (foodEffect1 >= 0.7f)
            {
                foodEffect1 = 0.7f;
            }
        }
    }
}
