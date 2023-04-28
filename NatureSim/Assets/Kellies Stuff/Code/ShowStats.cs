using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowStats : MonoBehaviour
{
    public TextMeshProUGUI FoodNumOne;
    public TextMeshProUGUI FoodNumTwo;

    private void Update()
    {
        FoodNumOne.text = foodOneEffect.eat.ToString();
        FoodNumTwo.text = FoodTwoEffect.eat2.ToString();
    }
}
