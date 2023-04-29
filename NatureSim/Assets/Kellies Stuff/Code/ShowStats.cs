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
        FoodNumOne.text = DataStorage.FoodOne.ToString();
        FoodNumTwo.text = DataStorage.FoodTwo.ToString();
    }
}
