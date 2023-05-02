using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : MonoBehaviour
{
    private GameObject slime;
    private void Start()
    {
        GetComponent<StateMachine>().ChangeState(new WanderState());
        slime = gameObject;
    }

    private void Update()
    {
        
    }
}
