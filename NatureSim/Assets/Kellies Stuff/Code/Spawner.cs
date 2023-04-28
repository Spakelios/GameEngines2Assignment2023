using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject slime;
    
    public void SlimeSpawner()
    {
        Instantiate(slime);
    }
}
