using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateLeafs : MonoBehaviour
{
    public GameObject leafPrefab;
    public int maxnumberOfLeafs;
    int numberofleafs;
    // Start is called before the first frame update
    void Start()
    {
        numberofleafs = Random.Range(3, 6);
        for( int i =0; i<= numberofleafs; i++)
        {
            GameObject leaf = GameObject.Instantiate(leafPrefab);
            leaf.transform.SetParent(gameObject.transform);
            leaf.transform.localPosition = new Vector3(Random.Range(-2f, 2f), Random.Range(0f, 2f), Random.Range(-2f, 2f));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
