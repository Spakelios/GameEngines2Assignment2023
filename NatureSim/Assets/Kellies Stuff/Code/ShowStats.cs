using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowStats : MonoBehaviour
{
    public TextMeshProUGUI FoodNumOne;
    public TextMeshProUGUI FoodNumTwo;
    
    public SlimeStats Slime;

    private void Update()
    {
        FoodNumOne.text = Slime.foodOne.ToString();
        FoodNumTwo.text = Slime.foodTwo.ToString();
    }
}
