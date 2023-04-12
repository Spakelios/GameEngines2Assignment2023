using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class SlimeChanges : MonoBehaviour
{
    public static float foodEffect2 = 2;
    public static float foodEffect1 = 2;
   public void Update()
    {
        Vector3 scale = transform.localScale;
 
        scale.Set(foodEffect1, foodEffect2, 2);
 
        transform.localScale = scale;
    }
}
