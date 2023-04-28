using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : MonoBehaviour
{
    private void Start()
    {
        GetComponent<StateMachine>().ChangeState(new WanderState());
    }
}
