using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecam : MonoBehaviour
{
    public Camera camref;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation = camref.transform.rotation;
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += transform.forward;
        }
        if(Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += transform.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position -= transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position -= transform.right;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            gameObject.transform.position -= new Vector3(0,1, 0);
        }
    }
}
