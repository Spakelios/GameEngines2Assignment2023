using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SLIMES", menuName = "SLIME CHANGES")]
public class DataStorage : ScriptableObject
{
  [SerializeField]
  public static float FoodOne = 0;
  public static float FoodTwo = 0;
}
