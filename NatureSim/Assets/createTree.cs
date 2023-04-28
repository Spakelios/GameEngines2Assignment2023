using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createTree : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        GameObject tree = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        tree.transform.position = gameObject.transform.position;
    }
}
