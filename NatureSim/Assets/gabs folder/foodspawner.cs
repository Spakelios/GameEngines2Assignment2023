using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodspawner : MonoBehaviour
{
    // Start is called before the first frame update
    Camera cam;
    Ray direction;
    public List<GameObject> foodlist;
    int currentfood;
    int maxfood;
    public GameObject spawnmarkerref;
    GameObject spawnmarker;
    private void Start()
    {
        cam = gameObject.GetComponent<Camera>();
        maxfood = foodlist.Count;
        spawnmarker = GameObject.Instantiate(spawnmarkerref);
    }
    private void Update()
    {
        direction = new Ray(transform.position, transform.forward*1000);
        Debug.DrawRay(transform.position, transform.forward*1000, Color.green);
        RaycastHit spawnpos;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(direction, out spawnpos)) {
                GameObject newfood = GameObject.Instantiate(foodlist[currentfood]);
                newfood.transform.position = spawnpos.point+new Vector3(0,2,0);
                    
                    }
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (currentfood == maxfood-1)
                currentfood = 0;
            else currentfood++;
        }

        if (Physics.Raycast(direction, out spawnpos))
        {
            spawnmarker.transform.position = spawnpos.point;
        }

    }

}
