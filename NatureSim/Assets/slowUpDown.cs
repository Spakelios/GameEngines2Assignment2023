using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowUpDown : MonoBehaviour
{
    public float sium;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localPosition =new Vector3(gameObject.transform.position.x, (Mathf.Sin(Time.deltaTime))*sium, gameObject.transform.position.z); 
    }
}
