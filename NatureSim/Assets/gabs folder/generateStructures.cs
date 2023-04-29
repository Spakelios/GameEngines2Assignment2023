using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateStructures : MonoBehaviour
{
    // Start is called before the first frame update
    public maptest map;
    public bool startgenerating;
    public int genpercentage;
    public GameObject testobject;
    public List<GameObject> objectlist;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(startgenerating == true)
        {
            Matrix4x4 localToWorld = transform.localToWorldMatrix;

            for (int z = 0, i = 0; z <= map.zSize; z++)
            {
                for (int x = 0; x <= map.xSize; x++)
                {
                   // print(map.VertHeightValue[x,z]);
                    int rand = Random.Range(1, 100);
                    //print(rand);
                    /*if (foreach)
                    {
                        GameObject test;
                        test = Instantiate(testobject);
                        test.transform.position = map.vertpos[i];
                        test.transform.position = new Vector3(test.transform.position.x, test.transform.position.y + 3, test.transform.position.z);
                        print( map.vertpos[i]);
                        print(i);
                        
                    }*/

                    for(int d = 0; d<objectlist.Count; d++)
                        
                        if(objectlist[d].GetComponent<SpawnDetails>().spawnheight == map.VertHeightValue[x,z] && rand < objectlist[d].GetComponent<SpawnDetails>().chancetospawn)
                        {
                            GameObject test;
                            test = Instantiate(objectlist[d]);
                            test.transform.position = map.vertpos[i];
                            test.transform.position = new Vector3(test.transform.position.x, test.transform.position.y + 3, test.transform.position.z);
                        }

                    i++;
                }

            }
            startgenerating = false;
        }
    }
    
}
