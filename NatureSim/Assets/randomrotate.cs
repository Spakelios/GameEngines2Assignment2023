using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomrotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.rotation = new Quaternion(Random.Range(-1000, 1000), Random.Range(-1000, 1000), Random.Range(-1000, 1000), Random.Range(-1000, 1000));
    }

}
